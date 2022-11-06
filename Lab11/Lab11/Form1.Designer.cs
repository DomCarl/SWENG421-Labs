namespace Lab11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tB1 = new System.Windows.Forms.TextBox();
            this.backspace = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.plusMinus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB1
            // 
            this.tB1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB1.Enabled = false;
            this.tB1.Font = new System.Drawing.Font("SansSerif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tB1.Location = new System.Drawing.Point(7, 6);
            this.tB1.Multiline = true;
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(252, 40);
            this.tB1.TabIndex = 0;
            this.tB1.Text = "0";
            this.tB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Location = new System.Drawing.Point(7, 52);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(45, 35);
            this.backspace.TabIndex = 1;
            this.backspace.TabStop = false;
            this.backspace.Text = "🠨";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.Location = new System.Drawing.Point(58, 52);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(45, 35);
            this.clearEntry.TabIndex = 2;
            this.clearEntry.TabStop = false;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = true;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(109, 52);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(45, 35);
            this.clear.TabIndex = 3;
            this.clear.TabStop = false;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // plusMinus
            // 
            this.plusMinus.Location = new System.Drawing.Point(160, 52);
            this.plusMinus.Name = "plusMinus";
            this.plusMinus.Size = new System.Drawing.Size(45, 35);
            this.plusMinus.TabIndex = 4;
            this.plusMinus.TabStop = false;
            this.plusMinus.Text = "±";
            this.plusMinus.UseVisualStyleBackColor = true;
            this.plusMinus.Click += new System.EventHandler(this.plusMinus_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(160, 93);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(45, 35);
            this.divide.TabIndex = 8;
            this.divide.TabStop = false;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.operator_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(109, 93);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(45, 35);
            this.nine.TabIndex = 7;
            this.nine.TabStop = false;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.button_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(58, 93);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(45, 35);
            this.eight.TabIndex = 6;
            this.eight.TabStop = false;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.button_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(7, 93);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(45, 35);
            this.seven.TabIndex = 5;
            this.seven.TabStop = false;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(160, 134);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(45, 35);
            this.multiply.TabIndex = 12;
            this.multiply.TabStop = false;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operator_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(109, 134);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(45, 35);
            this.six.TabIndex = 11;
            this.six.TabStop = false;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.button_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(58, 134);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(45, 35);
            this.five.TabIndex = 10;
            this.five.TabStop = false;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.button_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(7, 134);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(45, 35);
            this.four.TabIndex = 9;
            this.four.TabStop = false;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.button_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(160, 175);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(45, 35);
            this.subtract.TabIndex = 16;
            this.subtract.TabStop = false;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.operator_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(109, 175);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(45, 35);
            this.three.TabIndex = 15;
            this.three.TabStop = false;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.button_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(58, 175);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(45, 35);
            this.two.TabIndex = 14;
            this.two.TabStop = false;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.button_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(7, 175);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 35);
            this.one.TabIndex = 13;
            this.one.TabStop = false;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button_Click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(160, 216);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(45, 35);
            this.addition.TabIndex = 18;
            this.addition.TabStop = false;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.operator_Click);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(109, 216);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(45, 35);
            this.point.TabIndex = 17;
            this.point.TabStop = false;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.button_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(7, 216);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(96, 35);
            this.zero.TabIndex = 19;
            this.zero.TabStop = false;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.button_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.Location = new System.Drawing.Point(211, 52);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(45, 56);
            this.squareRoot.TabIndex = 20;
            this.squareRoot.TabStop = false;
            this.squareRoot.Text = "√";
            this.squareRoot.UseVisualStyleBackColor = true;
            this.squareRoot.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // inverse
            // 
            this.inverse.Location = new System.Drawing.Point(211, 113);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(45, 56);
            this.inverse.TabIndex = 21;
            this.inverse.TabStop = false;
            this.inverse.Text = "1/x";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.Click += new System.EventHandler(this.inverse_Click);
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(211, 175);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(45, 76);
            this.equals.TabIndex = 22;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(7, 6);
            this.lbl1.MaximumSize = new System.Drawing.Size(300, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AcceptButton = this.equals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 265);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.point);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.plusMinus);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.tB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculation Performer";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plusMinus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button squareRoot;
        private System.Windows.Forms.Button inverse;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Label lbl1;
    }
}

