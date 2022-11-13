namespace Final_Project
{
    partial class SearchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchScreen));
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMI,
            this.lookupMI,
            this.categoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMI
            // 
            this.fileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItemMI,
            this.closeMI});
            this.fileMI.Name = "fileMI";
            this.fileMI.Size = new System.Drawing.Size(37, 20);
            this.fileMI.Text = "File";
            // 
            // newItemMI
            // 
            this.newItemMI.Name = "newItemMI";
            this.newItemMI.Size = new System.Drawing.Size(145, 22);
            this.newItemMI.Text = "Add A Recipe";
            // 
            // closeMI
            // 
            this.closeMI.Name = "closeMI";
            this.closeMI.Size = new System.Drawing.Size(145, 22);
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
            this.searchMI.Enabled = false;
            this.searchMI.Name = "searchMI";
            this.searchMI.Size = new System.Drawing.Size(143, 22);
            this.searchMI.Text = "Search";
            // 
            // makeAMealToolStripMenuItem
            // 
            this.makeAMealToolStripMenuItem.Name = "makeAMealToolStripMenuItem";
            this.makeAMealToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.makeAMealToolStripMenuItem.Text = "Make A Meal";
            // 
            // dietPlansToolStripMenuItem
            // 
            this.dietPlansToolStripMenuItem.Name = "dietPlansToolStripMenuItem";
            this.dietPlansToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dietPlansToolStripMenuItem.Text = "Diet Plans";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entreesToolStripMenuItem,
            this.sideDishesToolStripMenuItem,
            this.dessertsToolStripMenuItem,
            this.snacksToolStripMenuItem});
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
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 526);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.mainMenuBtn.TabIndex = 6;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(697, 526);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 7;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Coming Soon!";
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
    }
}