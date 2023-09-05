namespace ChartExamples
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fastLineChartType1 = new WinFormsChartSamples.FastLineChartType();
            this.descriptiveStatistics1 = new WinFormsChartSamples.DescriptiveStatistics();
            this.excelData1 = new WinFormsChartSamples.ExcelData();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fastLineChartType1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.descriptiveStatistics1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.excelData1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fastLineChartType1
            // 
            this.fastLineChartType1.BackColor = System.Drawing.Color.White;
            this.fastLineChartType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastLineChartType1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastLineChartType1.Location = new System.Drawing.Point(3, 3);
            this.fastLineChartType1.Name = "fastLineChartType1";
            this.fastLineChartType1.Size = new System.Drawing.Size(786, 418);
            this.fastLineChartType1.TabIndex = 0;
            // 
            // descriptiveStatistics1
            // 
            this.descriptiveStatistics1.BackColor = System.Drawing.Color.White;
            this.descriptiveStatistics1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptiveStatistics1.Font = new System.Drawing.Font("Verdana", 9F);
            this.descriptiveStatistics1.Location = new System.Drawing.Point(3, 3);
            this.descriptiveStatistics1.Name = "descriptiveStatistics1";
            this.descriptiveStatistics1.Size = new System.Drawing.Size(786, 418);
            this.descriptiveStatistics1.TabIndex = 0;
            // 
            // excelData1
            // 
            this.excelData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excelData1.Font = new System.Drawing.Font("Verdana", 9F);
            this.excelData1.Location = new System.Drawing.Point(3, 3);
            this.excelData1.Name = "excelData1";
            this.excelData1.Size = new System.Drawing.Size(786, 418);
            this.excelData1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private WinFormsChartSamples.FastLineChartType fastLineChartType1;
        private WinFormsChartSamples.DescriptiveStatistics descriptiveStatistics1;
        private WinFormsChartSamples.ExcelData excelData1;
    }
}

