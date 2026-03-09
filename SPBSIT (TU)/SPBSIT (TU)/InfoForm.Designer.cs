namespace SPBSIT__TU_;

partial class InfoForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
        _thankYouVeryMuchButton = new Button();
        _infoLabel = new Label();
        SuspendLayout();
        // 
        // _thankYouVeryMuchButton
        // 
        _thankYouVeryMuchButton.BackColor = Color.Black;
        _thankYouVeryMuchButton.FlatStyle = FlatStyle.Flat;
        _thankYouVeryMuchButton.ForeColor = Color.DarkRed;
        _thankYouVeryMuchButton.Location = new Point(225, 163);
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
        _infoLabel.Location = new Point(1, 9);
        _infoLabel.MaximumSize = new Size(700, 0);
        _infoLabel.Name = "_infoLabel";
        _infoLabel.Size = new Size(700, 140);
        _infoLabel.TabIndex = 1;
        _infoLabel.Text = resources.GetString("_infoLabel.Text");
        // 
        // InfoForm
        // 
        AutoScaleDimensions = new SizeF(14F, 27F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(702, 223);
        Controls.Add(_infoLabel);
        Controls.Add(_thankYouVeryMuchButton);
        Font = new Font("Old English Text MT", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5, 4, 5, 4);
        MaximumSize = new Size(720, 270);
        MinimumSize = new Size(720, 270);
        Name = "InfoForm";
        Text = "Info";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button _thankYouVeryMuchButton;
    private Label _infoLabel;
}