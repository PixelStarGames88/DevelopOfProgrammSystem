namespace MasterOfArrays;

public class RandNumWindow : ChapterWindow
{
    public TextBox firstLimitBox { get; private set; }
    public TextBox lastLimitBox { get; private set; }
    public TextBox Quantity { get; private set; }
    private Label firstLimitLabel;
    private Label lastLimitLabel;
    private Label quantityLabel;
    private Button enterButton;
    private Button exitButton;
    public RandNumWindow(Control parent) : base(parent)
    {  }
    protected override void InitializeComponent()
    {
        firstLimitBox = new TextBox();
        lastLimitBox = new TextBox();
        Quantity = new TextBox();
        firstLimitLabel = new Label();
        lastLimitLabel = new Label();
        quantityLabel = new Label();
        enterButton = new Button();
        exitButton = new Button();
        // 
        // limitsPanel
        // 
        MainPanel.Controls.Add(exitButton);
        MainPanel.Controls.Add(firstLimitBox);
        MainPanel.Controls.Add(lastLimitBox);
        MainPanel.Controls.Add(Quantity);
        MainPanel.Controls.Add(firstLimitLabel);
        MainPanel.Controls.Add(lastLimitLabel);
        MainPanel.Controls.Add(quantityLabel);
        MainPanel.Controls.Add(enterButton);
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
        // firstLimitLabel
        // 
        firstLimitLabel.Font = new Font("Old English Text MT", 13F);
        firstLimitLabel.Location = new Point(25, 19);
        firstLimitLabel.Name = "firstLimitLabel";
        firstLimitLabel.Size = new Size(148, 27);
        firstLimitLabel.TabIndex = 0;
        firstLimitLabel.Text = "First Limit";
        // 
        // lastLimitLabel
        // 
        lastLimitLabel.Font = new Font("Old English Text MT", 13F);
        lastLimitLabel.Location = new Point(25, 86);
        lastLimitLabel.Name = "lastLimitLabel";
        lastLimitLabel.Size = new Size(148, 27);
        lastLimitLabel.TabIndex = 0;
        lastLimitLabel.Text = "Last Limit";
        // 
        // quantityLabel
        // 
        quantityLabel.Font = new Font("Old English Text MT", 13F);
        quantityLabel.Location = new Point(25, 151);
        quantityLabel.Name = "quantityLabel";
        quantityLabel.Size = new Size(148, 27);
        quantityLabel.TabIndex = 0;
        quantityLabel.Text = "Quantity";
        // 
        // enterButton
        // 
        enterButton.FlatStyle = FlatStyle.Flat;
        enterButton.Font = new Font("Old English Text MT", 12F);
        enterButton.ForeColor = Color.DarkRed;
        enterButton.Location = new Point(25, 245);
        enterButton.Name = "enterButton";
        enterButton.Size = new Size(73, 40);
        enterButton.TabIndex = 0;
        enterButton.Text = "Enter";
        // 
        // exitButton
        // 
        exitButton.FlatStyle = FlatStyle.Flat;
        exitButton.Font = new Font("Old English Text MT", 12F);
        exitButton.ForeColor = Color.DarkRed;
        exitButton.Location = new Point(151, 245);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(73, 40);
        exitButton.TabIndex = 3;
        exitButton.Text = "Exit";
    }
    private void ClearText()
    {
        Quantity.Clear();
        firstLimitBox.Clear();
        lastLimitBox.Clear();
    }
    public void EnterButton_Click(EventHandler outEvent)
    {
        enterButton.Click += outEvent;
    }
    public void ExitButton_Click(EventHandler outEvent)
    {
        exitButton.Click += outEvent;
    }
    public override void Close()
    {
        ClearText();
        base.Close();
    }
}