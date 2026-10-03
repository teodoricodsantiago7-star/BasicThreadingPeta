namespace BasicThreading
{
    partial class frmTrackThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Run = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Castellar", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(66, 74);
            label1.Name = "label1";
            label1.Size = new Size(341, 39);
            label1.TabIndex = 0;
            label1.Text = "-Thread Starts-";
            // 
            // Run
            // 
            Run.BackColor = Color.White;
            Run.Font = new Font("Castellar", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Run.ForeColor = Color.FromArgb(64, 0, 0);
            Run.Location = new Point(155, 137);
            Run.Name = "Run";
            Run.Size = new Size(145, 50);
            Run.TabIndex = 1;
            Run.Text = "Run";
            Run.UseVisualStyleBackColor = false;
            Run.Click += Run_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(471, 261);
            Controls.Add(Run);
            Controls.Add(label1);
            Name = "frmTrackThread";
            Text = "BasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Run;
    }
}
