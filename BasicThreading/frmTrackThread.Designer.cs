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
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 55);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 0;
            label1.Text = "-Thead Starts-";
            // 
            // Run
            // 
            Run.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Run.Location = new Point(136, 135);
            Run.Margin = new Padding(3, 4, 3, 4);
            Run.Name = "Run";
            Run.Size = new Size(120, 59);
            Run.TabIndex = 1;
            Run.Text = "Run";
            Run.UseVisualStyleBackColor = true;
            Run.Click += Run_Click;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 256);
            Controls.Add(Run);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmBasicThread";
            Text = "BasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Run;
    }
}
