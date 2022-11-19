namespace Final_Project
{
    partial class DietPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DietPlans));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCBMI = new System.Windows.Forms.ToolStripMenuItem();
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
            this.aboutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.quitBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.standardBtn = new System.Windows.Forms.Button();
            this.ketoBtn = new System.Windows.Forms.Button();
            this.sbBtn = new System.Windows.Forms.Button();
            this.sfBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            this.newItemMI.Size = new System.Drawing.Size(156, 22);
            this.newItemMI.Text = "Add A Recipe";
            this.newItemMI.Click += new System.EventHandler(this.newItemMI_Click);
            // 
            // saveCBMI
            // 
            this.saveCBMI.Name = "saveCBMI";
            this.saveCBMI.Size = new System.Drawing.Size(156, 22);
            this.saveCBMI.Text = "Save Cookbook";
            this.saveCBMI.Click += new System.EventHandler(this.saveCBMI_Click);
            // 
            // closeMI
            // 
            this.closeMI.Name = "closeMI";
            this.closeMI.Size = new System.Drawing.Size(156, 22);
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
            this.searchMI.Size = new System.Drawing.Size(143, 22);
            this.searchMI.Text = "Search";
            this.searchMI.Click += new System.EventHandler(this.searchMI_Click);
            // 
            // makeAMealToolStripMenuItem
            // 
            this.makeAMealToolStripMenuItem.Name = "makeAMealToolStripMenuItem";
            this.makeAMealToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.makeAMealToolStripMenuItem.Text = "Make A Meal";
            this.makeAMealToolStripMenuItem.Click += new System.EventHandler(this.makeAMealToolStripMenuItem_Click);
            // 
            // dietPlansToolStripMenuItem
            // 
            this.dietPlansToolStripMenuItem.Enabled = false;
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
            this.entreesToolStripMenuItem.Click += new System.EventHandler(this.entreesToolStripMenuItem_Click);
            // 
            // sideDishesToolStripMenuItem
            // 
            this.sideDishesToolStripMenuItem.Name = "sideDishesToolStripMenuItem";
            this.sideDishesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sideDishesToolStripMenuItem.Text = "Side Dishes";
            this.sideDishesToolStripMenuItem.Click += new System.EventHandler(this.sideDishesToolStripMenuItem_Click);
            // 
            // dessertsToolStripMenuItem
            // 
            this.dessertsToolStripMenuItem.Name = "dessertsToolStripMenuItem";
            this.dessertsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dessertsToolStripMenuItem.Text = "Desserts";
            this.dessertsToolStripMenuItem.Click += new System.EventHandler(this.dessertsToolStripMenuItem_Click);
            // 
            // snacksToolStripMenuItem
            // 
            this.snacksToolStripMenuItem.Name = "snacksToolStripMenuItem";
            this.snacksToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.snacksToolStripMenuItem.Text = "Snacks";
            this.snacksToolStripMenuItem.Click += new System.EventHandler(this.snacksToolStripMenuItem_Click);
            // 
            // aboutMI
            // 
            this.aboutMI.Name = "aboutMI";
            this.aboutMI.Size = new System.Drawing.Size(52, 20);
            this.aboutMI.Text = "About";
            this.aboutMI.Click += new System.EventHandler(this.aboutMI_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Diet Plans";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(697, 526);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 10;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.Location = new System.Drawing.Point(12, 527);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(75, 23);
            this.mainMenuBtn.TabIndex = 9;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = true;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // standardBtn
            // 
            this.standardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardBtn.Location = new System.Drawing.Point(203, 100);
            this.standardBtn.Name = "standardBtn";
            this.standardBtn.Size = new System.Drawing.Size(389, 102);
            this.standardBtn.TabIndex = 12;
            this.standardBtn.Text = "Standard";
            this.standardBtn.UseVisualStyleBackColor = true;
            this.standardBtn.Click += new System.EventHandler(this.standardBtn_Click);
            // 
            // ketoBtn
            // 
            this.ketoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketoBtn.Location = new System.Drawing.Point(203, 208);
            this.ketoBtn.Name = "ketoBtn";
            this.ketoBtn.Size = new System.Drawing.Size(389, 102);
            this.ketoBtn.TabIndex = 13;
            this.ketoBtn.Text = "Keto";
            this.ketoBtn.UseVisualStyleBackColor = true;
            this.ketoBtn.Click += new System.EventHandler(this.ketoBtn_Click);
            // 
            // sbBtn
            // 
            this.sbBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbBtn.Location = new System.Drawing.Point(203, 316);
            this.sbBtn.Name = "sbBtn";
            this.sbBtn.Size = new System.Drawing.Size(389, 102);
            this.sbBtn.TabIndex = 14;
            this.sbBtn.Text = "South Beach";
            this.sbBtn.UseVisualStyleBackColor = true;
            this.sbBtn.Click += new System.EventHandler(this.sbBtn_Click);
            // 
            // sfBtn
            // 
            this.sfBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfBtn.Location = new System.Drawing.Point(203, 424);
            this.sfBtn.Name = "sfBtn";
            this.sfBtn.Size = new System.Drawing.Size(389, 102);
            this.sfBtn.TabIndex = 15;
            this.sfBtn.Text = "See Food";
            this.sfBtn.UseVisualStyleBackColor = true;
            this.sfBtn.Click += new System.EventHandler(this.sfBtn_Click);
            // 
            // DietPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.sfBtn);
            this.Controls.Add(this.sbBtn);
            this.Controls.Add(this.ketoBtn);
            this.Controls.Add(this.standardBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DietPlans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DietPlans";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DietPlans_FormClosed);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button standardBtn;
        private System.Windows.Forms.Button ketoBtn;
        private System.Windows.Forms.Button sbBtn;
        private System.Windows.Forms.Button sfBtn;
        private System.Windows.Forms.ToolStripMenuItem saveCBMI;
        private System.Windows.Forms.ToolStripMenuItem aboutMI;
    }
}