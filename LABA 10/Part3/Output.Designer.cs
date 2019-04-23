namespace LABA_10
{
    partial class Output
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
            this.TBOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTSort = new System.Windows.Forms.Button();
            this.BTOutput = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBOutput
            // 
            this.TBOutput.Location = new System.Drawing.Point(6, 19);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.Size = new System.Drawing.Size(256, 401);
            this.TBOutput.TabIndex = 0;
            this.TBOutput.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 407);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы массива";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTSort);
            this.groupBox2.Controls.Add(this.BTOutput);
            this.groupBox2.Location = new System.Drawing.Point(304, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 256);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия с массивом";
            // 
            // BTSort
            // 
            this.BTSort.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTSort.Location = new System.Drawing.Point(6, 67);
            this.BTSort.Name = "BTSort";
            this.BTSort.Size = new System.Drawing.Size(136, 42);
            this.BTSort.TabIndex = 1;
            this.BTSort.Text = "Отсортировать";
            this.BTSort.UseVisualStyleBackColor = true;
            this.BTSort.Click += new System.EventHandler(this.BTSort_Click);
            // 
            // BTOutput
            // 
            this.BTOutput.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTOutput.Location = new System.Drawing.Point(6, 19);
            this.BTOutput.Name = "BTOutput";
            this.BTOutput.Size = new System.Drawing.Size(136, 42);
            this.BTOutput.TabIndex = 0;
            this.BTOutput.Text = "Вывести";
            this.BTOutput.UseVisualStyleBackColor = true;
            this.BTOutput.Click += new System.EventHandler(this.BTOutput_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискЭлементаToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // поискЭлементаToolStripMenuItem
            // 
            this.поискЭлементаToolStripMenuItem.Name = "поискЭлементаToolStripMenuItem";
            this.поискЭлементаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискЭлементаToolStripMenuItem.Text = "Поиск элемента";
            this.поискЭлементаToolStripMenuItem.Click += new System.EventHandler(this.ПоискЭлементаToolStripMenuItem_Click);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Output";
            this.Text = "Output";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TBOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTSort;
        private System.Windows.Forms.Button BTOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискЭлементаToolStripMenuItem;
    }
}