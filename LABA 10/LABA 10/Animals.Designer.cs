namespace LABA_10
{
    partial class Animals
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BTAnimalCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBAnimalWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBAnimalName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводМассиваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кМлекопитающимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кПтицамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кПарнокопытнымToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.кЧасти2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BTAnimalCreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBAnimalWeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBAnimalName);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать животное";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "кг";
            // 
            // BTAnimalCreate
            // 
            this.BTAnimalCreate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTAnimalCreate.Location = new System.Drawing.Point(93, 109);
            this.BTAnimalCreate.Name = "BTAnimalCreate";
            this.BTAnimalCreate.Size = new System.Drawing.Size(111, 28);
            this.BTAnimalCreate.TabIndex = 4;
            this.BTAnimalCreate.Text = "Cоздать";
            this.BTAnimalCreate.UseVisualStyleBackColor = true;
            this.BTAnimalCreate.Click += new System.EventHandler(this.BTAnimalCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес";
            // 
            // TBAnimalWeight
            // 
            this.TBAnimalWeight.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBAnimalWeight.Location = new System.Drawing.Point(93, 76);
            this.TBAnimalWeight.Name = "TBAnimalWeight";
            this.TBAnimalWeight.Size = new System.Drawing.Size(112, 27);
            this.TBAnimalWeight.TabIndex = 2;
            this.TBAnimalWeight.TextChanged += new System.EventHandler(this.TBAnimalWeight_TextChanged);
            this.TBAnimalWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAnimalWeight_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // TBAnimalName
            // 
            this.TBAnimalName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBAnimalName.Location = new System.Drawing.Point(93, 43);
            this.TBAnimalName.Name = "TBAnimalName";
            this.TBAnimalName.Size = new System.Drawing.Size(334, 27);
            this.TBAnimalName.TabIndex = 0;
            this.TBAnimalName.TextChanged += new System.EventHandler(this.TBAnimalName_TextChanged);
            this.TBAnimalName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAnimalName_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводМассиваToolStripMenuItem,
            this.кМлекопитающимToolStripMenuItem,
            this.кПтицамToolStripMenuItem,
            this.кПарнокопытнымToolStripMenuItem,
            this.кЧасти2ToolStripMenuItem});
            this.действиеToolStripMenuItem.Name = "действиеToolStripMenuItem";
            this.действиеToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действиеToolStripMenuItem.Text = "Действие";
            // 
            // выводМассиваToolStripMenuItem
            // 
            this.выводМассиваToolStripMenuItem.Name = "выводМассиваToolStripMenuItem";
            this.выводМассиваToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выводМассиваToolStripMenuItem.Text = "Вывод массива";
            this.выводМассиваToolStripMenuItem.Click += new System.EventHandler(this.выводМассиваToolStripMenuItem_Click);
            // 
            // кМлекопитающимToolStripMenuItem
            // 
            this.кМлекопитающимToolStripMenuItem.Name = "кМлекопитающимToolStripMenuItem";
            this.кМлекопитающимToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.кМлекопитающимToolStripMenuItem.Text = "К млекопитающим";
            this.кМлекопитающимToolStripMenuItem.Click += new System.EventHandler(this.КМлекопитающимToolStripMenuItem_Click);
            // 
            // кПтицамToolStripMenuItem
            // 
            this.кПтицамToolStripMenuItem.Name = "кПтицамToolStripMenuItem";
            this.кПтицамToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.кПтицамToolStripMenuItem.Text = "К птицам";
            this.кПтицамToolStripMenuItem.Click += new System.EventHandler(this.кПтицамToolStripMenuItem_Click);
            // 
            // кПарнокопытнымToolStripMenuItem
            // 
            this.кПарнокопытнымToolStripMenuItem.Name = "кПарнокопытнымToolStripMenuItem";
            this.кПарнокопытнымToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.кПарнокопытнымToolStripMenuItem.Text = "К парнокопытным";
            this.кПарнокопытнымToolStripMenuItem.Click += new System.EventHandler(this.кПарнокопытнымToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 213);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(417, 188);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // кЧасти2ToolStripMenuItem
            // 
            this.кЧасти2ToolStripMenuItem.Name = "кЧасти2ToolStripMenuItem";
            this.кЧасти2ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.кЧасти2ToolStripMenuItem.Text = "К части 2";
            this.кЧасти2ToolStripMenuItem.Click += new System.EventHandler(this.КЧасти2ToolStripMenuItem_Click);
            // 
            // Animals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Animals";
            this.Text = "Animals";
            this.Load += new System.EventHandler(this.Animals_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTAnimalCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBAnimalWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBAnimalName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кМлекопитающимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кПтицамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кПарнокопытнымToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводМассиваToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem кЧасти2ToolStripMenuItem;
    }
}