namespace MasterOfArrays
{
    partial class MassageForm
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
            button1 = new Button();
            MassageLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(227, 204);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = false;
            // 
            // MassageLabel
            // 
            MassageLabel.AutoSize = true;
            MassageLabel.Font = new Font("Old English Text MT", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MassageLabel.ForeColor = Color.White;
            MassageLabel.Location = new Point(42, 40);
            MassageLabel.MaximumSize = new Size(500, 200);
            MassageLabel.Name = "MassageLabel";
            MassageLabel.Size = new Size(498, 112);
            MassageLabel.TabIndex = 1;
            MassageLabel.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            // 
            // MassageForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(582, 253);
            Controls.Add(MassageLabel);
            Controls.Add(button1);
            Font = new Font("Old English Text MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MassageForm";
            Text = "Massage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label MassageLabel;
    }
}