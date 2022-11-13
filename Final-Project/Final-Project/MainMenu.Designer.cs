namespace Final_Project
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemMI = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dietsBtn = new System.Windows.Forms.Button();
            this.catBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.makeBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMI
            // 
            this.fileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemMI,
            this.closeMI});
            this.fileMI.Name = "fileMI";
            this.fileMI.Size = new System.Drawing.Size(37, 20);
            this.fileMI.Text = "File";
            // 
            // addItemMI
            // 
            this.addItemMI.Name = "addItemMI";
            this.addItemMI.Size = new System.Drawing.Size(145, 22);
            this.addItemMI.Text = "Add A Recipe";
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
            this.makeMI,
            this.dietMI});
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
            // makeMI
            // 
            this.makeMI.Name = "makeMI";
            this.makeMI.Size = new System.Drawing.Size(180, 22);
            this.makeMI.Text = "Make A Meal";
            this.makeMI.Click += new System.EventHandler(this.makeMI_Click);
            // 
            // dietMI
            // 
            this.dietMI.Name = "dietMI";
            this.dietMI.Size = new System.Drawing.Size(180, 22);
            this.dietMI.Text = "Diet Plans";
            this.dietMI.Click += new System.EventHandler(this.dietMI_Click);
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
            this.entreesMI.Size = new System.Drawing.Size(180, 22);
            this.entreesMI.Text = "Entrees";
            this.entreesMI.Click += new System.EventHandler(this.entreesMI_Click);
            // 
            // sidesMI
            // 
            this.sidesMI.Name = "sidesMI";
            this.sidesMI.Size = new System.Drawing.Size(180, 22);
            this.sidesMI.Text = "Side Dishes";
            this.sidesMI.Click += new System.EventHandler(this.sidesMI_Click);
            // 
            // dessertsMI
            // 
            this.dessertsMI.Name = "dessertsMI";
            this.dessertsMI.Size = new System.Drawing.Size(180, 22);
            this.dessertsMI.Text = "Desserts";
            this.dessertsMI.Click += new System.EventHandler(this.dessertsMI_Click);
            // 
            // snacksMI
            // 
            this.snacksMI.Name = "snacksMI";
            this.snacksMI.Size = new System.Drawing.Size(180, 22);
            this.snacksMI.Text = "Snacks";
            this.snacksMI.Click += new System.EventHandler(this.snacksMI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 307);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(94, 364);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(200, 50);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(500, 364);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(200, 50);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "Add A Recipe";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dietsBtn
            // 
            this.dietsBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dietsBtn.ForeColor = System.Drawing.Color.White;
            this.dietsBtn.Location = new System.Drawing.Point(500, 429);
            this.dietsBtn.Name = "dietsBtn";
            this.dietsBtn.Size = new System.Drawing.Size(200, 50);
            this.dietsBtn.TabIndex = 5;
            this.dietsBtn.Text = "Diet Plans";
            this.dietsBtn.UseVisualStyleBackColor = false;
            this.dietsBtn.Click += new System.EventHandler(this.dietsBtn_Click);
            // 
            // catBtn
            // 
            this.catBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.catBtn.ForeColor = System.Drawing.Color.White;
            this.catBtn.Location = new System.Drawing.Point(94, 429);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(200, 50);
            this.catBtn.TabIndex = 4;
            this.catBtn.Text = "Categories";
            this.catBtn.UseVisualStyleBackColor = false;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(500, 496);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(200, 50);
            this.quitBtn.TabIndex = 7;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // makeBtn
            // 
            this.makeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.makeBtn.ForeColor = System.Drawing.Color.White;
            this.makeBtn.Location = new System.Drawing.Point(94, 496);
            this.makeBtn.Name = "makeBtn";
            this.makeBtn.Size = new System.Drawing.Size(200, 50);
            this.makeBtn.TabIndex = 6;
            this.makeBtn.Text = "Make A Meal";
            this.makeBtn.UseVisualStyleBackColor = false;
            this.makeBtn.Click += new System.EventHandler(this.makeBtn_Click);
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.makeBtn);
            this.Controls.Add(this.dietsBtn);
            this.Controls.Add(this.catBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Cookbook";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMI;
        private System.Windows.Forms.ToolStripMenuItem addItemMI;
        private System.Windows.Forms.ToolStripMenuItem closeMI;
        private System.Windows.Forms.ToolStripMenuItem lookupMI;
        private System.Windows.Forms.ToolStripMenuItem searchMI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button dietsBtn;
        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button makeBtn;
        private System.Windows.Forms.ToolStripMenuItem makeMI;
        private System.Windows.Forms.ToolStripMenuItem dietMI;
        private System.Windows.Forms.ToolStripMenuItem entreesMI;
        private System.Windows.Forms.ToolStripMenuItem sidesMI;
        private System.Windows.Forms.ToolStripMenuItem dessertsMI;
        private System.Windows.Forms.ToolStripMenuItem snacksMI;
    }
}

