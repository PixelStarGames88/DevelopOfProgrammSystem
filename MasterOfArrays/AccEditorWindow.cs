namespace MasterOfArrays;

public class AccEditorWindow : ChapterWindow
{
    private Label AppTitle;
    private Button ExitButton;
    private Label firstNameLabel;
    public TextBox FirstNameTextBox { get; set; }
    private Button BackButton;
    private Label lastNameLabel;
    private Label LoginLabel;
    private Label PasswordLabel;
    public TextBox LastNameTextBox { get; set; }
    public TextBox PasswordTextBox { get; set; }
    public TextBox LoginTextBox { get; set; }
    private Button DeleteAccButton;
    private Button ApplyButton;
    public AccEditorWindow(Control parent) : base(parent)
    {
        InitializeComponent(parent);
    }
    protected void InitializeComponent(Control parent)
    {
        ExitButton = new Button();
        firstNameLabel = new Label();
        FirstNameTextBox = new TextBox();
        AppTitle = new Label();
        BackButton = new Button();
        lastNameLabel = new Label();
        LoginLabel = new Label();
        PasswordLabel = new Label();
        LastNameTextBox = new TextBox();
        PasswordTextBox = new TextBox();
        LoginTextBox = new TextBox();
        DeleteAccButton = new Button();
        ApplyButton = new Button();
        // 
        // Exit
        // 
        ExitButton.FlatStyle = FlatStyle.Flat;
        ExitButton.Font = new Font("Old English Text MT", 12F);
        ExitButton.Location = new Point(585, 270);
        ExitButton.Name = "Exit";
        ExitButton.Size = new Size(153, 44);
        ExitButton.TabIndex = 12;
        ExitButton.Text = "Exit from acc";
        // 
        // firstNameLabel
        // 
        firstNameLabel.Font = new Font("Old English Text MT", 18F);
        firstNameLabel.Location = new Point(22, 123);
        firstNameLabel.Name = "firstNameLabel";
        firstNameLabel.Size = new Size(209, 41);
        firstNameLabel.TabIndex = 17;
        firstNameLabel.Text = "First Name";
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
        // AppTitle
        // 
        AppTitle.Font = new Font("Old English Text MT", 24F);
        AppTitle.Location = new Point(240, 9);
        AppTitle.Name = "AppTitle";
        AppTitle.Size = new Size(317, 52);
        AppTitle.TabIndex = 0;
        AppTitle.Text = "Master of Arrays";
        // 
        // BackButton
        // 
        BackButton.FlatStyle = FlatStyle.Flat;
        BackButton.Font = new Font("Old English Text MT", 12F);
        BackButton.Location = new Point(585, 170);
        BackButton.Name = "BackButton";
        BackButton.Size = new Size(153, 44);
        BackButton.TabIndex = 18;
        BackButton.Text = "Back";
        // 
        // lastNameLabel
        // 
        lastNameLabel.Font = new Font("Old English Text MT", 18F);
        lastNameLabel.Location = new Point(22, 173);
        lastNameLabel.Name = "lastNameLabel";
        lastNameLabel.Size = new Size(209, 41);
        lastNameLabel.TabIndex = 19;
        lastNameLabel.Text = "Last Name";
        // 
        // LoginLabel
        // 
        LoginLabel.Font = new Font("Old English Text MT", 18F);
        LoginLabel.Location = new Point(22, 223);
        LoginLabel.Name = "LoginLabel";
        LoginLabel.Size = new Size(209, 41);
        LoginLabel.TabIndex = 20;
        LoginLabel.Text = "Login";
        // 
        // PasswordLabel
        // 
        PasswordLabel.Font = new Font("Old English Text MT", 18F);
        PasswordLabel.Location = new Point(22, 273);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(209, 41);
        PasswordLabel.TabIndex = 21;
        PasswordLabel.Text = "Password";
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
        // DeleteAccButton
        // 
        DeleteAccButton.FlatStyle = FlatStyle.Flat;
        DeleteAccButton.Font = new Font("Old English Text MT", 12F);
        DeleteAccButton.Location = new Point(585, 220);
        DeleteAccButton.Name = "DeleteAccButton";
        DeleteAccButton.Size = new Size(153, 44);
        DeleteAccButton.TabIndex = 26;
        DeleteAccButton.Text = "Delete acc";
        // 
        // ApplyButton
        // 
        ApplyButton.FlatStyle = FlatStyle.Flat;
        ApplyButton.Font = new Font("Old English Text MT", 12F);
        ApplyButton.Location = new Point(585, 120);
        ApplyButton.Name = "ApplyButton";
        ApplyButton.Size = new Size(153, 44);
        ApplyButton.TabIndex = 25;
        ApplyButton.Text = "Apply";

        MainPanel.Controls.Add(DeleteAccButton);
        MainPanel.Controls.Add(ApplyButton);
        MainPanel.Controls.Add(PasswordTextBox);
        MainPanel.Controls.Add(LoginTextBox);
        MainPanel.Controls.Add(LastNameTextBox);
        MainPanel.Controls.Add(PasswordLabel);
        MainPanel.Controls.Add(LoginLabel);
        MainPanel.Controls.Add(lastNameLabel);
        MainPanel.Controls.Add(BackButton);
        MainPanel.Controls.Add(ExitButton);
        MainPanel.Controls.Add(firstNameLabel);
        MainPanel.Controls.Add(FirstNameTextBox);
        MainPanel.Controls.Add(AppTitle);
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
        BackButton.Click += outEvent;
    }
    public void ExitButton_Click(EventHandler outEvent)
    {
        ExitButton.Click += outEvent;
    }
    public void DeleteAccButton_Click(EventHandler outEvent)
    {
        DeleteAccButton.Click += outEvent;
    }
    public void ApplyButton_Click(EventHandler outEvent)
    {
        ApplyButton.Click += outEvent;
    }
}