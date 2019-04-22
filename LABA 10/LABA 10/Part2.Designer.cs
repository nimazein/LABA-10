namespace LABA_10
{
    partial class Part2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TBOutputWeight = new System.Windows.Forms.TextBox();
            this.BTCountWeight = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TBOutputBirds = new System.Windows.Forms.RichTextBox();
            this.BTShowBirds = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TBMaxAge = new System.Windows.Forms.TextBox();
            this.BTCountMaxAge = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кЧасти3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.TBOutputWeight);
            this.tabPage1.Controls.Add(this.BTCountWeight);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вес";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Животные",
            "Млекопитающие",
            "Птицы",
            "Парнокопытные"});
            this.comboBox1.Location = new System.Drawing.Point(55, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TBOutputWeight
            // 
            this.TBOutputWeight.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBOutputWeight.Location = new System.Drawing.Point(55, 74);
            this.TBOutputWeight.Name = "TBOutputWeight";
            this.TBOutputWeight.ReadOnly = true;
            this.TBOutputWeight.Size = new System.Drawing.Size(150, 27);
            this.TBOutputWeight.TabIndex = 1;
            // 
            // BTCountWeight
            // 
            this.BTCountWeight.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTCountWeight.Location = new System.Drawing.Point(55, 107);
            this.BTCountWeight.Name = "BTCountWeight";
            this.BTCountWeight.Size = new System.Drawing.Size(150, 39);
            this.BTCountWeight.TabIndex = 0;
            this.BTCountWeight.Text = "Вычислить";
            this.BTCountWeight.UseVisualStyleBackColor = true;
            this.BTCountWeight.Click += new System.EventHandler(this.BTCountWeight_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TBOutputBirds);
            this.tabPage2.Controls.Add(this.BTShowBirds);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Птицы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TBOutputBirds
            // 
            this.TBOutputBirds.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBOutputBirds.Location = new System.Drawing.Point(39, 78);
            this.TBOutputBirds.Name = "TBOutputBirds";
            this.TBOutputBirds.ReadOnly = true;
            this.TBOutputBirds.Size = new System.Drawing.Size(150, 223);
            this.TBOutputBirds.TabIndex = 2;
            this.TBOutputBirds.Text = "";
            // 
            // BTShowBirds
            // 
            this.BTShowBirds.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTShowBirds.Location = new System.Drawing.Point(39, 32);
            this.BTShowBirds.Name = "BTShowBirds";
            this.BTShowBirds.Size = new System.Drawing.Size(150, 39);
            this.BTShowBirds.TabIndex = 1;
            this.BTShowBirds.Text = "Вывести";
            this.BTShowBirds.UseVisualStyleBackColor = true;
            this.BTShowBirds.Click += new System.EventHandler(this.BTShowBirds_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TBMaxAge);
            this.tabPage3.Controls.Add(this.BTCountMaxAge);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Продолжительность жизни";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TBMaxAge
            // 
            this.TBMaxAge.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBMaxAge.Location = new System.Drawing.Point(15, 26);
            this.TBMaxAge.Name = "TBMaxAge";
            this.TBMaxAge.ReadOnly = true;
            this.TBMaxAge.Size = new System.Drawing.Size(100, 27);
            this.TBMaxAge.TabIndex = 2;
            // 
            // BTCountMaxAge
            // 
            this.BTCountMaxAge.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTCountMaxAge.Location = new System.Drawing.Point(15, 64);
            this.BTCountMaxAge.Name = "BTCountMaxAge";
            this.BTCountMaxAge.Size = new System.Drawing.Size(100, 34);
            this.BTCountMaxAge.TabIndex = 1;
            this.BTCountMaxAge.Text = "Вычислить";
            this.BTCountMaxAge.UseVisualStyleBackColor = true;
            this.BTCountMaxAge.Click += new System.EventHandler(this.BTCountMaxAge_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кЧасти3ToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.действиеToolStripMenuItem.Text = "Перейти";
            // 
            // кЧасти3ToolStripMenuItem
            // 
            this.кЧасти3ToolStripMenuItem.Name = "кЧасти3ToolStripMenuItem";
            this.кЧасти3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кЧасти3ToolStripMenuItem.Text = "К части 3";
            this.кЧасти3ToolStripMenuItem.Click += new System.EventHandler(this.КЧасти3ToolStripMenuItem_Click);
            // 
            // Part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Part2";
            this.Text = "Part2";
            this.Load += new System.EventHandler(this.Part2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BTCountWeight;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.TextBox TBOutputWeight;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox TBOutputBirds;
        private System.Windows.Forms.Button BTShowBirds;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox TBMaxAge;
        private System.Windows.Forms.Button BTCountMaxAge;
        private System.Windows.Forms.ToolStripMenuItem кЧасти3ToolStripMenuItem;
    }
}