namespace Lab5
{
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
            this.compCB = new System.Windows.Forms.ComboBox();
            this.CompLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compCB
            // 
            this.compCB.FormattingEnabled = true;
            this.compCB.Location = new System.Drawing.Point(12, 61);
            this.compCB.Name = "compCB";
            this.compCB.Size = new System.Drawing.Size(121, 21);
            this.compCB.TabIndex = 0;
            this.compCB.Text = "Choose computation";
            // 
            // CompLabel
            // 
            this.CompLabel.AutoSize = true;
            this.CompLabel.Location = new System.Drawing.Point(132, 9);
            this.CompLabel.Name = "CompLabel";
            this.CompLabel.Size = new System.Drawing.Size(66, 13);
            this.CompLabel.TabIndex = 1;
            this.CompLabel.Text = "Computation";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(241, 64);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Output";
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 270);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.CompLabel);
            this.Controls.Add(this.compCB);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox compCB;
        public System.Windows.Forms.Label CompLabel;
        public System.Windows.Forms.Label outputLabel;
    }
}

