namespace Lab5
{
    partial class InputPopup
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
            this.popupLbl = new System.Windows.Forms.Label();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.inputBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // popupLbl
            // 
            this.popupLbl.AutoSize = true;
            this.popupLbl.Location = new System.Drawing.Point(55, 77);
            this.popupLbl.Name = "popupLbl";
            this.popupLbl.Size = new System.Drawing.Size(64, 13);
            this.popupLbl.TabIndex = 0;
            this.popupLbl.Text = "Initial Value:";
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(126, 75);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(100, 20);
            this.inputTB.TabIndex = 1;
            this.inputTB.Text = "Enter a number";
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(126, 113);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(75, 23);
            this.inputBtn.TabIndex = 2;
            this.inputBtn.Text = "OK";
            this.inputBtn.UseVisualStyleBackColor = true;
            // 
            // InputPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 227);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.popupLbl);
            this.Name = "InputPopup";
            this.Text = "InputPopup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label popupLbl;
        public System.Windows.Forms.TextBox inputTB;
        public System.Windows.Forms.Button inputBtn;
    }
}