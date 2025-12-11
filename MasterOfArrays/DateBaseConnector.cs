using Microsoft.Data.Sqlite;
using System.Data;

namespace MasterOfArrays;

public class DateBaseConnector
{
    private readonly string _dbPath;
    public string CurrentUserLogin { get; private set; }
    public string CurrentPassword { get; private set; }
    public string CurrentFirstName { get; private set; }
    public string CurrentLastName { get; private set; }
    public string CurrentArray { get; set; } = null!;
    public Dictionary<string, string> UserArrays { get; private set; }
    public DateBaseConnector()
    {
        CurrentUserLogin = "";
        CurrentFirstName = "";
        CurrentLastName = "";
        CurrentPassword = "";
        UserArrays = new Dictionary<string, string>();

        _dbPath = "app.db";
        CreateDataBaseIfNoExist();
    }
    private void CreateDataBaseIfNoExist()
    {
        string connectionString = $"Data Source={_dbPath}";
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var createTableUsers = @"
        CREATE TABLE IF NOT EXISTS Users
        (
            User_Login TEXT PRIMARY KEY,
            User_First_Name TEXT,
            User_Last_Name TEXT,
            User_Password TEXT
        );";
        using var cmdCreateTableUsers = new SqliteCommand(createTableUsers, connection);
        cmdCreateTableUsers.ExecuteNonQuery();

        var createTableUserArrays = @"
        CREATE TABLE IF NOT EXISTS UserArrays
        (
            Array_Unique_Name TEXT,
            User_ID TEXT,
            Array_Body TEXT,
            FOREIGN KEY (User_ID) REFERENCES Users(User_Login) ON UPDATE CASCADE ON DELETE CASCADE,
            PRIMARY KEY(User_ID, Array_Unique_Name)
        );";

        using var cmdCreateTableUserArrays = new SqliteCommand(createTableUserArrays, connection);
        cmdCreateTableUserArrays.ExecuteNonQuery();
    }

    public bool AddUser(string login, string password, string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) return false;

        string connectionString = $"Data Source={_dbPath}";
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        using var InsertCmd = connection.CreateCommand();
        InsertCmd.CommandText = @"
            INSERT INTO Users(User_Login, User_First_Name, User_Last_Name, User_Password)
            VALUES($login, $firstName, $lastName, $password);
        ";
        InsertCmd.Parameters.AddWithValue("$login", login);
        InsertCmd.Parameters.AddWithValue("$password", password);
        InsertCmd.Parameters.AddWithValue("$firstName", firstName);
        InsertCmd.Parameters.AddWithValue("$lastName", lastName);

        try
        {
            InsertCmd.ExecuteNonQuery();

            CurrentFirstName = firstName;
            CurrentLastName = lastName;
            CurrentPassword = password;
            CurrentUserLogin = login;

            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool DeleteUser(string login)
    {
        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();

        using var DeleteCmd = connection.CreateCommand();
        DeleteCmd.CommandText = @"
            DELETE FROM Users WHERE User_Login = $login;
        ";
        DeleteCmd.Parameters.AddWithValue("$login", login);
        try
        {
            DeleteCmd.ExecuteNonQuery();
            CurrentArray = "";
            CurrentUserLogin = "";
            CurrentFirstName = "";
            CurrentLastName = "";
            CurrentPassword = "";
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool ChangeUserData(string currentligin, string firstName, string lastName, string login, string password)
    {
        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) return false;

        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();

        using var ChangeCmd = connection.CreateCommand();
        ChangeCmd.CommandText = @"
            UPDATE Users
            SET User_First_Name = $firstName, User_Last_Name = $secondName, User_Password = $passowrd
            WHERE User_Login = $currentlogin;
            UPDATE Users
            SET User_Login = $login
            WHERE User_Login = $currentlogin;
        ";
        ChangeCmd.Parameters.AddWithValue("$currentlogin", currentligin);
        ChangeCmd.Parameters.AddWithValue("$firstName", firstName);
        ChangeCmd.Parameters.AddWithValue("$secondName", lastName);
        ChangeCmd.Parameters.AddWithValue("$login", login);
        ChangeCmd.Parameters.AddWithValue("$passowrd", password);
        try
        {
            ChangeCmd.ExecuteNonQuery();
            CurrentUserLogin = login;
            CurrentFirstName = firstName;
            CurrentLastName = lastName;
            CurrentPassword = password;
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool SignIsWellDone(string login, string password)
    {
        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();

        using var SelectCmd = connection.CreateCommand();
        SelectCmd.CommandText = @"
            SELECT User_First_Name, User_Last_Name FROM Users
            WHERE User_Login = $login AND User_Password = $password;";

        SelectCmd.Parameters.AddWithValue("$login", login);
        SelectCmd.Parameters.AddWithValue("$password", password);

        var result = SelectCmd.ExecuteScalar();

        using var CmdReader = SelectCmd.ExecuteReader();
        if (CmdReader.Read())
        {
            CurrentFirstName = CmdReader.GetString(0);
            CurrentLastName = CmdReader.GetString(1);

            CurrentPassword = password; CurrentUserLogin = login;

            FoundArrays();

            return true;
        }
        return false;
    }
    private void FoundArrays()
    {
        UserArrays.Clear();

        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();

        using var SelectCmd = connection.CreateCommand();
        SelectCmd.CommandText = @"
            SELECT Array_Unique_Name, Array_Body FROM UserArrays
            WHERE User_ID = $login;";
        SelectCmd.Parameters.AddWithValue("$login", CurrentUserLogin);

        using var CmdReader = SelectCmd.ExecuteReader();
        while (CmdReader.Read())
        {
            var key = CmdReader.GetString("Array_Unique_Name");
            var value = CmdReader.GetString("Array_Body");

            UserArrays[(string)key] = (string)value;
        }
    }
    public bool GetArrayFromDB(out string arrayBody, string arrayName)
    {
        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();

        using var SelectCmd = connection.CreateCommand();
        SelectCmd.CommandText = @"
            SELECT Array_Unique_Name, Array_Body FROM UserArrays
            WHERE Array_Unique_Name = $arrayName;
        ";
        SelectCmd.Parameters.AddWithValue("$arrayName", arrayName);

        try
        {
            using var CmdReader = SelectCmd.ExecuteReader();
            CmdReader.Read();
            CurrentArray = CmdReader.GetString("Array_Unique_Name");

            arrayBody = CmdReader.GetString("Array_Body");
            return true;
        }
        catch
        {
            arrayBody = "";
            return false;
        }
    }
    public bool UpdateArray(string UpdatedArray, string NameArray)
    {
        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();
        using var UpdateCmd = connection.CreateCommand();
        UpdateCmd.CommandText = @"
            UPDATE UserArrays
            SET Array_Body = $UpdatedArray
            WHERE Array_Unique_Name = $name AND User_ID = $login;";
        UpdateCmd.Parameters.AddWithValue("$UpdatedArray", UpdatedArray);
        UpdateCmd.Parameters.AddWithValue("$name", NameArray);
        UpdateCmd.Parameters.AddWithValue("$login", CurrentUserLogin);
        try
        {
            UpdateCmd.ExecuteNonQuery();
            FoundArrays();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool AddArray(string UpdatedArray, string NameArray)
    {
        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();
        using var UpdateCmd = connection.CreateCommand();
        UpdateCmd.CommandText = @"
            INSERT INTO UserArrays(User_ID, Array_Unique_Name, Array_Body)
            VALUES($login, $name, $UpdatedArray);";
        UpdateCmd.Parameters.AddWithValue("$UpdatedArray", UpdatedArray);
        UpdateCmd.Parameters.AddWithValue("$name", NameArray);
        UpdateCmd.Parameters.AddWithValue("$login", CurrentUserLogin);
        try
        {
            UpdateCmd.ExecuteNonQuery();
            FoundArrays();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool DeleteArray(string NameArray)
    {
        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();

        using var DeleteCmd = connection.CreateCommand();
        DeleteCmd.CommandText = @"
            DELETE FROM UserArrays
            WHERE Array_Unique_Name = $name and User_ID = $userName;
        ";
        DeleteCmd.Parameters.AddWithValue("$name", NameArray);
        DeleteCmd.Parameters.AddWithValue("$userName", CurrentUserLogin);
        try
        {
            DeleteCmd.ExecuteNonQuery();
            FoundArrays();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool VacuumDB()
    {
        using var connection = new SqliteConnection($"Data Source={_dbPath}");
        connection.Open();

        using var VacuumCmd = connection.CreateCommand();
        VacuumCmd.CommandText = @"VACUUM;";
       
            VacuumCmd.ExecuteNonQuery();
            return true;
    }
}