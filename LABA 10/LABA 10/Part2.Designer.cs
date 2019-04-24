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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 328);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.TBOutputWeight);
            this.tabPage1.Controls.Add(this.BTCountWeight);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(338, 302);
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
            this.comboBox1.Location = new System.Drawing.Point(19, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TBOutputWeight
            // 
            this.TBOutputWeight.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBOutputWeight.Location = new System.Drawing.Point(19, 104);
            this.TBOutputWeight.Name = "TBOutputWeight";
            this.TBOutputWeight.ReadOnly = true;
            this.TBOutputWeight.Size = new System.Drawing.Size(150, 27);
            this.TBOutputWeight.TabIndex = 1;
            // 
            // BTCountWeight
            // 
            this.BTCountWeight.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTCountWeight.Location = new System.Drawing.Point(19, 137);
            this.BTCountWeight.Name = "BTCountWeight";
            this.BTCountWeight.Size = new System.Drawing.Size(150, 39);
            this.BTCountWeight.TabIndex = 0;
            this.BTCountWeight.Text = "Вычислить";
            this.BTCountWeight.UseVisualStyleBackColor = true;
            this.BTCountWeight.Click += new System.EventHandler(this.BTCountWeight_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.TBOutputBirds);
            this.tabPage2.Controls.Add(this.BTShowBirds);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(338, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Птицы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TBOutputBirds
            // 
            this.TBOutputBirds.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBOutputBirds.Location = new System.Drawing.Point(6, 92);
            this.TBOutputBirds.Name = "TBOutputBirds";
            this.TBOutputBirds.ReadOnly = true;
            this.TBOutputBirds.Size = new System.Drawing.Size(190, 189);
            this.TBOutputBirds.TabIndex = 2;
            this.TBOutputBirds.Text = "";
            // 
            // BTShowBirds
            // 
            this.BTShowBirds.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTShowBirds.Location = new System.Drawing.Point(6, 47);
            this.BTShowBirds.Name = "BTShowBirds";
            this.BTShowBirds.Size = new System.Drawing.Size(150, 39);
            this.BTShowBirds.TabIndex = 1;
            this.BTShowBirds.Text = "Вывести";
            this.BTShowBirds.UseVisualStyleBackColor = true;
            this.BTShowBirds.Click += new System.EventHandler(this.BTShowBirds_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.TBMaxAge);
            this.tabPage3.Controls.Add(this.BTCountMaxAge);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(338, 302);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Продолжительность жизни";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TBMaxAge
            // 
            this.TBMaxAge.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBMaxAge.Location = new System.Drawing.Point(15, 62);
            this.TBMaxAge.Name = "TBMaxAge";
            this.TBMaxAge.ReadOnly = true;
            this.TBMaxAge.Size = new System.Drawing.Size(100, 27);
            this.TBMaxAge.TabIndex = 2;
            // 
            // BTCountMaxAge
            // 
            this.BTCountMaxAge.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTCountMaxAge.Location = new System.Drawing.Point(15, 95);
            this.BTCountMaxAge.Name = "BTCountMaxAge";
            this.BTCountMaxAge.Size = new System.Drawing.Size(100, 34);
            this.BTCountMaxAge.TabIndex = 1;
            this.BTCountMaxAge.Text = "Вычислить";
            this.BTCountMaxAge.UseVisualStyleBackColor = true;
            this.BTCountMaxAge.Click += new System.EventHandler(this.BTCountMaxAge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вычислить средний вес всех\r\nпредставителей данного типа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вывести имена всех птиц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вычислить среднюю продолжительность\r\nжизни всех млекопитающих";
            // 
            // Part2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 349);
            this.Controls.Add(this.tabControl1);
            this.Name = "Part2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part2";
            this.Load += new System.EventHandler(this.Part2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTCountWeight;
        private System.Windows.Forms.TextBox TBOutputWeight;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox TBOutputBirds;
        private System.Windows.Forms.Button BTShowBirds;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox TBMaxAge;
        private System.Windows.Forms.Button BTCountMaxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}