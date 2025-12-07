using System.Windows.Forms;

namespace MasterOfArrays;
public class WindowUserArrays : WindowChapter
{
    private Label _appTitle = null!;
    public TextBox LastNameBox {  get; private set; } = null!;
    private Button _cancelButton = null!;
    private Label _arraysLabel = null!;
    private Button _enterButton = null!;
    private Panel _arraysPanel = null!;
    private Label _emptyLabel = null!;
    private List<Button> _arrayChoiseButtons = null!;
    public WindowUserArrays(Control parent) : base(parent)
    {
        InitializeComponent(parent);
    }
    private void InitializeComponent(Control parent)
    {
        _arraysPanel = new Panel();
        LastNameBox = new TextBox();
        _cancelButton = new Button();
        _arraysLabel = new Label();
        _enterButton = new Button();
        _appTitle = new Label();
        _emptyLabel = new Label();
        _arrayChoiseButtons = new List<Button>();
        _arraysPanel.SuspendLayout();
        // 
        // _arraysPanel
        // 
        _arraysPanel.AutoScroll = true;
        _arraysPanel.Controls.Add(_emptyLabel);
        _arraysPanel.Location = new Point(30, 100);
        _arraysPanel.Name = "ArraysPanel";
        _arraysPanel.Size = new Size(700, 230);
        _arraysPanel.TabIndex = 0;
        // 
        // LastNameBox
        // 
        LastNameBox.BackColor = Color.Black;
        LastNameBox.BorderStyle = BorderStyle.FixedSingle;
        LastNameBox.Font = new Font("Old English Text MT", 13F);
        LastNameBox.ForeColor = Color.White;
        LastNameBox.Location = new Point(30, 336);
        LastNameBox.Name = "LastNameBox";
        LastNameBox.Size = new Size(432, 34);
        LastNameBox.TabIndex = 14;
        // 
        // _cancelButton
        // 
        _cancelButton.FlatStyle = FlatStyle.Flat;
        _cancelButton.Font = new Font("Old English Text MT", 12F);
        _cancelButton.Location = new Point(488, 336);
        _cancelButton.Name = "CancelButton";
        _cancelButton.Size = new Size(112, 34);
        _cancelButton.TabIndex = 12;
        _cancelButton.Text = "Cancel";
        // 
        // _arraysLabel
        // 
        _arraysLabel.Anchor = AnchorStyles.Left;
        _arraysLabel.Font = new Font("Old English Text MT", 13F);
        _arraysLabel.Location = new Point(30, 66);
        _arraysLabel.Name = "ArraysLabel";
        _arraysLabel.Size = new Size(118, 31);
        _arraysLabel.TabIndex = 1;
        _arraysLabel.Text = "You arrays";
        // 
        // SaveButton
        // 
        _enterButton.FlatStyle = FlatStyle.Flat;
        _enterButton.Font = new Font("Old English Text MT", 12F);
        _enterButton.Location = new Point(618, 336);
        _enterButton.Name = "EnterButton";
        _enterButton.Size = new Size(112, 34);
        _enterButton.TabIndex = 15;
        _enterButton.Text = "Enter";
        // 
        // _appTitle
        // 
        _appTitle.Font = new Font("Old English Text MT", 24F);
        _appTitle.Location = new Point(240, 9);
        _appTitle.Name = "AppTitle";
        _appTitle.Size = new Size(317, 52);
        _appTitle.TabIndex = 0;
        _appTitle.Text = "Master of Arrays";
        // 
        // _emptyLabel
        // 
        _emptyLabel.Font = new Font("Old English Text MT", 13F);
        _emptyLabel.Location = new Point(320, 100);
        _emptyLabel.Name = "EmptyLabel";
        _emptyLabel.Size = new Size(90, 30);
        _emptyLabel.TabIndex = 16;
        _emptyLabel.Text = "Empty";
        _emptyLabel.TextAlign = ContentAlignment.MiddleCenter;
        

        MainPanel.Controls.Add(_arraysPanel);
        MainPanel.Controls.Add(_enterButton);
        MainPanel.Controls.Add(LastNameBox);
        MainPanel.Controls.Add(_arraysLabel);
        MainPanel.Controls.Add(_cancelButton);
        MainPanel.Controls.Add(_appTitle);
        
        _arraysPanel.Controls.Add(_emptyLabel);
    }
    public void AddButtons(Dictionary<string, string> arrays)
    {
        if(arrays.Keys.Count == 0) _emptyLabel.Visible = true;
        else
        {
            int count = 0;
            _emptyLabel.Visible = false;
            foreach (string ArrayName in arrays.Keys)
            {
                Button ArrayChoiseButton = new Button();
                ArrayChoiseButton.Anchor = AnchorStyles.Left;
                ArrayChoiseButton.FlatStyle = FlatStyle.Popup;
                ArrayChoiseButton.Font = new Font("Old English Text MT", 12F);
                ArrayChoiseButton.ForeColor = Color.DarkRed;
                ArrayChoiseButton.ImageAlign = ContentAlignment.MiddleLeft;
                ArrayChoiseButton.Location = new Point(3, 3 + 34 * (count));
                ArrayChoiseButton.Name = "ArrayChoiseButton";
                ArrayChoiseButton.Size = new Size(694, 34);
                ArrayChoiseButton.TabIndex = 16;
                ArrayChoiseButton.Text = ArrayName;
                ArrayChoiseButton.TextAlign = ContentAlignment.TopLeft;
                ArrayChoiseButton.Click += (o, e) => LastNameBox.Text = ArrayChoiseButton.Text;
                _arraysPanel.Controls.Add(ArrayChoiseButton);
                _arrayChoiseButtons.Add(ArrayChoiseButton);
                count++;
            }
        }
    }
    public override void Close()
    {
        base.Close();
        _arrayChoiseButtons.Clear();
        LastNameBox.Clear();
    }
    public void EnterButton_Click(EventHandler outEvent)
    {
        _enterButton.Click += outEvent;
    }
    public void CancelButton_Click(EventHandler outEvent)
    {
        _cancelButton.Click += outEvent;
    }
}