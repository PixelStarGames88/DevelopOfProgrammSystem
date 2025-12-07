namespace MasterOfArrays;

public class EnterWindow : ChapterWindow
{
    public TextBox passwordBox {  get; private set; }
    public TextBox UserNameBox { get; private set; }
    private Label enterPassword;
    private Label CurrentUser;
    private Button EnterButton;
    private Button NewAccButton;
    private Button ExitButton;
    private Label AppTitle;
    public void EnterButton_Click(EventHandler outEvent)
    {
        EnterButton.Click += outEvent;
    }
    public void NewAccButton_Click(EventHandler outEvent)
    {
        NewAccButton.Click += outEvent;
    }
    public void ExitButton_Click(EventHandler outEvent)
    {
        ExitButton.Click += outEvent;
    }
    public EnterWindow(Control parent) : base(parent)
    {
    }
    protected override void InitializeComponent()
    {
        passwordBox = new TextBox();
        enterPassword = new Label();
        CurrentUser = new Label();
        UserNameBox = new TextBox();
        EnterButton = new Button();
        NewAccButton = new Button();
        ExitButton = new Button();
        AppTitle = new Label();

        MainPanel.Location = new Point(0, 0);
        MainPanel.Name = "mainPanel";
        MainPanel.Size = new Size(800, 450);
        MainPanel.TabIndex = 0;
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
        // passwordBox
        // 
        passwordBox.BackColor = Color.Black;
        passwordBox.BorderStyle = BorderStyle.FixedSingle;
        passwordBox.Font = new Font("Old English Text MT", 13F);
        passwordBox.ForeColor = Color.White;
        passwordBox.Location = new Point(200, 210);
        passwordBox.Name = "passwordBox";
        passwordBox.PasswordChar = '*';
        passwordBox.Size = new Size(410, 34);
        passwordBox.TabIndex = 1;
        // 
        // enterPassword
        // 
        enterPassword.Font = new Font("Old English Text MT", 13F);
        enterPassword.Location = new Point(200, 180);
        enterPassword.Name = "enterPassword";
        enterPassword.Size = new Size(148, 27);
        enterPassword.TabIndex = 0;
        enterPassword.Text = "Password";
        // 
        // CurrentUser
        // 
        CurrentUser.Font = new Font("Old English Text MT", 13F);
        CurrentUser.Location = new Point(200, 110);
        CurrentUser.Name = "CurrentUser";
        CurrentUser.Size = new Size(148, 27);
        CurrentUser.TabIndex = 0;
        CurrentUser.Text = "User name";
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
        EnterButton.FlatStyle = FlatStyle.Flat;
        EnterButton.Font = new Font("Old English Text MT", 12F);
        EnterButton.Location = new Point(250, 280);
        EnterButton.Name = "NewUser";
        EnterButton.Size = new Size(290, 40);
        EnterButton.TabIndex = 1;
        EnterButton.Text = "Enter";
        // 
        // NewAccButton
        // 
        NewAccButton.FlatStyle = FlatStyle.Flat;
        NewAccButton.Font = new Font("Old English Text MT", 12F);
        NewAccButton.Location = new Point(250, 340);
        NewAccButton.Name = "NewUser";
        NewAccButton.Size = new Size(140, 40);
        NewAccButton.TabIndex = 1;
        NewAccButton.Text = "New Acc";
        //
        // NewAccButton
        // 
        ExitButton.FlatStyle = FlatStyle.Flat;
        ExitButton.Font = new Font("Old English Text MT", 12F);
        ExitButton.Location = new Point(400, 340);
        ExitButton.Name = "NewUser";
        ExitButton.Size = new Size(140, 40);
        ExitButton.TabIndex = 1;
        ExitButton.Text = "Exit";

        MainPanel.Controls.Add(UserNameBox);
        MainPanel.Controls.Add(AppTitle);
        MainPanel.Controls.Add(passwordBox);
        MainPanel.Controls.Add(enterPassword);
        MainPanel.Controls.Add(CurrentUser);
        MainPanel.Controls.Add(EnterButton);
        MainPanel.Controls.Add(NewAccButton);
        MainPanel.Controls.Add(ExitButton);
    }
    public override void Close()
    {
        UserNameBox.Clear();
        passwordBox.Clear();
        base.Close();
    }
}