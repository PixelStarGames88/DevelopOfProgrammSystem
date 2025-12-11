namespace MasterOfArrays;

partial class SaveBeforeExitForm
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
        LabelQuestion = new Label();
        ButtonYes = new Button();
        ButtonNo = new Button();
        ButtonCancel = new Button();
        SuspendLayout();
        // 
        // LabelQuestion
        // 
        LabelQuestion.AutoSize = true;
        LabelQuestion.Font = new Font("Old English Text MT", 14F);
        LabelQuestion.ForeColor = Color.White;
        LabelQuestion.Location = new Point(25, 52);
        LabelQuestion.Name = "LabelQuestion";
        LabelQuestion.Size = new Size(352, 28);
        LabelQuestion.TabIndex = 0;
        LabelQuestion.Text = "Do you want to save array before exit?";
        // 
        // ButtonYes
        // 
        ButtonYes.FlatStyle = FlatStyle.Flat;
        ButtonYes.Font = new Font("Old English Text MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonYes.ForeColor = Color.DarkRed;
        ButtonYes.Location = new Point(25, 121);
        ButtonYes.Name = "ButtonYes";
        ButtonYes.Size = new Size(94, 35);
        ButtonYes.TabIndex = 1;
        ButtonYes.Text = "Yes";
        ButtonYes.UseVisualStyleBackColor = true;
        ButtonYes.Click += (o, e) => DialogResult = DialogResult.Yes;
        // 
        // ButtonNo
        // 
        ButtonNo.FlatStyle = FlatStyle.Flat;
        ButtonNo.Font = new Font("Old English Text MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonNo.ForeColor = Color.DarkRed;
        ButtonNo.Location = new Point(154, 121);
        ButtonNo.Name = "ButtonNo";
        ButtonNo.Size = new Size(94, 35);
        ButtonNo.TabIndex = 2;
        ButtonNo.Text = "No";
        ButtonNo.UseVisualStyleBackColor = true;
        ButtonNo.Click += (o, e) => DialogResult = DialogResult.No;
        // 
        // ButtonCancel
        // 
        ButtonCancel.FlatStyle = FlatStyle.Flat;
        ButtonCancel.Font = new Font("Old English Text MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ButtonCancel.ForeColor = Color.DarkRed;
        ButtonCancel.Location = new Point(283, 121);
        ButtonCancel.Name = "ButtonCancel";
        ButtonCancel.Size = new Size(94, 35);
        ButtonCancel.TabIndex = 3;
        ButtonCancel.Text = "Cancel";
        ButtonCancel.UseVisualStyleBackColor = true;
        ButtonCancel.Click += (o, e) => DialogResult = DialogResult.Cancel;
        // 
        // SaveBeforeExitForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(403, 183);
        Controls.Add(ButtonCancel);
        Controls.Add(ButtonNo);
        Controls.Add(ButtonYes);
        Controls.Add(LabelQuestion);
        Name = "SaveBeforeExitForm";
        Text = "SaveBeforeExitForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label LabelQuestion;
    private Button ButtonYes;
    private Button ButtonNo;
    private Button ButtonCancel;
}