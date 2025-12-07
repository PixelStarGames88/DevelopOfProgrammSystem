namespace MasterOfArrays;

public class WindowArrayEdit : WindowChapter
{
    private Button _clearArray = null!;
    private Button _fillRandomNumber = null!;
    private Button _showSourceArray = null!;
    private Button _showSortedArray = null!;
    private Button _downloadArray = null!;

    public WindowArrayEdit(Control parent) : base(parent)
    { }
    protected override void InitializeComponent()
    {
        _clearArray = new Button();
        _fillRandomNumber = new Button();
        _showSourceArray = new Button();
        _showSortedArray = new Button();
        _downloadArray = new Button();
        // 
        // clearArray
        // 
        _clearArray.FlatStyle = FlatStyle.Flat;
        _clearArray.Font = new Font("Old English Text MT", 12F);
        _clearArray.ForeColor = Color.White;
        _clearArray.Location = new Point(632, 227);
        _clearArray.Name = "clearArray";
        _clearArray.Size = new Size(135, 86);
        _clearArray.TabIndex = 0;
        _clearArray.Text = "Clear";
        // 
        // _fillRandomNumber
        // 
        _fillRandomNumber.FlatStyle = FlatStyle.Flat;
        _fillRandomNumber.Font = new Font("Old English Text MT", 12F);
        _fillRandomNumber.ForeColor = Color.White;
        _fillRandomNumber.Location = new Point(491, 43);
        _fillRandomNumber.Name = "FillRandomNumber";
        _fillRandomNumber.Size = new Size(135, 86);
        _fillRandomNumber.TabIndex = 2;
        _fillRandomNumber.Text = "Fill random numbers";
        // 
        // _showSourceArray
        // 
        _showSourceArray.FlatStyle = FlatStyle.Flat;
        _showSourceArray.Font = new Font("Old English Text MT", 12F);
        _showSourceArray.ForeColor = Color.White;
        _showSourceArray.Location = new Point(632, 135);
        _showSourceArray.Name = "ShowSourceArray";
        _showSourceArray.Size = new Size(135, 86);
        _showSourceArray.TabIndex = 3;
        _showSourceArray.Text = "Show source array";
        // 
        // _showSortedArray
        // 
        _showSortedArray.FlatStyle = FlatStyle.Flat;
        _showSortedArray.Font = new Font("Old English Text MT", 12F);
        _showSortedArray.ForeColor = Color.White;
        _showSortedArray.Location = new Point(632, 43);
        _showSortedArray.Name = "ShowSortedArray";
        _showSortedArray.Size = new Size(135, 86);
        _showSortedArray.TabIndex = 4;
        _showSortedArray.Text = "Show sorted array";
        // 
        // _downloadArray
        // 
        _downloadArray.FlatStyle = FlatStyle.Flat;
        _downloadArray.Font = new Font("Old English Text MT", 12F);
        _downloadArray.ForeColor = Color.White;
        _downloadArray.Location = new Point(491, 135);
        _downloadArray.Name = "DownloadArray";
        _downloadArray.Size = new Size(135, 86);
        _downloadArray.TabIndex = 5;
        _downloadArray.Text = "Download array";

        
        MainPanel.Controls.Add(_downloadArray);
        MainPanel.Controls.Add(_showSortedArray);
        MainPanel.Controls.Add(_showSourceArray);
        MainPanel.Controls.Add(_fillRandomNumber);
        MainPanel.Controls.Add(_clearArray);
    }
    public void ClearArrayButton_Click(EventHandler outEvent)
    {
        _clearArray.Click += outEvent;
    }
    public void FillRandomNumberButton_Click(EventHandler outEvent)
    {
        _fillRandomNumber.Click += outEvent;
    }
    public void ShowSourceArrayButton_Click(EventHandler outEvent)
    {
        _showSourceArray.Click += outEvent;
    }
    public void ShowSortedArrayButton_Click(EventHandler outEvent)
    {
        _showSortedArray.Click += outEvent;
    }
    public void DownloadArrayButton_Click(EventHandler outEvent)
    {
        _downloadArray.Click += outEvent;
    }
}
