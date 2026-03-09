namespace SPBSIT__TU_;

partial class MainForm
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
    private void InitializeComponent()
    {
        _firstLimitBox = new TextBox();
        _lastLimitBox = new TextBox();
        _quantityTextBox = new TextBox();
        _firstLimitLabel = new Label();
        _lastLimitLabel = new Label();
        _quantityLabel = new Label();
        _enterButton = new Button();
        _exitButton = new Button();
        _clearArray = new Button();
        _fillRandomNumber = new Button();
        _showSourceArray = new Button();
        _showSortedArray = new Button();
        _menuStrip = new MenuStrip();
        _fileToolStripMenuItem = new ToolStripMenuItem();
        _openArrayToolStripMenuItem = new ToolStripMenuItem();
        _saveArrayToolStripMenuItem = new ToolStripMenuItem();
        _exitToolStripMenuItem = new ToolStripMenuItem();
        _infoToolStripMenuItem = new ToolStripMenuItem();
        _workFieldTextBox = new TextBox();
        _downloadArray = new Button();
        ArrayEditPanel = new Panel();
        _compareSorts = new Button();
        RandNumPanel = new Panel();
        _menuStrip.SuspendLayout();
        ArrayEditPanel.SuspendLayout();
        RandNumPanel.SuspendLayout();
        SuspendLayout();
        // 
        // _firstLimitBox
        // 
        _firstLimitBox.BackColor = Color.Black;
        _firstLimitBox.BorderStyle = BorderStyle.FixedSingle;
        _firstLimitBox.Font = new Font("Old English Text MT", 13F);
        _firstLimitBox.ForeColor = Color.White;
        _firstLimitBox.Location = new Point(34, 70);
        _firstLimitBox.Name = "_firstLimitBox";
        _firstLimitBox.Size = new Size(199, 34);
        _firstLimitBox.TabIndex = 0;
        // 
        // _lastLimitBox
        // 
        _lastLimitBox.BackColor = Color.Black;
        _lastLimitBox.BorderStyle = BorderStyle.FixedSingle;
        _lastLimitBox.Font = new Font("Old English Text MT", 13F);
        _lastLimitBox.ForeColor = Color.White;
        _lastLimitBox.Location = new Point(34, 137);
        _lastLimitBox.Name = "_lastLimitBox";
        _lastLimitBox.Size = new Size(199, 34);
        _lastLimitBox.TabIndex = 1;
        // 
        // _quantityTextBox
        // 
        _quantityTextBox.BackColor = Color.Black;
        _quantityTextBox.BorderStyle = BorderStyle.FixedSingle;
        _quantityTextBox.Font = new Font("Old English Text MT", 13F);
        _quantityTextBox.ForeColor = Color.White;
        _quantityTextBox.Location = new Point(34, 202);
        _quantityTextBox.Name = "_quantityTextBox";
        _quantityTextBox.Size = new Size(199, 34);
        _quantityTextBox.TabIndex = 2;
        // 
        // _firstLimitLabel
        // 
        _firstLimitLabel.Font = new Font("Old English Text MT", 13F);
        _firstLimitLabel.ForeColor = Color.White;
        _firstLimitLabel.Location = new Point(34, 40);
        _firstLimitLabel.Name = "_firstLimitLabel";
        _firstLimitLabel.Size = new Size(148, 27);
        _firstLimitLabel.TabIndex = 0;
        _firstLimitLabel.Text = "First Limit";
        // 
        // _lastLimitLabel
        // 
        _lastLimitLabel.Font = new Font("Old English Text MT", 13F);
        _lastLimitLabel.ForeColor = Color.White;
        _lastLimitLabel.Location = new Point(34, 107);
        _lastLimitLabel.Name = "_lastLimitLabel";
        _lastLimitLabel.Size = new Size(148, 27);
        _lastLimitLabel.TabIndex = 0;
        _lastLimitLabel.Text = "Last Limit";
        // 
        // _quantityLabel
        // 
        _quantityLabel.Font = new Font("Old English Text MT", 13F);
        _quantityLabel.ForeColor = Color.White;
        _quantityLabel.Location = new Point(34, 175);
        _quantityLabel.Name = "_quantityLabel";
        _quantityLabel.Size = new Size(199, 27);
        _quantityLabel.TabIndex = 0;
        _quantityLabel.Text = "Quantity";
        // 
        // _enterButton
        // 
        _enterButton.FlatStyle = FlatStyle.Flat;
        _enterButton.Font = new Font("Old English Text MT", 12F);
        _enterButton.ForeColor = Color.DarkRed;
        _enterButton.Location = new Point(34, 273);
        _enterButton.Name = "_enterButton";
        _enterButton.Size = new Size(73, 40);
        _enterButton.TabIndex = 0;
        _enterButton.Text = "Enter";
        _enterButton.Click += _enterButton_Click;
        // 
        // _exitButton
        // 
        _exitButton.FlatStyle = FlatStyle.Flat;
        _exitButton.Font = new Font("Old English Text MT", 12F);
        _exitButton.ForeColor = Color.DarkRed;
        _exitButton.Location = new Point(160, 273);
        _exitButton.Name = "_exitButton";
        _exitButton.Size = new Size(73, 40);
        _exitButton.TabIndex = 3;
        _exitButton.Text = "Exit";
        _exitButton.Click += _exitButton_Click;
        // 
        // _clearArray
        // 
        _clearArray.FlatStyle = FlatStyle.Flat;
        _clearArray.Font = new Font("Old English Text MT", 12F);
        _clearArray.ForeColor = Color.DarkRed;
        _clearArray.Location = new Point(141, 184);
        _clearArray.Name = "_clearArray";
        _clearArray.Size = new Size(135, 86);
        _clearArray.TabIndex = 0;
        _clearArray.Text = "Clear";
        _clearArray.Click += _clearArray_Click;
        // 
        // _fillRandomNumber
        // 
        _fillRandomNumber.FlatStyle = FlatStyle.Flat;
        _fillRandomNumber.Font = new Font("Old English Text MT", 12F);
        _fillRandomNumber.ForeColor = Color.DarkRed;
        _fillRandomNumber.Location = new Point(0, 184);
        _fillRandomNumber.Name = "_fillRandomNumber";
        _fillRandomNumber.Size = new Size(135, 86);
        _fillRandomNumber.TabIndex = 2;
        _fillRandomNumber.Text = "Fill random numbers";
        _fillRandomNumber.Click += _fillRandomNumber_Click;
        // 
        // _showSourceArray
        // 
        _showSourceArray.FlatStyle = FlatStyle.Flat;
        _showSourceArray.Font = new Font("Old English Text MT", 12F);
        _showSourceArray.ForeColor = Color.DarkRed;
        _showSourceArray.Location = new Point(141, 92);
        _showSourceArray.Name = "_showSourceArray";
        _showSourceArray.Size = new Size(135, 86);
        _showSourceArray.TabIndex = 3;
        _showSourceArray.Text = "Show source array";
        _showSourceArray.Click += _showSourceArray_Click;
        // 
        // _showSortedArray
        // 
        _showSortedArray.FlatStyle = FlatStyle.Flat;
        _showSortedArray.Font = new Font("Old English Text MT", 12F);
        _showSortedArray.ForeColor = Color.DarkRed;
        _showSortedArray.Location = new Point(0, 0);
        _showSortedArray.Name = "_showSortedArray";
        _showSortedArray.Size = new Size(135, 86);
        _showSortedArray.TabIndex = 4;
        _showSortedArray.Text = "Sort by shaker sorting";
        _showSortedArray.Click += ShowSortedSnakerArray_Click;
        // 
        // _menuStrip
        // 
        _menuStrip.BackColor = Color.Black;
        _menuStrip.Font = new Font("Old English Text MT", 12F);
        _menuStrip.ForeColor = Color.DarkRed;
        _menuStrip.ImageScalingSize = new Size(20, 20);
        _menuStrip.Items.AddRange(new ToolStripItem[] { _fileToolStripMenuItem, _infoToolStripMenuItem });
        _menuStrip.Location = new Point(0, 0);
        _menuStrip.Name = "_menuStrip";
        _menuStrip.Size = new Size(882, 32);
        _menuStrip.TabIndex = 0;
        // 
        // _fileToolStripMenuItem
        // 
        _fileToolStripMenuItem.BackColor = Color.Black;
        _fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _openArrayToolStripMenuItem, _saveArrayToolStripMenuItem, _exitToolStripMenuItem });
        _fileToolStripMenuItem.ForeColor = Color.DarkRed;
        _fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
        _fileToolStripMenuItem.Size = new Size(58, 28);
        _fileToolStripMenuItem.Text = "File";
        // 
        // _openArrayToolStripMenuItem
        // 
        _openArrayToolStripMenuItem.Name = "_openArrayToolStripMenuItem";
        _openArrayToolStripMenuItem.Size = new Size(190, 28);
        _openArrayToolStripMenuItem.Text = "Open Array";
        _openArrayToolStripMenuItem.Click += _openArrayToolStripMenuItem_Click;
        // 
        // _saveArrayToolStripMenuItem
        // 
        _saveArrayToolStripMenuItem.Name = "_saveArrayToolStripMenuItem";
        _saveArrayToolStripMenuItem.Size = new Size(190, 28);
        _saveArrayToolStripMenuItem.Text = "Save Array";
        _saveArrayToolStripMenuItem.Click += SaveArrayToolStripMenuItem_Click;
        // 
        // _exitToolStripMenuItem
        // 
        _exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
        _exitToolStripMenuItem.Size = new Size(190, 28);
        _exitToolStripMenuItem.Text = "Exit";
        _exitToolStripMenuItem.Click += _exitToolStripMenuItem_Click;
        // 
        // _infoToolStripMenuItem
        // 
        _infoToolStripMenuItem.Name = "_infoToolStripMenuItem";
        _infoToolStripMenuItem.Size = new Size(60, 28);
        _infoToolStripMenuItem.Text = "Info";
        _infoToolStripMenuItem.Click += _infoToolStripMenuItem_Click;
        // 
        // _workFieldTextBox
        // 
        _workFieldTextBox.BackColor = Color.Black;
        _workFieldTextBox.BorderStyle = BorderStyle.FixedSingle;
        _workFieldTextBox.Font = new Font("Old English Text MT", 12F);
        _workFieldTextBox.ForeColor = Color.White;
        _workFieldTextBox.Location = new Point(23, 43);
        _workFieldTextBox.Multiline = true;
        _workFieldTextBox.Name = "_workFieldTextBox";
        _workFieldTextBox.Size = new Size(547, 361);
        _workFieldTextBox.TabIndex = 1;
        // 
        // _downloadArray
        // 
        _downloadArray.FlatStyle = FlatStyle.Flat;
        _downloadArray.Font = new Font("Old English Text MT", 12F);
        _downloadArray.ForeColor = Color.DarkRed;
        _downloadArray.Location = new Point(141, 0);
        _downloadArray.Name = "_downloadArray";
        _downloadArray.Size = new Size(135, 86);
        _downloadArray.TabIndex = 5;
        _downloadArray.Text = "Sort by Shel's sorting";
        _downloadArray.Click += ShowSotredSellArray_Click;
        // 
        // ArrayEditPanel
        // 
        ArrayEditPanel.Controls.Add(_compareSorts);
        ArrayEditPanel.Controls.Add(_downloadArray);
        ArrayEditPanel.Controls.Add(_showSortedArray);
        ArrayEditPanel.Controls.Add(_showSourceArray);
        ArrayEditPanel.Controls.Add(_fillRandomNumber);
        ArrayEditPanel.Controls.Add(_clearArray);
        ArrayEditPanel.Location = new Point(594, 43);
        ArrayEditPanel.Name = "ArrayEditPanel";
        ArrayEditPanel.Size = new Size(276, 361);
        ArrayEditPanel.TabIndex = 6;
        // 
        // _compareSorts
        // 
        _compareSorts.FlatStyle = FlatStyle.Flat;
        _compareSorts.Font = new Font("Old English Text MT", 12F);
        _compareSorts.ForeColor = Color.DarkRed;
        _compareSorts.Location = new Point(0, 92);
        _compareSorts.Name = "_compareSorts";
        _compareSorts.Size = new Size(135, 86);
        _compareSorts.TabIndex = 6;
        _compareSorts.Text = "Comparison of sorts";
        _compareSorts.Click += CompareArrays_Click;
        // 
        // RandNumPanel
        // 
        RandNumPanel.Controls.Add(_exitButton);
        RandNumPanel.Controls.Add(_firstLimitBox);
        RandNumPanel.Controls.Add(_enterButton);
        RandNumPanel.Controls.Add(_lastLimitBox);
        RandNumPanel.Controls.Add(_quantityTextBox);
        RandNumPanel.Controls.Add(_firstLimitLabel);
        RandNumPanel.Controls.Add(_lastLimitLabel);
        RandNumPanel.Controls.Add(_quantityLabel);
        RandNumPanel.Location = new Point(594, 43);
        RandNumPanel.Name = "RandNumPanel";
        RandNumPanel.Size = new Size(276, 361);
        RandNumPanel.TabIndex = 7;
        RandNumPanel.Visible = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(882, 428);
        Controls.Add(_menuStrip);
        Controls.Add(_workFieldTextBox);
        Controls.Add(ArrayEditPanel);
        Controls.Add(RandNumPanel);
        MaximumSize = new Size(900, 475);
        MinimumSize = new Size(900, 475);
        Name = "MainForm";
        Text = "MasterOfArrays";
        _menuStrip.ResumeLayout(false);
        _menuStrip.PerformLayout();
        ArrayEditPanel.ResumeLayout(false);
        RandNumPanel.ResumeLayout(false);
        RandNumPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button _downloadArray;
    private Panel ArrayEditPanel;
    private Panel RandNumPanel;
    private Button _compareSorts;
}