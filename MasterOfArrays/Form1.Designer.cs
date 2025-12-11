namespace MasterOfArrays
{
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
            ButtonOK = new Button();
            MessageLabel = new Label();
            SuspendLayout();
            // 
            // ButtonOK
            // 
            ButtonOK.FlatStyle = FlatStyle.Flat;
            ButtonOK.ForeColor = Color.DarkRed;
            ButtonOK.Location = new Point(233, 142);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(95, 38);
            ButtonOK.TabIndex = 0;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.ForeColor = Color.White;
            MessageLabel.Location = new Point(10, 18);
            MessageLabel.MaximumSize = new Size(560, 110);
            MessageLabel.MinimumSize = new Size(560, 110);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(560, 110);
            MessageLabel.TabIndex = 1;
            MessageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MessageForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 193);
            Controls.Add(MessageLabel);
            Controls.Add(ButtonOK);
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

        private Button ButtonOK;
        private Label MessageLabel;
    }
}