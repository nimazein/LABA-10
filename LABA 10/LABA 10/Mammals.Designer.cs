﻿namespace LABA_10
{
    partial class Mammals
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBIncubationPeriod = new System.Windows.Forms.TextBox();
            this.TBMaxAge = new System.Windows.Forms.TextBox();
            this.BTMammalCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBMammalWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMammalName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводМассиваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кЖивотнымToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TBIncubationPeriod);
            this.groupBox1.Controls.Add(this.TBMaxAge);
            this.groupBox1.Controls.Add(this.BTMammalCreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBMammalWeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBMammalName);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать млекопитающее";
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
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Продолжительность беременности (месяцев)";
            // 
            // TBIncubationPeriod
            // 
            this.TBIncubationPeriod.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBIncubationPeriod.Location = new System.Drawing.Point(372, 98);
            this.TBIncubationPeriod.Name = "TBIncubationPeriod";
            this.TBIncubationPeriod.Size = new System.Drawing.Size(56, 27);
            this.TBIncubationPeriod.TabIndex = 7;
            this.TBIncubationPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBIncubationPeriod_KeyPress);
            // 
            // TBMaxAge
            // 
            this.TBMaxAge.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBMaxAge.Location = new System.Drawing.Point(372, 134);
            this.TBMaxAge.Name = "TBMaxAge";
            this.TBMaxAge.Size = new System.Drawing.Size(56, 27);
            this.TBMaxAge.TabIndex = 6;
            this.TBMaxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMaxAge_KeyPress);
            // 
            // BTMammalCreate
            // 
            this.BTMammalCreate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTMammalCreate.Location = new System.Drawing.Point(10, 177);
            this.BTMammalCreate.Name = "BTMammalCreate";
            this.BTMammalCreate.Size = new System.Drawing.Size(111, 28);
            this.BTMammalCreate.TabIndex = 4;
            this.BTMammalCreate.Text = "Cоздать";
            this.BTMammalCreate.UseVisualStyleBackColor = true;
            this.BTMammalCreate.Click += new System.EventHandler(this.BTAnimalCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Продолжительность жизни (лет)";
            // 
            // TBMammalWeight
            // 
            this.TBMammalWeight.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBMammalWeight.Location = new System.Drawing.Point(312, 65);
            this.TBMammalWeight.Name = "TBMammalWeight";
            this.TBMammalWeight.Size = new System.Drawing.Size(116, 27);
            this.TBMammalWeight.TabIndex = 2;
            this.TBMammalWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMammalWeight_KeyPress);
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
            // TBMammalName
            // 
            this.TBMammalName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBMammalName.Location = new System.Drawing.Point(93, 32);
            this.TBMammalName.Name = "TBMammalName";
            this.TBMammalName.Size = new System.Drawing.Size(335, 27);
            this.TBMammalName.TabIndex = 0;
            this.TBMammalName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMammalName_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действиеToolStripMenuItem
            // 
            this.действиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выводМассиваToolStripMenuItem,
            this.кЖивотнымToolStripMenuItem,
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
            this.выводМассиваToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выводМассиваToolStripMenuItem.Text = "Вывод массива";
            this.выводМассиваToolStripMenuItem.Click += new System.EventHandler(this.выводМассиваToolStripMenuItem_Click);
            // 
            // кЖивотнымToolStripMenuItem
            // 
            this.кЖивотнымToolStripMenuItem.Name = "кЖивотнымToolStripMenuItem";
            this.кЖивотнымToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кЖивотнымToolStripMenuItem.Text = "К животным";
            this.кЖивотнымToolStripMenuItem.Click += new System.EventHandler(this.кЖивотнымToolStripMenuItem_Click);
            // 
            // кПтицамToolStripMenuItem
            // 
            this.кПтицамToolStripMenuItem.Name = "кПтицамToolStripMenuItem";
            this.кПтицамToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кПтицамToolStripMenuItem.Text = "К птицам";
            this.кПтицамToolStripMenuItem.Click += new System.EventHandler(this.кПтицамToolStripMenuItem_Click);
            // 
            // кПарнокопытнымToolStripMenuItem
            // 
            this.кПарнокопытнымToolStripMenuItem.Name = "кПарнокопытнымToolStripMenuItem";
            this.кПарнокопытнымToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кПарнокопытнымToolStripMenuItem.Text = "К парнокопытным";
            this.кПарнокопытнымToolStripMenuItem.Click += new System.EventHandler(this.кПарнокопытнымToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 222);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод массива";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(418, 197);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // кЧасти2ToolStripMenuItem
            // 
            this.кЧасти2ToolStripMenuItem.Name = "кЧасти2ToolStripMenuItem";
            this.кЧасти2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кЧасти2ToolStripMenuItem.Text = "К части 2";
            this.кЧасти2ToolStripMenuItem.Click += new System.EventHandler(this.КЧасти2ToolStripMenuItem_Click);
            // 
            // Mammals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mammals";
            this.Text = "Mammals";
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
        private System.Windows.Forms.Button BTMammalCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBMammalWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMammalName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBIncubationPeriod;
        private System.Windows.Forms.TextBox TBMaxAge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кЖивотнымToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кПтицамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кПарнокопытнымToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводМассиваToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem кЧасти2ToolStripMenuItem;
    }
}