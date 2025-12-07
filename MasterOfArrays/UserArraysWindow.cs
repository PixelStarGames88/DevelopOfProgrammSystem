using System.Windows.Forms;

namespace MasterOfArrays;
public class UserArraysWindow : ChapterWindow
{
    private Label AppTitle;
    public TextBox LastNameBox {  get; private set; }
    private Button CancelButton;
    private Label ArraysLabel;
    private Button EnterButton;
    private Panel ArraysPanel;
    private Label EmptyLabel;
    private List<Button> ArrayChoiseButtons;
    public UserArraysWindow(Control parent) : base(parent)
    {
        InitializeComponent(parent);
    }
    private void InitializeComponent(Control parent)
    {
        ArraysPanel = new Panel();
        LastNameBox = new TextBox();
        CancelButton = new Button();
        ArraysLabel = new Label();
        EnterButton = new Button();
        AppTitle = new Label();
        EmptyLabel = new Label();
        ArrayChoiseButtons = new List<Button>();
        ArraysPanel.SuspendLayout();
        // 
        // ArraysPanel
        // 
        ArraysPanel.AutoScroll = true;
        ArraysPanel.Controls.Add(EmptyLabel);
        ArraysPanel.Location = new Point(30, 100);
        ArraysPanel.Name = "ArraysPanel";
        ArraysPanel.Size = new Size(700, 230);
        ArraysPanel.TabIndex = 0;
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
        // CancelButton
        // 
        CancelButton.FlatStyle = FlatStyle.Flat;
        CancelButton.Font = new Font("Old English Text MT", 12F);
        CancelButton.Location = new Point(488, 336);
        CancelButton.Name = "CancelButton";
        CancelButton.Size = new Size(112, 34);
        CancelButton.TabIndex = 12;
        CancelButton.Text = "Cancel";
        // 
        // ArraysLabel
        // 
        ArraysLabel.Anchor = AnchorStyles.Left;
        ArraysLabel.Font = new Font("Old English Text MT", 13F);
        ArraysLabel.Location = new Point(30, 66);
        ArraysLabel.Name = "ArraysLabel";
        ArraysLabel.Size = new Size(118, 31);
        ArraysLabel.TabIndex = 1;
        ArraysLabel.Text = "You arrays";
        // 
        // SaveButton
        // 
        EnterButton.FlatStyle = FlatStyle.Flat;
        EnterButton.Font = new Font("Old English Text MT", 12F);
        EnterButton.Location = new Point(618, 336);
        EnterButton.Name = "EnterButton";
        EnterButton.Size = new Size(112, 34);
        EnterButton.TabIndex = 15;
        EnterButton.Text = "Enter";
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
        // EmptyLabel
        // 
        EmptyLabel.Font = new Font("Old English Text MT", 13F);
        EmptyLabel.Location = new Point(320, 100);
        EmptyLabel.Name = "EmptyLabel";
        EmptyLabel.Size = new Size(90, 30);
        EmptyLabel.TabIndex = 16;
        EmptyLabel.Text = "Empty";
        EmptyLabel.TextAlign = ContentAlignment.MiddleCenter;
        

        MainPanel.Controls.Add(ArraysPanel);
        MainPanel.Controls.Add(EnterButton);
        MainPanel.Controls.Add(LastNameBox);
        MainPanel.Controls.Add(ArraysLabel);
        MainPanel.Controls.Add(CancelButton);
        MainPanel.Controls.Add(AppTitle);
        
        ArraysPanel.Controls.Add(EmptyLabel);
    }
    public void AddButtons(Dictionary<string, string> arrays)
    {
        if(arrays.Keys.Count == 0) EmptyLabel.Visible = true;
        else
        {
            int count = 0;
            EmptyLabel.Visible = false;
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
                ArraysPanel.Controls.Add(ArrayChoiseButton);
                ArrayChoiseButtons.Add(ArrayChoiseButton);
                count++;
            }
        }
    }
    public override void Close()
    {
        base.Close();
        ArrayChoiseButtons.Clear();
        LastNameBox.Clear();
    }
    public void EnterButton_Click(EventHandler outEvent)
    {
        EnterButton.Click += outEvent;
    }
    public void CancelButton_Click(EventHandler outEvent)
    {
        CancelButton.Click += outEvent;
    }
}