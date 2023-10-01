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
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.fastLineChartType1 = new WinFormsChartSamples.FastLineChartType();
            this.descriptiveStatistics1 = new WinFormsChartSamples.DescriptiveStatistics();
            this.excelData1 = new WinFormsChartSamples.ExcelData();
            this.usingMarkers1 = new WinFormsChartSamples.UsingMarkers();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.fastLineChartType1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "データ追加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.usingMarkers1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // fastLineChartType1
            // 
            this.fastLineChartType1.BackColor = System.Drawing.Color.White;
            this.fastLineChartType1.ChartTitle = "Two series with 20000 points each";
            this.fastLineChartType1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fastLineChartType1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastLineChartType1.Location = new System.Drawing.Point(3, 3);
            this.fastLineChartType1.Name = "fastLineChartType1";
            this.fastLineChartType1.Size = new System.Drawing.Size(786, 287);
            this.fastLineChartType1.TabIndex = 0;
            // 
            // descriptiveStatistics1
            // 
            this.descriptiveStatistics1.BackColor = System.Drawing.Color.White;
            this.descriptiveStatistics1.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptiveStatistics1.Font = new System.Drawing.Font("Verdana", 9F);
            this.descriptiveStatistics1.Location = new System.Drawing.Point(3, 3);
            this.descriptiveStatistics1.Name = "descriptiveStatistics1";
            this.descriptiveStatistics1.Size = new System.Drawing.Size(786, 292);
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
            // usingMarkers1
            // 
            this.usingMarkers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usingMarkers1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usingMarkers1.Location = new System.Drawing.Point(3, 3);
            this.usingMarkers1.Name = "usingMarkers1";
            this.usingMarkers1.Size = new System.Drawing.Size(786, 418);
            this.usingMarkers1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "データ消去";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "データ消去";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "データ追加";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.tabPage4.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage4;
        private WinFormsChartSamples.UsingMarkers usingMarkers1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

