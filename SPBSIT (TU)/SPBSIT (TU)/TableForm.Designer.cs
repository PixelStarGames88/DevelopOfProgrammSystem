using System.Resources;

namespace SPBSIT__TU_;

partial class TableForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    /// 
    private void FillByResults(object[] Records)
    {
        _results = new List<List<Label>>();
        foreach(object item in Records)
        {
            CompareResult result = item as CompareResult;
            Label someLabelForArray = new Label();
            int[] someArrary = result.array.Split(' ').Select(n => int.Parse(n)).ToArray();
            someLabelForArray.Text = $"max = {someArrary.Max()}, min = {someArrary.Min()}, count = {someArrary.Length}";
            someLabelForArray.AutoSize = true;  

            Label someLabelShakerSwapCount = new Label();
            someLabelShakerSwapCount.Text = result.swapCountShaker.ToString();

            Label someLabelShakerCompareCount = new Label();
            someLabelShakerCompareCount.Text = result.compareCountShaker.ToString();

            Label someLabelShallSwapCount = new Label();
            someLabelShallSwapCount.Text = result.swapCountShall.ToString();

            Label someLabelShallCompareCount = new Label();
            someLabelShallCompareCount.Text = result.compareCountShall.ToString();

            List<Label> labels = new List<Label>() 
            { someLabelForArray, someLabelShakerSwapCount, someLabelShakerCompareCount, someLabelShallSwapCount, someLabelShallCompareCount };
            _results.Add(labels);
        }

        for(int i = 0; i < _results.Count; i++)
        {
            for(int j = 0; j  < _results[i].Count; j++ )
            {
                _compareTable.Controls.Add(_results[i][j], j, i+1);
            }
        }
    }

    private void InitializeComponent()
    {
        _compareTable = new TableLayoutPanel();
        _shelCompareCount = new Label();
        _shakerSwapCount = new Label();
        _arraysTitle = new Label();
        _shelSwapCount = new Label();
        _shakerCompareCount = new Label();
        _thankYouVeryMuchButton = new Button();
        _infoLabel = new Label();
        _shakeSortTitle = new Label();
        _shallSortTitle = new Label();
        _addition = new Label();
        _compareTable.SuspendLayout();
        SuspendLayout();
        // 
        // _compareTable
        // 
        _compareTable.ColumnCount = 5;
        _compareTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.0196037F));
        _compareTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7450953F));
        _compareTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7450953F));
        _compareTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7450953F));
        _compareTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.7450953F));
        _compareTable.Controls.Add(_shelCompareCount, 4, 0);
        _compareTable.Controls.Add(_shakerSwapCount, 1, 0);
        _compareTable.Controls.Add(_arraysTitle, 0, 0);
        _compareTable.Controls.Add(_shelSwapCount, 3, 0);
        _compareTable.Controls.Add(_shakerCompareCount, 2, 0);
        _compareTable.ForeColor = Color.DarkRed;
        _compareTable.Location = new Point(12, 44);
        _compareTable.Name = "_compareTable";
        _compareTable.RowCount = 4;
        _compareTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        _compareTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        _compareTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        _compareTable.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        _compareTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        _compareTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        _compareTable.Size = new Size(795, 209);
        _compareTable.TabIndex = 0;
        // 
        // _shelCompareCount
        // 
        _shelCompareCount.AutoSize = true;
        _shelCompareCount.ForeColor = Color.White;
        _shelCompareCount.Location = new Point(695, 0);
        _shelCompareCount.MaximumSize = new Size(700, 0);
        _shelCompareCount.Name = "_shelCompareCount";
        _shelCompareCount.Size = new Size(93, 28);
        _shelCompareCount.TabIndex = 6;
        _shelCompareCount.Text = "Compare";
        // 
        // _shakerSwapCount
        // 
        _shakerSwapCount.AutoSize = true;
        _shakerSwapCount.ForeColor = Color.White;
        _shakerSwapCount.Location = new Point(392, 0);
        _shakerSwapCount.MaximumSize = new Size(700, 0);
        _shakerSwapCount.Name = "_shakerSwapCount";
        _shakerSwapCount.Size = new Size(67, 28);
        _shakerSwapCount.TabIndex = 3;
        _shakerSwapCount.Text = "Swap";
        // 
        // _arraysTitle
        // 
        _arraysTitle.AutoSize = true;
        _arraysTitle.ForeColor = Color.White;
        _arraysTitle.Location = new Point(3, 0);
        _arraysTitle.MaximumSize = new Size(700, 0);
        _arraysTitle.Name = "_arraysTitle";
        _arraysTitle.Size = new Size(78, 28);
        _arraysTitle.TabIndex = 2;
        _arraysTitle.Text = "Arrays";
        // 
        // _shelSwapCount
        // 
        _shelSwapCount.AutoSize = true;
        _shelSwapCount.ForeColor = Color.White;
        _shelSwapCount.Location = new Point(594, 0);
        _shelSwapCount.MaximumSize = new Size(700, 0);
        _shelSwapCount.Name = "_shelSwapCount";
        _shelSwapCount.Size = new Size(67, 28);
        _shelSwapCount.TabIndex = 4;
        _shelSwapCount.Text = "Swap";
        // 
        // _shakerCompareCount
        // 
        _shakerCompareCount.AutoSize = true;
        _shakerCompareCount.ForeColor = Color.White;
        _shakerCompareCount.Location = new Point(493, 0);
        _shakerCompareCount.MaximumSize = new Size(700, 0);
        _shakerCompareCount.Name = "_shakerCompareCount";
        _shakerCompareCount.Size = new Size(93, 28);
        _shakerCompareCount.TabIndex = 5;
        _shakerCompareCount.Text = "Compare";
        // 
        // _thankYouVeryMuchButton
        // 
        _thankYouVeryMuchButton.BackColor = Color.Black;
        _thankYouVeryMuchButton.FlatStyle = FlatStyle.Flat;
        _thankYouVeryMuchButton.ForeColor = Color.DarkRed;
        _thankYouVeryMuchButton.Location = new Point(297, 331);
        _thankYouVeryMuchButton.Name = "_thankYouVeryMuchButton";
        _thankYouVeryMuchButton.Size = new Size(230, 50);
        _thankYouVeryMuchButton.TabIndex = 0;
        _thankYouVeryMuchButton.Text = "Thank you very much";
        _thankYouVeryMuchButton.UseVisualStyleBackColor = false;
        _thankYouVeryMuchButton.Click += ThankYouVeryMuchButton_Click;
        // 
        // _infoLabel
        // 
        _infoLabel.AutoSize = true;
        _infoLabel.ForeColor = Color.White;
        _infoLabel.Location = new Point(12, 9);
        _infoLabel.MaximumSize = new Size(700, 0);
        _infoLabel.Name = "_infoLabel";
        _infoLabel.Size = new Size(96, 28);
        _infoLabel.TabIndex = 1;
        _infoLabel.Text = "Results: ";
        // 
        // _shakeSortTitle
        // 
        _shakeSortTitle.AutoSize = true;
        _shakeSortTitle.ForeColor = Color.White;
        _shakeSortTitle.Location = new Point(404, 9);
        _shakeSortTitle.MaximumSize = new Size(700, 0);
        _shakeSortTitle.Name = "_shakeSortTitle";
        _shakeSortTitle.Size = new Size(123, 28);
        _shakeSortTitle.TabIndex = 2;
        _shakeSortTitle.Text = "Shaker sort";
        // 
        // _shallSortTitle
        // 
        _shallSortTitle.AutoSize = true;
        _shallSortTitle.ForeColor = Color.White;
        _shallSortTitle.Location = new Point(606, 9);
        _shallSortTitle.MaximumSize = new Size(700, 0);
        _shallSortTitle.Name = "_shallSortTitle";
        _shallSortTitle.Size = new Size(122, 28);
        _shallSortTitle.TabIndex = 3;
        _shallSortTitle.Text = "Shall's sort";
        // 
        // _addition
        // 
        _addition.AutoSize = true;
        _addition.ForeColor = Color.White;
        _addition.Location = new Point(15, 256);
        _addition.MaximumSize = new Size(700, 0);
        _addition.Name = "_addition";
        _addition.Size = new Size(305, 28);
        _addition.TabIndex = 4;
        _addition.Text = "All examples are reverse arrays.";
        // 
        // TableForm
        // 
        AutoScaleDimensions = new SizeF(14F, 27F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(825, 394);
        Controls.Add(_addition);
        Controls.Add(_shallSortTitle);
        Controls.Add(_shakeSortTitle);
        Controls.Add(_compareTable);
        Controls.Add(_infoLabel);
        Controls.Add(_thankYouVeryMuchButton);
        Font = new Font("Old English Text MT", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Name = "TableForm";
        Text = "Compare results";
        _compareTable.ResumeLayout(false);
        _compareTable.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button _thankYouVeryMuchButton;
    private Label _infoLabel;
    private TableLayoutPanel _compareTable;
    private Label _arraysTitle;

    private List<List<Label>> _results;
    private Label _shelCompareCount;
    private Label _shakerCompareCount;
    private Label _shelSwapCount;
    private Label _shakerSwapCount;
    private Label _shakeSortTitle;
    private Label _shallSortTitle;
    private Label _addition;
}