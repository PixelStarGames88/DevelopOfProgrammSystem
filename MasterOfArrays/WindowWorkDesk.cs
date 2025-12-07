namespace MasterOfArrays;

public class WindowWorkDesk : WindowChapter
{
    public TextBox WorkField { get; set; } = null!;
    private MenuStrip _menuStrip = null!;
    private ToolStripMenuItem _fileToolStripMenuItem = null!;
    private ToolStripMenuItem _newArrayToolStripMenuItem = null!;
    private ToolStripMenuItem _openArrayToolStripMenuItem = null!;
    private ToolStripMenuItem _saveArrayToolStripMenuItem = null!;
    private ToolStripMenuItem _saveArrayAsToolStripMenuItem = null!;
    private ToolStripMenuItem _deleteArrayToolStripMenuItem = null!;
    private ToolStripMenuItem _exitToolStripMenuItem = null!;
    private ToolStripMenuItem _userToolStripMenuItem = null!;
    private ToolStripMenuItem _editDataToolStripMenuItem = null!;
    private ToolStripMenuItem _exitFromAccToolStripMenuItem = null!;
    private ToolStripMenuItem _infoToolStripMenuItem = null!;

    public WindowWorkDesk(Control parent) : base(parent)
    { }

    protected override void InitializeComponent()
    {
        _menuStrip = new MenuStrip();
        _fileToolStripMenuItem = new ToolStripMenuItem();
        _newArrayToolStripMenuItem = new ToolStripMenuItem();
        _openArrayToolStripMenuItem = new ToolStripMenuItem();
        _saveArrayToolStripMenuItem = new ToolStripMenuItem();
        _saveArrayAsToolStripMenuItem = new ToolStripMenuItem();
        _deleteArrayToolStripMenuItem = new ToolStripMenuItem();

        _exitToolStripMenuItem = new ToolStripMenuItem();
        _userToolStripMenuItem = new ToolStripMenuItem();
        _infoToolStripMenuItem = new ToolStripMenuItem();

        _editDataToolStripMenuItem = new ToolStripMenuItem();
        _exitFromAccToolStripMenuItem = new ToolStripMenuItem();

        WorkField = new TextBox();
        _menuStrip.SuspendLayout();

        MainPanel.Location = new Point(0, 0);
        MainPanel.Name = "mainPanel";
        MainPanel.Size = new Size(800, 450);
        MainPanel.TabIndex = 0;

        // 
        // _menuStrip
        // 
        _menuStrip.BackColor = Color.Black;
        _menuStrip.Font = new Font("Old English Text MT", 12F);
        _menuStrip.ForeColor = Color.DarkRed;
        _menuStrip.ImageScalingSize = new Size(20, 20);
        _menuStrip.Items.AddRange(new ToolStripItem[] { _fileToolStripMenuItem, _userToolStripMenuItem, _infoToolStripMenuItem });
        _menuStrip.Location = new Point(0, 0);
        _menuStrip.Name = "menuStrip";
        _menuStrip.Size = new Size(800, 32);
        _menuStrip.TabIndex = 0;
        _menuStrip.ResumeLayout(false);
        _menuStrip.PerformLayout();
        // 
        // _fileToolStripMenuItem
        // 
        _fileToolStripMenuItem.BackColor = Color.Black;
        _fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _newArrayToolStripMenuItem, _openArrayToolStripMenuItem, _saveArrayToolStripMenuItem, _saveArrayAsToolStripMenuItem, _deleteArrayToolStripMenuItem, _exitToolStripMenuItem });
        _fileToolStripMenuItem.ForeColor = Color.DarkRed;
        _fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        _fileToolStripMenuItem.Size = new Size(58, 28);
        _fileToolStripMenuItem.Text = "File";
        // 
        // _userToolStripMenuItem
        // 
        _userToolStripMenuItem.BackColor = Color.Black;
        _userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _editDataToolStripMenuItem, _exitFromAccToolStripMenuItem });
        _userToolStripMenuItem.ForeColor = Color.DarkRed;
        _userToolStripMenuItem.Name = "userToolStripMenuItem";
        _userToolStripMenuItem.Size = new Size(58, 28);
        _userToolStripMenuItem.Text = "User";
        // 
        // _newArrayToolStripMenuItem
        // 
        _editDataToolStripMenuItem.Name = "newArrayToolStripMenuItem";
        _editDataToolStripMenuItem.Size = new Size(225, 28);
        _editDataToolStripMenuItem.Text = "Edit";
        // 
        // opToolStripMenuItem
        // 
        _exitFromAccToolStripMenuItem.Name = "opToolStripMenuItem";
        _exitFromAccToolStripMenuItem.Size = new Size(225, 28);
        _exitFromAccToolStripMenuItem.Text = "Exit";
        // 
        // _newArrayToolStripMenuItem
        // 
        _newArrayToolStripMenuItem.Name = "newArrayToolStripMenuItem";
        _newArrayToolStripMenuItem.Size = new Size(225, 28);
        _newArrayToolStripMenuItem.Text = "New Array";

        _deleteArrayToolStripMenuItem.Name = "deleteArrayToolStripMenuItem";
        _deleteArrayToolStripMenuItem.Size = new Size(225, 28);
        _deleteArrayToolStripMenuItem.Text = "Delete Array";
        // 
        // opToolStripMenuItem
        // 
        _openArrayToolStripMenuItem.Name = "opToolStripMenuItem";
        _openArrayToolStripMenuItem.Size = new Size(225, 28);
        _openArrayToolStripMenuItem.Text = "Open Array";
        // 
        // _saveArrayToolStripMenuItem
        // 
        _saveArrayToolStripMenuItem.Name = "saveArrayToolStripMenuItem";
        _saveArrayToolStripMenuItem.Size = new Size(225, 28);
        _saveArrayToolStripMenuItem.Text = "Save Array";
        // 
        // _saveArrayAsToolStripMenuItem
        // 
        _saveArrayAsToolStripMenuItem.Name = "saveArrayAsToolStripMenuItem";
        _saveArrayAsToolStripMenuItem.Size = new Size(225, 28);
        _saveArrayAsToolStripMenuItem.Text = "Save Array as..";
        // 
        // _exitToolStripMenuItem
        // 
        _exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        _exitToolStripMenuItem.Size = new Size(225, 28);
        _exitToolStripMenuItem.Text = "Exit";
        // 
        // _infoToolStripMenuItem
        // 
        _infoToolStripMenuItem.Name = "infoToolStripMenuItem";
        _infoToolStripMenuItem.Size = new Size(60, 28);
        _infoToolStripMenuItem.Text = "Info";
        // 
        // WorkField
        // 
        WorkField.BackColor = Color.Black;
        WorkField.BorderStyle = BorderStyle.FixedSingle;
        WorkField.Font = new Font("Old English Text MT", 12F);
        WorkField.ForeColor = Color.DarkRed;
        WorkField.Location = new Point(5, 43);
        WorkField.Multiline = true;
        WorkField.Name = "WorkField";
        WorkField.Size = new Size(470, 300);
        WorkField.TabIndex = 1;

        MainPanel.Controls.Add(_menuStrip);
        MainPanel.Controls.Add(WorkField);
    }
    public void ChangeName(string name)
    {
        _userToolStripMenuItem.Text = name;
    }
    public void showInfoToolStripMenuItep_Click(EventHandler outEvent)
    {
        _infoToolStripMenuItem.Click += outEvent;
    }
    public void exitFromAccToolStripMenuItep_Click(EventHandler outEvent)
    {
        _exitFromAccToolStripMenuItem.Click += outEvent;
    }
    public void exitFromProgrammToolStripMenuItep_Click(EventHandler outEvent)
    {
        _exitToolStripMenuItem.Click += outEvent;
    }
    public void editDataToolStripMenuItem_Click(EventHandler outEvent)
    {
        _editDataToolStripMenuItem.Click += outEvent;
    }
    public void newArrayToolStripMenuItem_Click(EventHandler outEvent)
    {
        _newArrayToolStripMenuItem.Click += outEvent;
    }
    public void openToolStripMenuItem_Click(EventHandler outEvent)
    {
        _openArrayToolStripMenuItem.Click += outEvent;
    }
    public void saveArrayToolStripMenuItem_Click(EventHandler outEvent)
    {
        _saveArrayToolStripMenuItem.Click += outEvent;
    }
    public void saveArrayAsToolStripMenuItem_Click(EventHandler outEvent)
    {
        _saveArrayAsToolStripMenuItem.Click += outEvent;
    }
    public void deleteArrayToolStripMenuItem_Click( EventHandler outEvent)
    {
        _deleteArrayToolStripMenuItem.Click += outEvent;
    }
}