namespace MasterOfArrays;

public class WorkDeskWindow : ChapterWindow
{
    public TextBox WorkField { get; set; }
    private MenuStrip menuStrip;

    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem newArrayToolStripMenuItem;
    private ToolStripMenuItem openArrayToolStripMenuItem;
    private ToolStripMenuItem saveArrayToolStripMenuItem;
    private ToolStripMenuItem saveArrayAsToolStripMenuItem;
    private ToolStripMenuItem deleteArrayToolStripMenuItem;
    private ToolStripMenuItem exitToolStripMenuItem;
    
    private ToolStripMenuItem userToolStripMenuItem;
    private ToolStripMenuItem editDataToolStripMenuItem;
    private ToolStripMenuItem exitFromAccToolStripMenuItem;
    
    private ToolStripMenuItem infoToolStripMenuItem;

    public WorkDeskWindow(Control parent) : base(parent)
    { }

    protected override void InitializeComponent()
    {
        menuStrip = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        newArrayToolStripMenuItem = new ToolStripMenuItem();
        openArrayToolStripMenuItem = new ToolStripMenuItem();
        saveArrayToolStripMenuItem = new ToolStripMenuItem();
        saveArrayAsToolStripMenuItem = new ToolStripMenuItem();
        deleteArrayToolStripMenuItem = new ToolStripMenuItem();

        exitToolStripMenuItem = new ToolStripMenuItem();
        userToolStripMenuItem = new ToolStripMenuItem();
        infoToolStripMenuItem = new ToolStripMenuItem();

        editDataToolStripMenuItem = new ToolStripMenuItem();
        exitFromAccToolStripMenuItem = new ToolStripMenuItem();

        WorkField = new TextBox();
        menuStrip.SuspendLayout();

        MainPanel.Location = new Point(0, 0);
        MainPanel.Name = "mainPanel";
        MainPanel.Size = new Size(800, 450);
        MainPanel.TabIndex = 0;

        // 
        // menuStrip
        // 
        menuStrip.BackColor = Color.Black;
        menuStrip.Font = new Font("Old English Text MT", 12F);
        menuStrip.ForeColor = Color.DarkRed;
        menuStrip.ImageScalingSize = new Size(20, 20);
        menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, userToolStripMenuItem, infoToolStripMenuItem });
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(800, 32);
        menuStrip.TabIndex = 0;
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.BackColor = Color.Black;
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newArrayToolStripMenuItem, openArrayToolStripMenuItem, saveArrayToolStripMenuItem, saveArrayAsToolStripMenuItem, deleteArrayToolStripMenuItem, exitToolStripMenuItem });
        fileToolStripMenuItem.ForeColor = Color.DarkRed;
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(58, 28);
        fileToolStripMenuItem.Text = "File";
        // 
        // userToolStripMenuItem
        // 
        userToolStripMenuItem.BackColor = Color.Black;
        userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editDataToolStripMenuItem, exitFromAccToolStripMenuItem });
        userToolStripMenuItem.ForeColor = Color.DarkRed;
        userToolStripMenuItem.Name = "userToolStripMenuItem";
        userToolStripMenuItem.Size = new Size(58, 28);
        userToolStripMenuItem.Text = "User";
        // 
        // newArrayToolStripMenuItem
        // 
        editDataToolStripMenuItem.Name = "newArrayToolStripMenuItem";
        editDataToolStripMenuItem.Size = new Size(225, 28);
        editDataToolStripMenuItem.Text = "Edit";
        // 
        // opToolStripMenuItem
        // 
        exitFromAccToolStripMenuItem.Name = "opToolStripMenuItem";
        exitFromAccToolStripMenuItem.Size = new Size(225, 28);
        exitFromAccToolStripMenuItem.Text = "Exit";
        // 
        // newArrayToolStripMenuItem
        // 
        newArrayToolStripMenuItem.Name = "newArrayToolStripMenuItem";
        newArrayToolStripMenuItem.Size = new Size(225, 28);
        newArrayToolStripMenuItem.Text = "New Array";

        deleteArrayToolStripMenuItem.Name = "deleteArrayToolStripMenuItem";
        deleteArrayToolStripMenuItem.Size = new Size(225, 28);
        deleteArrayToolStripMenuItem.Text = "Delete Array";
        // 
        // opToolStripMenuItem
        // 
        openArrayToolStripMenuItem.Name = "opToolStripMenuItem";
        openArrayToolStripMenuItem.Size = new Size(225, 28);
        openArrayToolStripMenuItem.Text = "Open Array";
        // 
        // saveArrayToolStripMenuItem
        // 
        saveArrayToolStripMenuItem.Name = "saveArrayToolStripMenuItem";
        saveArrayToolStripMenuItem.Size = new Size(225, 28);
        saveArrayToolStripMenuItem.Text = "Save Array";
        // 
        // saveArrayAsToolStripMenuItem
        // 
        saveArrayAsToolStripMenuItem.Name = "saveArrayAsToolStripMenuItem";
        saveArrayAsToolStripMenuItem.Size = new Size(225, 28);
        saveArrayAsToolStripMenuItem.Text = "Save Array as..";
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(225, 28);
        exitToolStripMenuItem.Text = "Exit";
        // 
        // infoToolStripMenuItem
        // 
        infoToolStripMenuItem.Name = "infoToolStripMenuItem";
        infoToolStripMenuItem.Size = new Size(60, 28);
        infoToolStripMenuItem.Text = "Info";
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

        MainPanel.Controls.Add(menuStrip);
        MainPanel.Controls.Add(WorkField);
    }
    public void ChangeName(string name)
    {
        userToolStripMenuItem.Text = name;
    }
    public void showInfoToolStripMenuItep_Click(EventHandler outEvent)
    {
        infoToolStripMenuItem.Click += outEvent;
    }
    public void exitFromAccToolStripMenuItep_Click(EventHandler outEvent)
    {
        exitFromAccToolStripMenuItem.Click += outEvent;
    }
    public void exitFromProgrammToolStripMenuItep_Click(EventHandler outEvent)
    {
        exitToolStripMenuItem.Click += outEvent;
    }
    public void editDataToolStripMenuItem_Click(EventHandler outEvent)
    {
        editDataToolStripMenuItem.Click += outEvent;
    }
    public void newArrayToolStripMenuItem_Click(EventHandler outEvent)
    {
        newArrayToolStripMenuItem.Click += outEvent;
    }
    public void openToolStripMenuItem_Click(EventHandler outEvent)
    {
        openArrayToolStripMenuItem.Click += outEvent;
    }
    public void saveArrayToolStripMenuItem_Click(EventHandler outEvent)
    {
        saveArrayToolStripMenuItem.Click += outEvent;
    }
    public void saveArrayAsToolStripMenuItem_Click(EventHandler outEvent)
    {
        saveArrayAsToolStripMenuItem.Click += outEvent;
    }
    public void deleteArrayToolStripMenuItem_Click( EventHandler outEvent)
    {
        deleteArrayToolStripMenuItem.Click += outEvent;
    }
}