namespace LABA_10
{
    partial class Search
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
            this.BTTriggerSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BTTriggerSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBWeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "кг";
            // 
            // BTTriggerSearch
            // 
            this.BTTriggerSearch.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTTriggerSearch.Location = new System.Drawing.Point(92, 85);
            this.BTTriggerSearch.Name = "BTTriggerSearch";
            this.BTTriggerSearch.Size = new System.Drawing.Size(111, 28);
            this.BTTriggerSearch.TabIndex = 4;
            this.BTTriggerSearch.Text = "Найти";
            this.BTTriggerSearch.UseVisualStyleBackColor = true;
            this.BTTriggerSearch.Click += new System.EventHandler(this.BTTriggerSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес";
            // 
            // TBWeight
            // 
            this.TBWeight.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBWeight.Location = new System.Drawing.Point(92, 52);
            this.TBWeight.Name = "TBWeight";
            this.TBWeight.Size = new System.Drawing.Size(112, 27);
            this.TBWeight.TabIndex = 2;
            this.TBWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBWeight_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.TBName.Location = new System.Drawing.Point(93, 19);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(287, 27);
            this.TBName.TabIndex = 0;
            this.TBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBName_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 225);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найденный элемент";
            // 
            // TBOutput
            // 
            this.TBOutput.Location = new System.Drawing.Point(10, 20);
            this.TBOutput.Name = "TBOutput";
            this.TBOutput.ReadOnly = true;
            this.TBOutput.Size = new System.Drawing.Size(370, 199);
            this.TBOutput.TabIndex = 0;
            this.TBOutput.Text = "";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTTriggerSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox TBOutput;
    }
}