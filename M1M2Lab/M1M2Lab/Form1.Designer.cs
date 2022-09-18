/* M1_M2 Lab
 * Jason Cross and Dominic Carlucci
 * SWENG 421
 * 08/28/2022
 */

namespace M1M2Lab
{
    partial class Form1
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
            this.lineButton = new System.Windows.Forms.Button();
            this.rectButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.greenTB = new System.Windows.Forms.TrackBar();
            this.chosenColor = new System.Windows.Forms.Panel();
            this.blueTB = new System.Windows.Forms.TrackBar();
            this.redTB = new System.Windows.Forms.TrackBar();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.redLbl = new System.Windows.Forms.Label();
            this.greenLbl = new System.Windows.Forms.Label();
            this.blueLbl = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(19, 12);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(75, 23);
            this.lineButton.TabIndex = 0;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // rectButton
            // 
            this.rectButton.Location = new System.Drawing.Point(100, 12);
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(75, 23);
            this.rectButton.TabIndex = 1;
            this.rectButton.Text = "Rectangle";
            this.rectButton.UseVisualStyleBackColor = true;
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Location = new System.Drawing.Point(181, 12);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(75, 23);
            this.ellipseButton.TabIndex = 2;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.blueLbl);
            this.controlPanel.Controls.Add(this.greenLbl);
            this.controlPanel.Controls.Add(this.redLbl);
            this.controlPanel.Controls.Add(this.greenTB);
            this.controlPanel.Controls.Add(this.chosenColor);
            this.controlPanel.Controls.Add(this.blueTB);
            this.controlPanel.Controls.Add(this.redTB);
            this.controlPanel.Controls.Add(this.rectButton);
            this.controlPanel.Controls.Add(this.ellipseButton);
            this.controlPanel.Controls.Add(this.lineButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(784, 49);
            this.controlPanel.TabIndex = 3;
            // 
            // greenTB
            // 
            this.greenTB.BackColor = System.Drawing.Color.Green;
            this.greenTB.Location = new System.Drawing.Point(529, 1);
            this.greenTB.Maximum = 255;
            this.greenTB.Name = "greenTB";
            this.greenTB.Size = new System.Drawing.Size(104, 45);
            this.greenTB.TabIndex = 5;
            this.greenTB.Scroll += new System.EventHandler(this.greenTB_Scroll);
            // 
            // chosenColor
            // 
            this.chosenColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chosenColor.Location = new System.Drawing.Point(343, 3);
            this.chosenColor.Name = "chosenColor";
            this.chosenColor.Size = new System.Drawing.Size(58, 40);
            this.chosenColor.TabIndex = 6;
            // 
            // blueTB
            // 
            this.blueTB.BackColor = System.Drawing.Color.Blue;
            this.blueTB.Location = new System.Drawing.Point(639, 1);
            this.blueTB.Maximum = 255;
            this.blueTB.Name = "blueTB";
            this.blueTB.Size = new System.Drawing.Size(104, 45);
            this.blueTB.TabIndex = 4;
            this.blueTB.Scroll += new System.EventHandler(this.blueTB_Scroll);
            // 
            // redTB
            // 
            this.redTB.BackColor = System.Drawing.Color.Red;
            this.redTB.Location = new System.Drawing.Point(419, 1);
            this.redTB.Maximum = 255;
            this.redTB.Name = "redTB";
            this.redTB.Size = new System.Drawing.Size(104, 45);
            this.redTB.TabIndex = 3;
            this.redTB.Scroll += new System.EventHandler(this.redTB_Scroll);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(784, 561);
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            this.picBox.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_Paint);
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            this.picBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseUp);
            // 
            // redLbl
            // 
            this.redLbl.AutoSize = true;
            this.redLbl.Location = new System.Drawing.Point(462, 30);
            this.redLbl.Name = "redLbl";
            this.redLbl.Size = new System.Drawing.Size(13, 13);
            this.redLbl.TabIndex = 7;
            this.redLbl.Text = "0";
            // 
            // greenLbl
            // 
            this.greenLbl.AutoSize = true;
            this.greenLbl.Location = new System.Drawing.Point(570, 30);
            this.greenLbl.Name = "greenLbl";
            this.greenLbl.Size = new System.Drawing.Size(13, 13);
            this.greenLbl.TabIndex = 8;
            this.greenLbl.Text = "0";
            // 
            // blueLbl
            // 
            this.blueLbl.AutoSize = true;
            this.blueLbl.Location = new System.Drawing.Point(681, 30);
            this.blueLbl.Name = "blueLbl";
            this.blueLbl.Size = new System.Drawing.Size(13, 13);
            this.blueLbl.TabIndex = 9;
            this.blueLbl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.picBox);
            this.Name = "Form1";
            this.Text = "Paint Program";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button rectButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.TrackBar greenTB;
        private System.Windows.Forms.TrackBar blueTB;
        private System.Windows.Forms.TrackBar redTB;
        private System.Windows.Forms.Panel chosenColor;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label blueLbl;
        private System.Windows.Forms.Label greenLbl;
        private System.Windows.Forms.Label redLbl;
    }
}

