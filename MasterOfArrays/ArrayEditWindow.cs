namespace MasterOfArrays;

public class ArrayEditWindow : ChapterWindow
{
    private Button ClearArray;
    private Button FillRandomNumber;
    private Button ShowSourceArray;
    private Button ShowSortedArray;
    private Button DownloadArray;

    public ArrayEditWindow(Control parent) : base(parent)
    { }
    protected override void InitializeComponent()
    {
        ClearArray = new Button();
        FillRandomNumber = new Button();
        ShowSourceArray = new Button();
        ShowSortedArray = new Button();
        DownloadArray = new Button();
        // 
        // clearArray
        // 
        ClearArray.FlatStyle = FlatStyle.Flat;
        ClearArray.Font = new Font("Old English Text MT", 12F);
        ClearArray.ForeColor = Color.White;
        ClearArray.Location = new Point(632, 227);
        ClearArray.Name = "clearArray";
        ClearArray.Size = new Size(135, 86);
        ClearArray.TabIndex = 0;
        ClearArray.Text = "Clear";
        // 
        // FillRandomNumber
        // 
        FillRandomNumber.FlatStyle = FlatStyle.Flat;
        FillRandomNumber.Font = new Font("Old English Text MT", 12F);
        FillRandomNumber.ForeColor = Color.White;
        FillRandomNumber.Location = new Point(491, 43);
        FillRandomNumber.Name = "FillRandomNumber";
        FillRandomNumber.Size = new Size(135, 86);
        FillRandomNumber.TabIndex = 2;
        FillRandomNumber.Text = "Fill random numbers";
        // 
        // ShowSourceArray
        // 
        ShowSourceArray.FlatStyle = FlatStyle.Flat;
        ShowSourceArray.Font = new Font("Old English Text MT", 12F);
        ShowSourceArray.ForeColor = Color.White;
        ShowSourceArray.Location = new Point(632, 135);
        ShowSourceArray.Name = "ShowSourceArray";
        ShowSourceArray.Size = new Size(135, 86);
        ShowSourceArray.TabIndex = 3;
        ShowSourceArray.Text = "Show source array";
        // 
        // ShowSortedArray
        // 
        ShowSortedArray.FlatStyle = FlatStyle.Flat;
        ShowSortedArray.Font = new Font("Old English Text MT", 12F);
        ShowSortedArray.ForeColor = Color.White;
        ShowSortedArray.Location = new Point(632, 43);
        ShowSortedArray.Name = "ShowSortedArray";
        ShowSortedArray.Size = new Size(135, 86);
        ShowSortedArray.TabIndex = 4;
        ShowSortedArray.Text = "Show sorted array";
        // 
        // DownloadArray
        // 
        DownloadArray.FlatStyle = FlatStyle.Flat;
        DownloadArray.Font = new Font("Old English Text MT", 12F);
        DownloadArray.ForeColor = Color.White;
        DownloadArray.Location = new Point(491, 135);
        DownloadArray.Name = "DownloadArray";
        DownloadArray.Size = new Size(135, 86);
        DownloadArray.TabIndex = 5;
        DownloadArray.Text = "Download array";

        
        MainPanel.Controls.Add(DownloadArray);
        MainPanel.Controls.Add(ShowSortedArray);
        MainPanel.Controls.Add(ShowSourceArray);
        MainPanel.Controls.Add(FillRandomNumber);
        MainPanel.Controls.Add(ClearArray);
    }
    public void ClearArrayButton_Click(EventHandler outEvent)
    {
        ClearArray.Click += outEvent;
    }
    public void FillRandomNumberButton_Click(EventHandler outEvent)
    {
        FillRandomNumber.Click += outEvent;
    }
    public void ShowSourceArrayButton_Click(EventHandler outEvent)
    {
        ShowSourceArray.Click += outEvent;
    }
    public void ShowSortedArrayButton_Click(EventHandler outEvent)
    {
        ShowSortedArray.Click += outEvent;
    }
    public void DownloadArrayButton_Click(EventHandler outEvent)
    {
        DownloadArray.Click += outEvent;
    }
}
