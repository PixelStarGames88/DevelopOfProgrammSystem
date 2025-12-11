namespace MasterOfArrays;

public class WindowAccountCreating : WindowChapter
{
    public TextBox RepeatPasswordBox { get; private set; } = null!;
    public TextBox PasswordBox { get; private set; } = null!;
    public TextBox LoginNameBox { get; private set; } = null!;
    public TextBox LastNameBox { get; private set; } = null!;
    public TextBox FirstNameBox { get; private set; } = null!;
    private Label _firstNameLabel = null!;
    private Button _exitButton = null!;
    private Button _finishButton = null!;
    private Label _repeatPasswordLabel = null!;
    private Label _passwordLabel = null!;
    private Label _loginLabel = null!;
    private Label _lastNameLabel = null!;
    private Label _accCreatingLabel = null!;
    private Label _appTitle = null!;
    public WindowAccountCreating(Control parent) : base(parent)
    { }
    protected override void InitializeComponent()
    {
        _appTitle = new Label();
        _accCreatingLabel = new Label();
        _repeatPasswordLabel = new Label();
        RepeatPasswordBox = new TextBox();
        _passwordLabel = new Label();
        PasswordBox = new TextBox();
        _loginLabel = new Label();
        LoginNameBox = new TextBox();
        _lastNameLabel = new Label();
        LastNameBox = new TextBox();
        _finishButton = new Button();
        _firstNameLabel = new Label();
        _exitButton = new Button();
        FirstNameBox = new TextBox();
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
        // mainPanel
        // 
        MainPanel.Controls.Add(_accCreatingLabel);
        MainPanel.Controls.Add(_repeatPasswordLabel);
        MainPanel.Controls.Add(RepeatPasswordBox);
        MainPanel.Controls.Add(_passwordLabel);
        MainPanel.Controls.Add(PasswordBox);
        MainPanel.Controls.Add(_loginLabel);
        MainPanel.Controls.Add(LoginNameBox);
        MainPanel.Controls.Add(_lastNameLabel);
        MainPanel.Controls.Add(LastNameBox);
        MainPanel.Controls.Add(_finishButton);
        MainPanel.Controls.Add(_firstNameLabel);
        MainPanel.Controls.Add(_exitButton);
        MainPanel.Controls.Add(FirstNameBox);
        MainPanel.Controls.Add(_appTitle);
        // 
        // _accCreatingLabel
        // 
        _accCreatingLabel.Font = new Font("Old English Text MT", 20F);
        _accCreatingLabel.Location = new Point(54, 81);
        _accCreatingLabel.Name = "AccCreatingLabel";
        _accCreatingLabel.Size = new Size(249, 42);
        _accCreatingLabel.TabIndex = 21;
        _accCreatingLabel.Text = "Acc Creating";
        // 
        // _repeatPasswordLabel
        // 
        _repeatPasswordLabel.Font = new Font("Old English Text MT", 13F);
        _repeatPasswordLabel.Location = new Point(428, 207);
        _repeatPasswordLabel.Name = "RepeatPasswordLabel";
        _repeatPasswordLabel.Size = new Size(178, 23);
        _repeatPasswordLabel.TabIndex = 19;
        _repeatPasswordLabel.Text = "Repeat Password";
        // 
        // RepeaPasswordBox
        // 
        RepeatPasswordBox.BackColor = Color.Black;
        RepeatPasswordBox.BorderStyle = BorderStyle.FixedSingle;
        RepeatPasswordBox.Font = new Font("Old English Text MT", 13F);
        RepeatPasswordBox.ForeColor = Color.White;
        RepeatPasswordBox.Location = new Point(428, 233);
        RepeatPasswordBox.Name = "RepeaPasswordBox";
        RepeatPasswordBox.PasswordChar = '*';
        RepeatPasswordBox.Size = new Size(297, 34);
        RepeatPasswordBox.TabIndex = 20;
        // 
        // _passwordLabel
        // 
        _passwordLabel.Font = new Font("Old English Text MT", 13F);
        _passwordLabel.Location = new Point(428, 144);
        _passwordLabel.Name = "PasswordLabel";
        _passwordLabel.Size = new Size(100, 23);
        _passwordLabel.TabIndex = 17;
        _passwordLabel.Text = "Password";
        // 
        // PasswordBox
        // 
        PasswordBox.BackColor = Color.Black;
        PasswordBox.BorderStyle = BorderStyle.FixedSingle;
        PasswordBox.Font = new Font("Old English Text MT", 13F);
        PasswordBox.ForeColor = Color.White;
        PasswordBox.Location = new Point(428, 170);
        PasswordBox.Name = "PasswordBox";
        PasswordBox.PasswordChar = '*';
        PasswordBox.Size = new Size(297, 34);
        PasswordBox.TabIndex = 18;
        // 
        // _loginLabel
        // 
        _loginLabel.Font = new Font("Old English Text MT", 13F);
        _loginLabel.Location = new Point(428, 81);
        _loginLabel.Name = "LoginLabel";
        _loginLabel.Size = new Size(100, 23);
        _loginLabel.TabIndex = 15;
        _loginLabel.Text = "Login";
        // 
        // LoginNameBox
        // 
        LoginNameBox.BackColor = Color.Black;
        LoginNameBox.BorderStyle = BorderStyle.FixedSingle;
        LoginNameBox.Font = new Font("Old English Text MT", 13F);
        LoginNameBox.ForeColor = Color.White;
        LoginNameBox.Location = new Point(428, 107);
        LoginNameBox.Name = "LoginNameBox";
        LoginNameBox.Size = new Size(297, 34);
        LoginNameBox.TabIndex = 16;
        // 
        // _lastNameLabel
        // 
        _lastNameLabel.Font = new Font("Old English Text MT", 13F);
        _lastNameLabel.Location = new Point(54, 207);
        _lastNameLabel.Name = "LastNameLabel";
        _lastNameLabel.Size = new Size(116, 23);
        _lastNameLabel.TabIndex = 13;
        _lastNameLabel.Text = "Last Name";
        // 
        // LastNameBox
        // 
        LastNameBox.BackColor = Color.Black;
        LastNameBox.BorderStyle = BorderStyle.FixedSingle;
        LastNameBox.Font = new Font("Old English Text MT", 13F);
        LastNameBox.ForeColor = Color.White;
        LastNameBox.Location = new Point(54, 233);
        LastNameBox.Name = "LastNameBox";
        LastNameBox.Size = new Size(297, 34);
        LastNameBox.TabIndex = 14;
        // 
        // _finishButton
        // 
        _finishButton.FlatStyle = FlatStyle.Flat;
        _finishButton.Font = new Font("Old English Text MT", 12F);
        _finishButton.Location = new Point(428, 301);
        _finishButton.Name = "FinishButton";
        _finishButton.Size = new Size(112, 47);
        _finishButton.TabIndex = 12;
        _finishButton.Text = "Finish";
        _finishButton.ForeColor = Color.DarkRed;
        // 
        // _firstNameLabel
        // 
        _firstNameLabel.Font = new Font("Old English Text MT", 13F);
        _firstNameLabel.Location = new Point(54, 144);
        _firstNameLabel.Name = "FirstNameLabel";
        _firstNameLabel.Size = new Size(130, 23);
        _firstNameLabel.TabIndex = 1;
        _firstNameLabel.Text = "First Name";
        // 
        // _exitButton
        // 
        _exitButton.FlatStyle = FlatStyle.Flat;
        _exitButton.Font = new Font("Old English Text MT", 12F);
        _exitButton.Location = new Point(613, 301);
        _exitButton.Name = "ExitButton";
        _exitButton.Size = new Size(112, 47);
        _exitButton.TabIndex = 3;
        _exitButton.Text = "Exit";
        _exitButton.ForeColor = Color.DarkRed;
        // 
        // FirstNameBox
        // 
        FirstNameBox.BackColor = Color.Black;
        FirstNameBox.BorderStyle = BorderStyle.FixedSingle;
        FirstNameBox.Font = new Font("Old English Text MT", 13F);
        FirstNameBox.ForeColor = Color.White;
        FirstNameBox.Location = new Point(54, 170);
        FirstNameBox.Name = "FirstNameBox";
        FirstNameBox.Size = new Size(297, 34);
        FirstNameBox.TabIndex = 2;
    }
    public void ExitButton_Click(EventHandler outEvent)
    {
        _exitButton.Click += outEvent;
    }
    public void FinishButton_Click(EventHandler outEvent)
    {
        _finishButton.Click += outEvent;
    }
    public override void Close()
    {
        LastNameBox.Clear();
        FirstNameBox.Clear();
        LoginNameBox.Clear();
        PasswordBox.Clear();
        RepeatPasswordBox.Clear();
        base.Close();
    }
}