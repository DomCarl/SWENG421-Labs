namespace Final_Project
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.entreeBtn = new System.Windows.Forms.Button();
            this.sidesBtn = new System.Windows.Forms.Button();
            this.dessertBtn = new System.Windows.Forms.Button();
            this.snackBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemMI = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMI = new System.Windows.Forms.ToolStripMenuItem();
            this.lookupMI = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMI = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAMealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dietPlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideDishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.saveCBMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entreeBtn
            // 
            this.entreeBtn.Location = new System.Drawing.Point(300, 75);
            this.entreeBtn.Name = "entreeBtn";
            this.entreeBtn.Size = new System.Drawing.Size(200, 75);
            this.entreeBtn.TabIndex = 0;
            this.entreeBtn.Text = "Entrees";
            this.entreeBtn.UseVisualStyleBackColor = true;
            this.entreeBtn.Click += new System.EventHandler(this.entreeBtn_Click);
            // 
            // sidesBtn
            // 
            this.sidesBtn.Location = new System.Drawing.Point(300, 195);
            this.sidesBtn.Name = "sidesBtn";
            this.sidesBtn.Size = new System.Drawing.Size(200, 75);
            this.sidesBtn.TabIndex = 1;
            this.sidesBtn.Text = "Side Dishes";
            this.sidesBtn.UseVisualStyleBackColor = true;
            this.sidesBtn.Click += new System.EventHandler(this.sidesBtn_Click);
            // 
            // dessertBtn
            // 
            this.dessertBtn.Location = new System.Drawing.Point(300, 314);
            this.dessertBtn.Name = "dessertBtn";
            this.dessertBtn.Size = new System.Drawing.Size(200, 75);
            this.dessertBtn.TabIndex = 2;
            this.dessertBtn.Text = "Desserts";
            this.dessertBtn.UseVisualStyleBackColor = true;
            this.dessertBtn.Click += new System.EventHandler(this.dessertBtn_Click);
            // 
            // snackBtn
            // 
            this.snackBtn.Location = new System.Drawing.Point(300, 434);
            this.snackBtn.Name = "snackBtn";
            this.snackBtn.Size = new System.Drawing.Size(200, 75);
            this.snackBtn.TabIndex = 3;
            this.snackBtn.Text = "Snacks";
            this.snackBtn.UseVisualStyleBackColor = true;
            this.snackBtn.Click += new System.EventHandler(this.snackBtn_Click);
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
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMI
            // 
            this.fileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemMI,
            this.saveCBMI,
            this.closeMI});
            this.fileMI.Name = "fileMI";
            this.fileMI.Size = new System.Drawing.Size(37, 20);
            this.fileMI.Text = "File";
            // 
            // newItemMI
            // 
            this.newItemMI.Name = "newItemMI";
            this.newItemMI.Size = new System.Drawing.Size(180, 22);
            this.newItemMI.Text = "Add A Recipe";
            this.newItemMI.Click += new System.EventHandler(this.newItemMI_Click);
            // 
            // closeMI
            // 
            this.closeMI.Name = "closeMI";
            this.closeMI.Size = new System.Drawing.Size(180, 22);
            this.closeMI.Text = "Close";
            this.closeMI.Click += new System.EventHandler(this.closeMI_Click);
            // 
            // lookupMI
            // 
            this.lookupMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchMI,
            this.makeAMealToolStripMenuItem,
            this.dietPlansToolStripMenuItem});
            this.lookupMI.Name = "lookupMI";
            this.lookupMI.Size = new System.Drawing.Size(59, 20);
            this.lookupMI.Text = "Lookup";
            // 
            // searchMI
            // 
            this.searchMI.Name = "searchMI";
            this.searchMI.Size = new System.Drawing.Size(180, 22);
            this.searchMI.Text = "Search";
            this.searchMI.Click += new System.EventHandler(this.searchMI_Click);
            // 
            // makeAMealToolStripMenuItem
            // 
            this.makeAMealToolStripMenuItem.Name = "makeAMealToolStripMenuItem";
            this.makeAMealToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeAMealToolStripMenuItem.Text = "Make A Meal";
            this.makeAMealToolStripMenuItem.Click += new System.EventHandler(this.makeAMealToolStripMenuItem_Click);
            // 
            // dietPlansToolStripMenuItem
            // 
            this.dietPlansToolStripMenuItem.Name = "dietPlansToolStripMenuItem";
            this.dietPlansToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dietPlansToolStripMenuItem.Text = "Diet Plans";
            this.dietPlansToolStripMenuItem.Click += new System.EventHandler(this.dietPlansToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entreesToolStripMenuItem,
            this.sideDishesToolStripMenuItem,
            this.dessertsToolStripMenuItem,
            this.snacksToolStripMenuItem});
            this.categoriesToolStripMenuItem.Enabled = false;
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // entreesToolStripMenuItem
            // 
            this.entreesToolStripMenuItem.Name = "entreesToolStripMenuItem";
            this.entreesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.entreesToolStripMenuItem.Text = "Entrees";
            // 
            // sideDishesToolStripMenuItem
            // 
            this.sideDishesToolStripMenuItem.Name = "sideDishesToolStripMenuItem";
            this.sideDishesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sideDishesToolStripMenuItem.Text = "Side Dishes";
            // 
            // dessertsToolStripMenuItem
            // 
            this.dessertsToolStripMenuItem.Name = "dessertsToolStripMenuItem";
            this.dessertsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dessertsToolStripMenuItem.Text = "Desserts";
            // 
            // snacksToolStripMenuItem
            // 
            this.snacksToolStripMenuItem.Name = "snacksToolStripMenuItem";
            this.snacksToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.snacksToolStripMenuItem.Text = "Snacks";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(13, 526);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.mainMenuBtn.TabIndex = 5;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(697, 526);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // saveCBMI
            // 
            this.saveCBMI.Name = "saveCBMI";
            this.saveCBMI.Size = new System.Drawing.Size(180, 22);
            this.saveCBMI.Text = "Save Cookbook";
            this.saveCBMI.Click += new System.EventHandler(this.saveCBMI_Click);
            // 
            // aboutMI
            // 
            this.aboutMI.Name = "aboutMI";
            this.aboutMI.Size = new System.Drawing.Size(52, 20);
            this.aboutMI.Text = "About";
            this.aboutMI.Click += new System.EventHandler(this.aboutMI_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.snackBtn);
            this.Controls.Add(this.dessertBtn);
            this.Controls.Add(this.sidesBtn);
            this.Controls.Add(this.entreeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Categories_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button entreeBtn;
        private System.Windows.Forms.Button sidesBtn;
        private System.Windows.Forms.Button dessertBtn;
        private System.Windows.Forms.Button snackBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMI;
        private System.Windows.Forms.ToolStripMenuItem newItemMI;
        private System.Windows.Forms.ToolStripMenuItem closeMI;
        private System.Windows.Forms.ToolStripMenuItem lookupMI;
        private System.Windows.Forms.ToolStripMenuItem searchMI;
        private System.Windows.Forms.ToolStripMenuItem makeAMealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dietPlansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sideDishesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dessertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snacksToolStripMenuItem;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.ToolStripMenuItem saveCBMI;
        private System.Windows.Forms.ToolStripMenuItem aboutMI;
    }
}