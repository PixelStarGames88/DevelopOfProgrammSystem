namespace MasterOfArrays;

public class WindowRandNum : WindowChapter
{
    public TextBox firstLimitBox { get; private set; } = null!;
    public TextBox lastLimitBox { get; private set; } = null!;
    public TextBox Quantity { get; private set; } = null!;
    private Label _firstLimitLabel = null!;
    private Label _lastLimitLabel = null!;
    private Label _quantityLabel = null!;
    private Button _enterButton = null!;
    private Button _exitButton = null!;
    public WindowRandNum(Control parent) : base(parent)
    {  }
    protected override void InitializeComponent()
    {
        firstLimitBox = new TextBox();
        lastLimitBox = new TextBox();
        Quantity = new TextBox();
        _firstLimitLabel = new Label();
        _lastLimitLabel = new Label();
        _quantityLabel = new Label();
        _enterButton = new Button();
        _exitButton = new Button();
        // 
        // limitsPanel
        // 
        MainPanel.Controls.Add(_exitButton);
        MainPanel.Controls.Add(firstLimitBox);
        MainPanel.Controls.Add(lastLimitBox);
        MainPanel.Controls.Add(Quantity);
        MainPanel.Controls.Add(_firstLimitLabel);
        MainPanel.Controls.Add(_lastLimitLabel);
        MainPanel.Controls.Add(_quantityLabel);
        MainPanel.Controls.Add(_enterButton);
        MainPanel.Location = new Point(491, 43);
        MainPanel.Name = "limitsPanel";
        MainPanel.Size = new Size(276, 313);
        MainPanel.TabIndex = 0;
        // 
        // firstLimitBox
        // 
        firstLimitBox.BackColor = Color.Black;
        firstLimitBox.BorderStyle = BorderStyle.FixedSingle;
        firstLimitBox.Font = new Font("Old English Text MT", 13F);
        firstLimitBox.ForeColor = Color.White;
        firstLimitBox.Location = new Point(25, 49);
        firstLimitBox.Name = "firstLimitBox";
        firstLimitBox.Size = new Size(199, 34);
        firstLimitBox.TabIndex = 0;
        // 
        // lastLimitBox
        // 
        lastLimitBox.BackColor = Color.Black;
        lastLimitBox.BorderStyle = BorderStyle.FixedSingle;
        lastLimitBox.Font = new Font("Old English Text MT", 13F);
        lastLimitBox.ForeColor = Color.White;
        lastLimitBox.Location = new Point(25, 116);
        lastLimitBox.Name = "lastLimitBox";
        lastLimitBox.Size = new Size(199, 34);
        lastLimitBox.TabIndex = 1;
        // 
        // Quantity
        // 
        Quantity.BackColor = Color.Black;
        Quantity.BorderStyle = BorderStyle.FixedSingle;
        Quantity.Font = new Font("Old English Text MT", 13F);
        Quantity.ForeColor = Color.White;
        Quantity.Location = new Point(25, 181);
        Quantity.Name = "Quantity";
        Quantity.Size = new Size(199, 34);
        Quantity.TabIndex = 2;
        // 
        // _firstLimitLabel
        // 
        _firstLimitLabel.Font = new Font("Old English Text MT", 13F);
        _firstLimitLabel.Location = new Point(25, 19);
        _firstLimitLabel.Name = "firstLimitLabel";
        _firstLimitLabel.Size = new Size(148, 27);
        _firstLimitLabel.TabIndex = 0;
        _firstLimitLabel.Text = "First Limit";
        // 
        // _lastLimitLabel
        // 
        _lastLimitLabel.Font = new Font("Old English Text MT", 13F);
        _lastLimitLabel.Location = new Point(25, 86);
        _lastLimitLabel.Name = "lastLimitLabel";
        _lastLimitLabel.Size = new Size(148, 27);
        _lastLimitLabel.TabIndex = 0;
        _lastLimitLabel.Text = "Last Limit";
        // 
        // _quantityLabel
        // 
        _quantityLabel.Font = new Font("Old English Text MT", 13F);
        _quantityLabel.Location = new Point(25, 151);
        _quantityLabel.Name = "quantityLabel";
        _quantityLabel.Size = new Size(148, 27);
        _quantityLabel.TabIndex = 0;
        _quantityLabel.Text = "Quantity";
        // 
        // _enterButton
        // 
        _enterButton.FlatStyle = FlatStyle.Flat;
        _enterButton.Font = new Font("Old English Text MT", 12F);
        _enterButton.ForeColor = Color.DarkRed;
        _enterButton.Location = new Point(25, 245);
        _enterButton.Name = "enterButton";
        _enterButton.Size = new Size(73, 40);
        _enterButton.TabIndex = 0;
        _enterButton.Text = "Enter";
        // 
        // _exitButton
        // 
        _exitButton.FlatStyle = FlatStyle.Flat;
        _exitButton.Font = new Font("Old English Text MT", 12F);
        _exitButton.ForeColor = Color.DarkRed;
        _exitButton.Location = new Point(151, 245);
        _exitButton.Name = "exitButton";
        _exitButton.Size = new Size(73, 40);
        _exitButton.TabIndex = 3;
        _exitButton.Text = "Exit";
    }
    private void ClearText()
    {
        Quantity.Clear();
        firstLimitBox.Clear();
        lastLimitBox.Clear();
    }
    public void EnterButton_Click(EventHandler outEvent)
    {
        _enterButton.Click += outEvent;
    }
    public void ExitButton_Click(EventHandler outEvent)
    {
        _exitButton.Click += outEvent;
    }
    public override void Close()
    {
        ClearText();
        base.Close();
    }
}