namespace MasterOfArrays;

public class AccCreatingWindow : ChapterWindow
{
    public TextBox FirstNameBox { get; private set; }
    private Label FirstNameLabel;
    private Button ExitButton;
    private Button FinishButton;
    private Label RepeatPasswordLabel;
    public TextBox RepeatPasswordBox { get; private set; }
    private Label PasswordLabel;
    public TextBox PasswordBox { get; private set; }
    private Label LoginLabel;
    public TextBox LoginNameBox { get; private set; }
    private Label LastNameLabel;
    public TextBox LastNameBox { get; private set; }
    private Label AccCreatingLabel;
    private Label AppTitle;
    public AccCreatingWindow(Control parent) : base(parent)
    { }
    protected override void InitializeComponent()
    {
        AppTitle = new Label();
        AccCreatingLabel = new Label();
        RepeatPasswordLabel = new Label();
        RepeatPasswordBox = new TextBox();
        PasswordLabel = new Label();
        PasswordBox = new TextBox();
        LoginLabel = new Label();
        LoginNameBox = new TextBox();
        LastNameLabel = new Label();
        LastNameBox = new TextBox();
        FinishButton = new Button();
        FirstNameLabel = new Label();
        ExitButton = new Button();
        FirstNameBox = new TextBox();
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
        // mainPanel
        // 
        MainPanel.Controls.Add(AccCreatingLabel);
        MainPanel.Controls.Add(RepeatPasswordLabel);
        MainPanel.Controls.Add(RepeatPasswordBox);
        MainPanel.Controls.Add(PasswordLabel);
        MainPanel.Controls.Add(PasswordBox);
        MainPanel.Controls.Add(LoginLabel);
        MainPanel.Controls.Add(LoginNameBox);
        MainPanel.Controls.Add(LastNameLabel);
        MainPanel.Controls.Add(LastNameBox);
        MainPanel.Controls.Add(FinishButton);
        MainPanel.Controls.Add(FirstNameLabel);
        MainPanel.Controls.Add(ExitButton);
        MainPanel.Controls.Add(FirstNameBox);
        MainPanel.Controls.Add(AppTitle);
        // 
        // AccCreatingLabel
        // 
        AccCreatingLabel.Font = new Font("Old English Text MT", 20F);
        AccCreatingLabel.Location = new Point(54, 81);
        AccCreatingLabel.Name = "AccCreatingLabel";
        AccCreatingLabel.Size = new Size(249, 42);
        AccCreatingLabel.TabIndex = 21;
        AccCreatingLabel.Text = "Acc Creating";
        // 
        // RepeatPasswordLabel
        // 
        RepeatPasswordLabel.Font = new Font("Old English Text MT", 13F);
        RepeatPasswordLabel.Location = new Point(428, 207);
        RepeatPasswordLabel.Name = "RepeatPasswordLabel";
        RepeatPasswordLabel.Size = new Size(178, 23);
        RepeatPasswordLabel.TabIndex = 19;
        RepeatPasswordLabel.Text = "Repeat Password";
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
        // PasswordLabel
        // 
        PasswordLabel.Font = new Font("Old English Text MT", 13F);
        PasswordLabel.Location = new Point(428, 144);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(100, 23);
        PasswordLabel.TabIndex = 17;
        PasswordLabel.Text = "Password";
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
        // LoginLabel
        // 
        LoginLabel.Font = new Font("Old English Text MT", 13F);
        LoginLabel.Location = new Point(428, 81);
        LoginLabel.Name = "LoginLabel";
        LoginLabel.Size = new Size(100, 23);
        LoginLabel.TabIndex = 15;
        LoginLabel.Text = "Login";
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
        // LastNameLabel
        // 
        LastNameLabel.Font = new Font("Old English Text MT", 13F);
        LastNameLabel.Location = new Point(54, 207);
        LastNameLabel.Name = "LastNameLabel";
        LastNameLabel.Size = new Size(116, 23);
        LastNameLabel.TabIndex = 13;
        LastNameLabel.Text = "Last Name";
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
        // FinishButton
        // 
        FinishButton.FlatStyle = FlatStyle.Flat;
        FinishButton.Font = new Font("Old English Text MT", 12F);
        FinishButton.Location = new Point(428, 301);
        FinishButton.Name = "FinishButton";
        FinishButton.Size = new Size(112, 47);
        FinishButton.TabIndex = 12;
        FinishButton.Text = "Finish";
        // 
        // FirstNameLabel
        // 
        FirstNameLabel.Font = new Font("Old English Text MT", 13F);
        FirstNameLabel.Location = new Point(54, 144);
        FirstNameLabel.Name = "FirstNameLabel";
        FirstNameLabel.Size = new Size(130, 23);
        FirstNameLabel.TabIndex = 1;
        FirstNameLabel.Text = "First Name";
        // 
        // ExitButton
        // 
        ExitButton.FlatStyle = FlatStyle.Flat;
        ExitButton.Font = new Font("Old English Text MT", 12F);
        ExitButton.Location = new Point(613, 301);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new Size(112, 47);
        ExitButton.TabIndex = 3;
        ExitButton.Text = "Exit";
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
        ExitButton.Click += outEvent;
    }
    public void FinishButton_Click(EventHandler outEvent)
    {
        FinishButton.Click += outEvent;
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