namespace MasterOfArrays;

public class ChapterWindow
{
    public Panel MainPanel { get; protected set; }

    public ChapterWindow(Control parent)
    {
        MainPanel = new Panel();
        MainPanel.TabIndex = 0;
        MainPanel.ForeColor = Color.White;
        MainPanel.Location = new Point(0, 0);
        MainPanel.Size = new Size(800, 450);
        InitializeComponent();
        parent.Controls.Add(MainPanel);
    }
    protected virtual void InitializeComponent()
    {
        
    }
    public virtual void Close()
    {
        MainPanel.Visible = false;
    }
    public virtual void Open()
    {
        MainPanel.Visible = true;
    }
}
