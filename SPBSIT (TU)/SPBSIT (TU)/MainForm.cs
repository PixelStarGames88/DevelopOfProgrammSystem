namespace SPBSIT__TU_;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        _arrayObject = new();
    }
    private Button _clearArray = null!;
    private Button _fillRandomNumber = null!;
    private Button _showSourceArray = null!;
    private Button _showSortedArray = null!;
    private TextBox _firstLimitBox = null!;
    private TextBox _lastLimitBox = null!;
    private TextBox _quantityTextBox = null!;
    private Label _firstLimitLabel = null!;
    private Label _lastLimitLabel = null!;
    private Label _quantityLabel = null!;
    private Button _enterButton = null!;
    private Button _exitButton = null!;
    private TextBox _workFieldTextBox = null!;
    private MenuStrip _menuStrip = null!;
    private ToolStripMenuItem _fileToolStripMenuItem = null!;
    private ToolStripMenuItem _openArrayToolStripMenuItem = null!;
    private ToolStripMenuItem _saveArrayToolStripMenuItem = null!;
    private ToolStripMenuItem _exitToolStripMenuItem = null!;
    private ToolStripMenuItem _infoToolStripMenuItem = null!;

    private ArrayObject _arrayObject;
    private void _fillRandomNumber_Click(object sender, EventArgs e)
    {
        ArrayEditPanel.Visible = false;
        RandNumPanel.Visible = true;
    }

    private void _exitButton_Click(object sender, EventArgs e)
    {
        _quantityTextBox.Text = null;
        _firstLimitBox.Text = null;
        _lastLimitBox.Text = null;
        RandNumPanel.Visible = false;
        ArrayEditPanel.Visible = true;
    }

    private void _clearArray_Click(object sender, EventArgs e)
    {
        _workFieldTextBox?.Clear();
        _arrayObject.ClearArray();
    }

    private void _enterButton_Click(object sender, EventArgs e)
    {
        int firstNumber = 0, lastNumber = 0;
        uint quantity = 0;

        if (string.IsNullOrEmpty(_quantityTextBox.Text) ||
           string.IsNullOrEmpty(_firstLimitBox.Text) ||
           string.IsNullOrEmpty(_lastLimitBox.Text))
        {
            MessageForm messageForm = new("You left some fields empty!", "Error");
            messageForm.ShowDialog();
            return;
        }
        if (!(uint.TryParse(_quantityTextBox.Text, out quantity)))
        {
            MessageForm messageForm = new("Invalid data! Enter integer positive number in \"Quantity\" field!", "Error");
            messageForm.ShowDialog();
            return;
        }
        if (!(int.TryParse(_firstLimitBox.Text, out firstNumber) &&
             int.TryParse(_lastLimitBox.Text, out lastNumber)
            ))
        {
            MessageForm messageForm = new("Invalid data! Enter integer numbers in \"First Limit\" and \"Last Limit\" fields!", "Error");
            messageForm.ShowDialog();
            return;
        }
        if (firstNumber > Consts.MAX_LIMIT || firstNumber < Consts.MIN_LIMIT ||
            lastNumber > Consts.MAX_LIMIT || lastNumber < Consts.MIN_LIMIT ||
            quantity > Consts.MAX_QUANTITY || quantity == 0)
        {
            MessageForm messageForm = new("You can't use this values! \"First Limit\" and \"Last Limit\" cannot be more than " + Consts.MAX_LIMIT + " and cannot be less then " + Consts.MIN_LIMIT + "! \"Quantity\" cannot be more than " + Consts.MAX_QUANTITY + " or be or less than 0!", "Error");
            messageForm.ShowDialog();
            return;
        }

        _arrayObject?.GenerateArray(firstNumber, lastNumber, quantity);
        _workFieldTextBox.Text = _arrayObject?.GetArrayAsString() ?? null;
        _exitButton_Click(this, e);
    }

    private void ShowSortedSnakerArray_Click(object sender, EventArgs e)
    {
        if (_workFieldTextBox.Text != _arrayObject?.GetSortedArrayAsString("Shaker"))
            if (!_arrayObject?.SetStringArray(_workFieldTextBox.Text) ?? false)
            {
                MessageForm messageForm = new("Invalid format! Example of correct format: \"1 4 8 8\", without spaces in start and back.", "Error");
                messageForm.ShowDialog();
                return;
            }
        _workFieldTextBox.Text = _arrayObject?.GetSortedArrayAsString("Shaker") ?? _arrayObject?.GetArrayAsString() ?? null;
    }

    private void ShowSotredSellArray_Click(object sender, EventArgs e)
    {
        if (_arrayObject?.GetSortedArrayAsString("Shall") != _workFieldTextBox.Text)
            if (!_arrayObject?.SetStringArray(_workFieldTextBox.Text) ?? false)
            {
                MessageForm messageForm = new("Invalid format! Example of correct format: \"1 4 8 8\", without spaces in start and back.", "Error");
                messageForm.ShowDialog();
                return;
            }
        _workFieldTextBox.Text = _arrayObject?.GetSortedArrayAsString("Shall") ?? _arrayObject?.GetArrayAsString() ?? null;
    }

    private void _showSourceArray_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_arrayObject?.GetArrayAsString()))
            _arrayObject?.SetStringArray(_workFieldTextBox.Text);

        _workFieldTextBox.Text = _arrayObject?.GetArrayAsString() ?? null;
    }

    private void _exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void _openArrayToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        fileDialog.Filter = "Text files(*.txt)|*.txt";

        if (fileDialog.ShowDialog() == DialogResult.Cancel)
            return;
        if (!_arrayObject.SetStringArray(File.ReadAllText(fileDialog.FileName)))
        {
            MessageForm messageForm = new("File contain invalid data!", "Error");
            messageForm.ShowDialog();
            return;
        }

        _workFieldTextBox.Text = _arrayObject.GetArrayAsString();
    }

    private void _infoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        InfoForm infoForm = new();
        infoForm.ShowDialog();
    }

    private void SaveArrayToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SaveFileDialog fileDialog = new SaveFileDialog();
        fileDialog.Filter = "Text files(*.txt)|*txt";
        if (fileDialog.ShowDialog() == DialogResult.Cancel)
            return;
        if (string.IsNullOrEmpty(_workFieldTextBox.Text) || string.IsNullOrEmpty(_arrayObject.GetArrayAsString()) || !_arrayObject.SetStringArray(_workFieldTextBox.Text))
        {
            MessageForm messageForm = new("Invalid format! Example of correct format: \"1 4 8 8\", without spaces in start and back.", "Error");
            messageForm.ShowDialog();
            return;
        }
        File.WriteAllText(fileDialog.FileName + ".txt", _arrayObject.GetArrayAsString());
    }
    //beer1488
    private void CompareArrays_Click(object sender, EventArgs e)
    {
        int swapCountShaker1 = 0, swapCountShaker2 = 0, swapCountShaker3 = 0,
            compareCountShaker1 = 0, compareCountShaker2 = 0, compareCountShaker3 = 0,
            swapCountShall1 = 0, swapCountShall2 = 0, swapCountShall3 = 0,
            compareCountShall1 = 0, compareCountShall2 = 0, compareCountShall3 = 0;
        ArrayObject arrayObject1 = new();
        arrayObject1.SetStringArray("9 8 7 6 5 4 3 2 1");

        ArrayObject arrayObject2 = new();
        arrayObject2.SetStringArray("20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1");

        ArrayObject arrayObject3 = new();
        arrayObject3.SetStringArray("20 19 18 17 16 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1 0 -1 -2 -3 -4 -5 -6 -7 -8 -9 -10 -11 -12 -13 -14 -15 -16 -17 -18 -19 -20");

        arrayObject1.SortArrayByShaker(out swapCountShaker1, out compareCountShaker1);
        arrayObject2.SortArrayByShaker(out swapCountShaker2, out compareCountShaker2);
        arrayObject3.SortArrayByShaker(out swapCountShaker3, out compareCountShaker3);
        
        arrayObject1.ShallsSort(out swapCountShall1, out compareCountShall1);
        arrayObject2.ShallsSort(out swapCountShall2, out compareCountShall2);
        arrayObject3.ShallsSort(out swapCountShall3, out compareCountShall3);


        CompareResult[] results = {
        new CompareResult { 
            array = arrayObject1.GetArrayAsString(), compareCountShaker = compareCountShaker1, 
            swapCountShaker = swapCountShaker1, compareCountShall = compareCountShall1, swapCountShall = swapCountShall1 },
        new CompareResult { 
            array = arrayObject2.GetArrayAsString(), compareCountShaker = compareCountShaker2, 
            swapCountShaker = swapCountShaker2, compareCountShall = compareCountShall2, swapCountShall = swapCountShall2  },
        new CompareResult { 
            array = arrayObject3.GetArrayAsString(), compareCountShaker = compareCountShaker3, 
            swapCountShaker = swapCountShaker3, compareCountShall = compareCountShall3, swapCountShall = swapCountShall3  }};

        TableForm tableForm = new TableForm(results);
        tableForm.ShowDialog();
    }
}

record class CompareResult
{
    public string array = null!;
    public int swapCountShaker;
    public int compareCountShaker;
    public int swapCountShall;
    public int compareCountShall;
}