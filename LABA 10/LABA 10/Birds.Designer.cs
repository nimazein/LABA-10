namespace LABA_10
{
    partial class Birds
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
            this.CBDomestic = new System.Windows.Forms.CheckBox();
            this.CBFlying = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTBirdCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBBirdWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBBirdName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводМассиваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кЖивотнымToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кМлекопитающимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox1.Controls.Add(this.CBDomestic);
            this.groupBox1.Controls.Add(this.CBFlying);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BTBirdCreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBBirdWeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBBirdName);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать птицу";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CBDomestic
            // 
            this.CBDomestic.AutoSize = true;
            this.CBDomestic.Location = new System.Drawing.Point(118, 142);
            this.CBDomestic.Name = "CBDomestic";
            this.CBDomestic.Size = new System.Drawing.Size(15, 14);
            this.CBDomestic.TabIndex = 11;
            this.CBDomestic.UseVisualStyleBackColor = true;
            // 
            // CBFlying
            // 
            this.CBFlying.AutoSize = true;
            this.CBFlying.Location = new System.Drawing.Point(119, 107);
            this.CBFlying.Name = "CBFlying";
            this.CBFlying.Size = new System.Drawing.Size(15, 14);
            this.CBFlying.TabIndex = 10;
            this.CBFlying.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вес (кг)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Домашняя";
            // 
            // BTBirdCreate
            // 
            this.BTBirdCreate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTBirdCreate.Location = new System.Drawing.Point(10, 177);
            this.BTBirdCreate.Name = "BTBirdCreate";
            this.BTBirdCreate.Size = new System.Drawing.Size(111, 28);
            this.BTBirdCreate.TabIndex = 4;
            this.BTBirdCreate.Text = "Cоздать";
            this.BTBirdCreate.UseVisualStyleBackColor = true;
            this.BTBirdCreate.Click += new System.EventHandler(this.BTBirdCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Умеет летать";
            // 
            // TBBirdWeight
            // 
            this.TBBirdWeight.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBBirdWeight.Location = new System.Drawing.Point(118, 65);
            this.TBBirdWeight.Name = "TBBirdWeight";
            this.TBBirdWeight.Size = new System.Drawing.Size(116, 27);
            this.TBBirdWeight.TabIndex = 2;
            this.TBBirdWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBirdWeight_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // TBBirdName
            // 
            this.TBBirdName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBBirdName.Location = new System.Drawing.Point(116, 32);
            this.TBBirdName.Name = "TBBirdName";
            this.TBBirdName.Size = new System.Drawing.Size(335, 27);
            this.TBBirdName.TabIndex = 0;
            this.TBBirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBBirdName_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводМассиваToolStripMenuItem,
            this.кЖивотнымToolStripMenuItem,
            this.кМлекопитающимToolStripMenuItem,
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
            // кЖивотнымToolStripMenuItem
            // 
            this.кЖивотнымToolStripMenuItem.Name = "кЖивотнымToolStripMenuItem";
            this.кЖивотнымToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.кЖивотнымToolStripMenuItem.Text = "К животным";
            this.кЖивотнымToolStripMenuItem.Click += new System.EventHandler(this.кЖивотнымToolStripMenuItem_Click);
            // 
            // кМлекопитающимToolStripMenuItem
            // 
            this.кМлекопитающимToolStripMenuItem.Name = "кМлекопитающимToolStripMenuItem";
            this.кМлекопитающимToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.кМлекопитающимToolStripMenuItem.Text = "К млекопитающим";
            this.кМлекопитающимToolStripMenuItem.Click += new System.EventHandler(this.кМлекопитающимToolStripMenuItem_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 261);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод массива";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(441, 236);
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
            // Birds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Birds";
            this.Text = "Birds";
            this.Load += new System.EventHandler(this.Birds_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTBirdCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBBirdWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBirdName;
        private System.Windows.Forms.CheckBox CBFlying;
        private System.Windows.Forms.CheckBox CBDomestic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кЖивотнымToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кМлекопитающимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кПарнокопытнымToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem выводМассиваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кЧасти2ToolStripMenuItem;
    }
}