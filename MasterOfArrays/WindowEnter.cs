namespace MasterOfArrays;

public class WindowEnter : WindowChapter
{
    public TextBox PasswordBox {  get; private set; } = null!;
    public TextBox UserNameBox { get; private set; } = null!;
    private Label _enterPassword = null!;
    private Label _currentUser = null!;
    private Button _enterButton = null!;
    private Button _newAccButton = null!;
    private Button _exitButton = null!;
    private Label _appTitle = null!;
    public void EnterButton_Click(EventHandler outEvent)
    {
        _enterButton.Click += outEvent;
    }
    public void NewAccButton_Click(EventHandler outEvent)
    {
        _newAccButton.Click += outEvent;
    }
    public void ExitButton_Click(EventHandler outEvent)
    {
        _exitButton.Click += outEvent;
    }
    public WindowEnter(Control parent) : base(parent)
    {
    }
    protected override void InitializeComponent()
    {
        PasswordBox = new TextBox();
        _enterPassword = new Label();
        _currentUser = new Label();
        UserNameBox = new TextBox();
        _enterButton = new Button();
        _newAccButton = new Button();
        _exitButton = new Button();
        _appTitle = new Label();

        MainPanel.Location = new Point(0, 0);
        MainPanel.Name = "mainPanel";
        MainPanel.Size = new Size(800, 450);
        MainPanel.TabIndex = 0;
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
        // PasswordBox
        // 
        PasswordBox.BackColor = Color.Black;
        PasswordBox.BorderStyle = BorderStyle.FixedSingle;
        PasswordBox.Font = new Font("Old English Text MT", 13F);
        PasswordBox.ForeColor = Color.White;
        PasswordBox.Location = new Point(200, 210);
        PasswordBox.Name = "passwordBox";
        PasswordBox.PasswordChar = '*';
        PasswordBox.Size = new Size(410, 34);
        PasswordBox.TabIndex = 1;
        // 
        // _enterPassword
        // 
        _enterPassword.Font = new Font("Old English Text MT", 13F);
        _enterPassword.Location = new Point(200, 180);
        _enterPassword.Name = "enterPassword";
        _enterPassword.Size = new Size(148, 27);
        _enterPassword.TabIndex = 0;
        _enterPassword.Text = "Password";
        // 
        // _currentUser
        // 
        _currentUser.Font = new Font("Old English Text MT", 13F);
        _currentUser.Location = new Point(200, 110);
        _currentUser.Name = "CurrentUser";
        _currentUser.Size = new Size(148, 27);
        _currentUser.TabIndex = 0;
        _currentUser.Text = "User name";
        // 
        // userNameBox
        // 
        UserNameBox.BackColor = Color.Black;
        UserNameBox.BorderStyle = BorderStyle.FixedSingle;
        UserNameBox.Font = new Font("Old English Text MT", 13F);
        UserNameBox.ForeColor = Color.White;
        UserNameBox.Location = new Point(200, 140);
        UserNameBox.Name = "userNameBox";
        UserNameBox.Size = new Size(410, 34);
        UserNameBox.TabIndex = 2;
        // 
        // NewUser
        // 
        _enterButton.FlatStyle = FlatStyle.Flat;
        _enterButton.Font = new Font("Old English Text MT", 12F);
        _enterButton.Location = new Point(250, 280);
        _enterButton.Name = "NewUser";
        _enterButton.Size = new Size(290, 40);
        _enterButton.TabIndex = 1;
        _enterButton.Text = "Enter";
        _enterButton.ForeColor = Color.White;
        // 
        // _newAccButton
        // 
        _newAccButton.FlatStyle = FlatStyle.Flat;
        _newAccButton.Font = new Font("Old English Text MT", 12F);
        _newAccButton.Location = new Point(250, 340);
        _newAccButton.Name = "NewUser";
        _newAccButton.Size = new Size(140, 40);
        _newAccButton.TabIndex = 1;
        _newAccButton.Text = "New Account";
        _newAccButton.ForeColor = Color.DarkRed;
        //
        // _newAccButton
        // 
        _exitButton.FlatStyle = FlatStyle.Flat;
        _exitButton.Font = new Font("Old English Text MT", 12F);
        _exitButton.Location = new Point(400, 340);
        _exitButton.Name = "NewUser";
        _exitButton.Size = new Size(140, 40);
        _exitButton.TabIndex = 1;
        _exitButton.Text = "Exit";
        _exitButton.ForeColor = Color.DarkRed;

        MainPanel.Controls.Add(UserNameBox);
        MainPanel.Controls.Add(_appTitle);
        MainPanel.Controls.Add(PasswordBox);
        MainPanel.Controls.Add(_enterPassword);
        MainPanel.Controls.Add(_currentUser);
        MainPanel.Controls.Add(_enterButton);
        MainPanel.Controls.Add(_newAccButton);
        MainPanel.Controls.Add(_exitButton);
    }
    public override void Close()
    {
        UserNameBox.Clear();
        PasswordBox.Clear();
        base.Close();
    }
}