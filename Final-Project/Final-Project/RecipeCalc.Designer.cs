namespace Final_Project
{
    partial class RecipeCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeCalc));
            this.rcLbl = new System.Windows.Forms.Label();
            this.recTB = new System.Windows.Forms.TextBox();
            this.servTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCBMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMI = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupMI = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMI = new System.Windows.Forms.ToolStripMenuItem();
            this.makeMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dietMI = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreesMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sidesMI = new System.Windows.Forms.ToolStripMenuItem();
            this.dessertsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.snacksMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rcLbl
            // 
            this.rcLbl.AutoSize = true;
            this.rcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcLbl.Location = new System.Drawing.Point(44, 65);
            this.rcLbl.MaximumSize = new System.Drawing.Size(700, 400);
            this.rcLbl.Name = "rcLbl";
            this.rcLbl.Size = new System.Drawing.Size(679, 48);
            this.rcLbl.TabIndex = 0;
            this.rcLbl.Text = "Here, you can pull up a recipe and calculate the ingredient amounts depending on " +
    "the number of servings you need.";
            this.rcLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recTB
            // 
            this.recTB.Location = new System.Drawing.Point(225, 166);
            this.recTB.Name = "recTB";
            this.recTB.Size = new System.Drawing.Size(305, 20);
            this.recTB.TabIndex = 1;
            // 
            // servTB
            // 
            this.servTB.Location = new System.Drawing.Point(225, 239);
            this.servTB.Name = "servTB";
            this.servTB.Size = new System.Drawing.Size(100, 20);
            this.servTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Servings Needed";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(326, 324);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 5;
            this.calcBtn.Text = "Make it so";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMI,
            this.lookupMI,
            this.categoriesToolStripMenuItem,
            this.aboutMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMI
            // 
            this.fileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemMI,
            this.saveCBMI,
            this.closeMI});
            this.fileMI.Name = "fileMI";
            this.fileMI.Size = new System.Drawing.Size(37, 20);
            this.fileMI.Text = "File";
            // 
            // addItemMI
            // 
            this.addItemMI.Name = "addItemMI";
            this.addItemMI.Size = new System.Drawing.Size(156, 22);
            this.addItemMI.Text = "Add A Recipe";
            // 
            // saveCBMI
            // 
            this.saveCBMI.Name = "saveCBMI";
            this.saveCBMI.Size = new System.Drawing.Size(156, 22);
            this.saveCBMI.Text = "Save Cookbook";
            // 
            // closeMI
            // 
            this.closeMI.Name = "closeMI";
            this.closeMI.Size = new System.Drawing.Size(156, 22);
            this.closeMI.Text = "Close";
            // 
            // lookupMI
            // 
            this.lookupMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchMI,
            this.makeMI,
            this.dietMI});
            this.lookupMI.Name = "lookupMI";
            this.lookupMI.Size = new System.Drawing.Size(59, 20);
            this.lookupMI.Text = "Lookup";
            // 
            // searchMI
            // 
            this.searchMI.Name = "searchMI";
            this.searchMI.Size = new System.Drawing.Size(143, 22);
            this.searchMI.Text = "Search";
            // 
            // makeMI
            // 
            this.makeMI.Name = "makeMI";
            this.makeMI.Size = new System.Drawing.Size(143, 22);
            this.makeMI.Text = "Make A Meal";
            // 
            // dietMI
            // 
            this.dietMI.Name = "dietMI";
            this.dietMI.Size = new System.Drawing.Size(143, 22);
            this.dietMI.Text = "Diet Plans";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entreesMI,
            this.sidesMI,
            this.dessertsMI,
            this.snacksMI});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // entreesMI
            // 
            this.entreesMI.Name = "entreesMI";
            this.entreesMI.Size = new System.Drawing.Size(133, 22);
            this.entreesMI.Text = "Entrees";
            // 
            // sidesMI
            // 
            this.sidesMI.Name = "sidesMI";
            this.sidesMI.Size = new System.Drawing.Size(133, 22);
            this.sidesMI.Text = "Side Dishes";
            // 
            // dessertsMI
            // 
            this.dessertsMI.Name = "dessertsMI";
            this.dessertsMI.Size = new System.Drawing.Size(133, 22);
            this.dessertsMI.Text = "Desserts";
            // 
            // snacksMI
            // 
            this.snacksMI.Name = "snacksMI";
            this.snacksMI.Size = new System.Drawing.Size(133, 22);
            this.snacksMI.Text = "Snacks";
            // 
            // aboutMI
            // 
            this.aboutMI.Name = "aboutMI";
            this.aboutMI.Size = new System.Drawing.Size(52, 20);
            this.aboutMI.Text = "About";
            // 
            // RecipeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servTB);
            this.Controls.Add(this.recTB);
            this.Controls.Add(this.rcLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecipeCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecipeCalc_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rcLbl;
        private System.Windows.Forms.TextBox recTB;
        private System.Windows.Forms.TextBox servTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMI;
        private System.Windows.Forms.ToolStripMenuItem addItemMI;
        private System.Windows.Forms.ToolStripMenuItem saveCBMI;
        private System.Windows.Forms.ToolStripMenuItem closeMI;
        private System.Windows.Forms.ToolStripMenuItem lookupMI;
        private System.Windows.Forms.ToolStripMenuItem searchMI;
        private System.Windows.Forms.ToolStripMenuItem makeMI;
        private System.Windows.Forms.ToolStripMenuItem dietMI;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entreesMI;
        private System.Windows.Forms.ToolStripMenuItem sidesMI;
        private System.Windows.Forms.ToolStripMenuItem dessertsMI;
        private System.Windows.Forms.ToolStripMenuItem snacksMI;
        private System.Windows.Forms.ToolStripMenuItem aboutMI;
    }
}