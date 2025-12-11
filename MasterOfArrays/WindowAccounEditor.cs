namespace MasterOfArrays;

public class WindowAccounEditor : WindowChapter
{
    public TextBox FirstNameTextBox { get; set; } = null!;
    public TextBox LastNameTextBox { get; set; } = null!;
    public TextBox PasswordTextBox { get; set; } = null!;
    public TextBox LoginTextBox { get; set; } = null!;

    private Label _appTitle = null!;
    private Button _exitButton = null!;
    private Label _firstNameLabel = null!;
    private Button _backButton = null!;
    private Label _lastNameLabel = null!;
    private Label _loginLabel = null!;
    private Label _passwordLabel = null!;
    private Button _deleteAccButton = null!;
    private Button _applyButton = null!;
    public WindowAccounEditor(Control parent) : base(parent)
    {
        InitializeComponent(parent);
    }
    protected void InitializeComponent(Control parent)
    {
        _exitButton = new Button();
        _firstNameLabel = new Label();
        FirstNameTextBox = new TextBox();
        _appTitle = new Label();
        _backButton = new Button();
        _lastNameLabel = new Label();
        _loginLabel = new Label();
        _passwordLabel = new Label();
        LastNameTextBox = new TextBox();
        PasswordTextBox = new TextBox();
        LoginTextBox = new TextBox();
        _deleteAccButton = new Button();
        _applyButton = new Button();
        // 
        // Exit
        // 
        _exitButton.FlatStyle = FlatStyle.Flat;
        _exitButton.Font = new Font("Old English Text MT", 12F);
        _exitButton.Location = new Point(585, 270);
        _exitButton.Name = "Exit";
        _exitButton.Size = new Size(153, 44);
        _exitButton.TabIndex = 12;
        _exitButton.Text = "Exit from acc";
        // 
        // _firstNameLabel
        // 
        _firstNameLabel.Font = new Font("Old English Text MT", 18F);
        _firstNameLabel.Location = new Point(22, 123);
        _firstNameLabel.Name = "firstNameLabel";
        _firstNameLabel.Size = new Size(209, 41);
        _firstNameLabel.TabIndex = 17;
        _firstNameLabel.Text = "First Name";
        // 
        // FirstNameTextBox
        // 
        FirstNameTextBox.BackColor = Color.Black;
        FirstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
        FirstNameTextBox.Font = new Font("Old English Text MT", 18F);
        FirstNameTextBox.ForeColor = Color.White;
        FirstNameTextBox.Location = new Point(237, 120);
        FirstNameTextBox.Name = "FirstNameTextBox";
        FirstNameTextBox.Size = new Size(297, 44);
        FirstNameTextBox.TabIndex = 2;
        // 
        // _appTitle
        // 
        _appTitle.Font = new Font("Old English Text MT", 24F);
        _appTitle.Location = new Point(240, 9);
        _appTitle.Name = "AppTitle";
        _appTitle.Size = new Size(317, 52);
        _appTitle.TabIndex = 0;
        _appTitle.Text = "Master of Arrays";
        _appTitle.ForeColor = Color.DarkRed;
        // 
        // _backButton
        // 
        _backButton.FlatStyle = FlatStyle.Flat;
        _backButton.Font = new Font("Old English Text MT", 12F);
        _backButton.Location = new Point(585, 170);
        _backButton.Name = "BackButton";
        _backButton.Size = new Size(153, 44);
        _backButton.TabIndex = 18;
        _backButton.Text = "Back";
        // 
        // _lastNameLabel
        // 
        _lastNameLabel.Font = new Font("Old English Text MT", 18F);
        _lastNameLabel.Location = new Point(22, 173);
        _lastNameLabel.Name = "lastNameLabel";
        _lastNameLabel.Size = new Size(209, 41);
        _lastNameLabel.TabIndex = 19;
        _lastNameLabel.Text = "Last Name";
        // 
        // _loginLabel
        // 
        _loginLabel.Font = new Font("Old English Text MT", 18F);
        _loginLabel.Location = new Point(22, 223);
        _loginLabel.Name = "LoginLabel";
        _loginLabel.Size = new Size(209, 41);
        _loginLabel.TabIndex = 20;
        _loginLabel.Text = "Login";
        // 
        // _passwordLabel
        // 
        _passwordLabel.Font = new Font("Old English Text MT", 18F);
        _passwordLabel.Location = new Point(22, 273);
        _passwordLabel.Name = "PasswordLabel";
        _passwordLabel.Size = new Size(209, 41);
        _passwordLabel.TabIndex = 21;
        _passwordLabel.Text = "Password";
        // 
        // LastNameTextBox
        // 
        LastNameTextBox.BackColor = Color.Black;
        LastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
        LastNameTextBox.Font = new Font("Old English Text MT", 18F);
        LastNameTextBox.ForeColor = Color.White;
        LastNameTextBox.Location = new Point(237, 170);
        LastNameTextBox.Name = "LastNameTextBox";
        LastNameTextBox.Size = new Size(297, 44);
        LastNameTextBox.TabIndex = 22;
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.BackColor = Color.Black;
        PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
        PasswordTextBox.Font = new Font("Old English Text MT", 18F);
        PasswordTextBox.ForeColor = Color.White;
        PasswordTextBox.Location = new Point(237, 270);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new Size(297, 44);
        PasswordTextBox.TabIndex = 24;
        PasswordTextBox.PasswordChar = '*';
        // 
        // LoginTextBox
        // 
        LoginTextBox.BackColor = Color.Black;
        LoginTextBox.BorderStyle = BorderStyle.FixedSingle;
        LoginTextBox.Font = new Font("Old English Text MT", 18F);
        LoginTextBox.ForeColor = Color.White;
        LoginTextBox.Location = new Point(237, 220);
        LoginTextBox.Name = "LoginTextBox";
        LoginTextBox.Size = new Size(297, 44);
        LoginTextBox.TabIndex = 23;
        // 
        // _deleteAccButton
        // 
        _deleteAccButton.FlatStyle = FlatStyle.Flat;
        _deleteAccButton.Font = new Font("Old English Text MT", 12F);
        _deleteAccButton.Location = new Point(585, 220);
        _deleteAccButton.Name = "DeleteAccButton";
        _deleteAccButton.Size = new Size(153, 44);
        _deleteAccButton.TabIndex = 26;
        _deleteAccButton.Text = "Delete acc";
        // 
        // _applyButton
        // 
        _applyButton.FlatStyle = FlatStyle.Flat;
        _applyButton.Font = new Font("Old English Text MT", 12F);
        _applyButton.Location = new Point(585, 120);
        _applyButton.Name = "ApplyButton";
        _applyButton.Size = new Size(153, 44);
        _applyButton.TabIndex = 25;
        _applyButton.Text = "Apply";

        MainPanel.Controls.Add(_deleteAccButton);
        MainPanel.Controls.Add(_applyButton);
        MainPanel.Controls.Add(PasswordTextBox);
        MainPanel.Controls.Add(LoginTextBox);
        MainPanel.Controls.Add(LastNameTextBox);
        MainPanel.Controls.Add(_passwordLabel);
        MainPanel.Controls.Add(_loginLabel);
        MainPanel.Controls.Add(_lastNameLabel);
        MainPanel.Controls.Add(_backButton);
        MainPanel.Controls.Add(_exitButton);
        MainPanel.Controls.Add(_firstNameLabel);
        MainPanel.Controls.Add(FirstNameTextBox);
        MainPanel.Controls.Add(_appTitle);
    }
    public void FillTextBoxes(string FirstName, string LastName, string Login, string Password)
    {
        FirstNameTextBox.Text = FirstName;
        LastNameTextBox.Text = LastName;
        LoginTextBox.Text = Login;
        PasswordTextBox.Text = Password;
    }
    public void BackButton_Click(EventHandler outEvent)
    {
        _backButton.Click += outEvent;
    }
    public void ExitButton_Click(EventHandler outEvent)
    {
        _exitButton.Click += outEvent;
    }
    public void DeleteAccButton_Click(EventHandler outEvent)
    {
        _deleteAccButton.Click += outEvent;
    }
    public void ApplyButton_Click(EventHandler outEvent)
    {
        _applyButton.Click += outEvent;
    }
}