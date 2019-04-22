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
            this.BTOutput = new System.Windows.Forms.Button();
            this.BTSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элементы массива";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTSort);
            this.groupBox2.Controls.Add(this.BTOutput);
            this.groupBox2.Location = new System.Drawing.Point(299, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 256);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия с массивом";
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
            // BTSort
            // 
            this.BTSort.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.BTSort.Location = new System.Drawing.Point(6, 67);
            this.BTSort.Name = "BTSort";
            this.BTSort.Size = new System.Drawing.Size(136, 42);
            this.BTSort.TabIndex = 1;
            this.BTSort.Text = "Отсортировать";
            this.BTSort.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Output";
            this.Text = "Output";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TBOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTSort;
        private System.Windows.Forms.Button BTOutput;
    }
}