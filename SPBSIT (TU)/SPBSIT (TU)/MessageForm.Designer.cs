namespace SPBSIT__TU_;

partial class MessageForm
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
        _okButton = new Button();
        _messageLabel = new Label();
        SuspendLayout();
        // 
        // _okButton
        // 
        _okButton.FlatStyle = FlatStyle.Flat;
        _okButton.ForeColor = Color.DarkRed;
        _okButton.Location = new Point(233, 142);
        _okButton.Name = "ButtonOK";
        _okButton.Size = new Size(95, 38);
        _okButton.TabIndex = 0;
        _okButton.Text = "OK";
        _okButton.UseVisualStyleBackColor = true;
        _okButton.Click += ButtonOK_Click;
        // 
        // _messageLabel
        // 
        _messageLabel.AutoSize = true;
        _messageLabel.ForeColor = Color.White;
        _messageLabel.Location = new Point(10, 18);
        _messageLabel.MaximumSize = new Size(560, 110);
        _messageLabel.MinimumSize = new Size(560, 110);
        _messageLabel.Name = "MessageLabel";
        _messageLabel.Size = new Size(560, 110);
        _messageLabel.TabIndex = 1;
        _messageLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MessageForm
        // 
        AutoScaleDimensions = new SizeF(14F, 27F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(582, 193);
        Controls.Add(_messageLabel);
        Controls.Add(_okButton);
        Font = new Font("Old English Text MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5, 4, 5, 4);
        MaximumSize = new Size(600, 240);
        MinimumSize = new Size(600, 240);
        Name = "MessageForm";
        Text = "Message";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button _okButton;
    private Label _messageLabel;
}