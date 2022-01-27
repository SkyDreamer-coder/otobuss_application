
namespace otobus_application
{
    partial class Form4
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
            this.TabControlReport = new System.Windows.Forms.TabControl();
            this.TabCompanyReport = new System.Windows.Forms.TabPage();
            this.BtnBack = new System.Windows.Forms.Button();
            this.TxtCountComp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSumComp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAVGComp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatagridCompany = new System.Windows.Forms.DataGridView();
            this.TabDriverReport = new System.Windows.Forms.TabPage();
            this.TxtCountDriver = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSumDriver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAVGDriver = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DatagridDriver = new System.Windows.Forms.DataGridView();
            this.TabAssistantReport = new System.Windows.Forms.TabPage();
            this.TxtCountAssistant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSumAssistant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtAVGAssistant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DatagridAssistant = new System.Windows.Forms.DataGridView();
            this.TabControlReport.SuspendLayout();
            this.TabCompanyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCompany)).BeginInit();
            this.TabDriverReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridDriver)).BeginInit();
            this.TabAssistantReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridAssistant)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlReport
            // 
            this.TabControlReport.Controls.Add(this.TabCompanyReport);
            this.TabControlReport.Controls.Add(this.TabDriverReport);
            this.TabControlReport.Controls.Add(this.TabAssistantReport);
            this.TabControlReport.Location = new System.Drawing.Point(3, 3);
            this.TabControlReport.Name = "TabControlReport";
            this.TabControlReport.SelectedIndex = 0;
            this.TabControlReport.Size = new System.Drawing.Size(1133, 687);
            this.TabControlReport.TabIndex = 1;
            // 
            // TabCompanyReport
            // 
            this.TabCompanyReport.Controls.Add(this.BtnBack);
            this.TabCompanyReport.Controls.Add(this.TxtCountComp);
            this.TabCompanyReport.Controls.Add(this.label3);
            this.TabCompanyReport.Controls.Add(this.TxtSumComp);
            this.TabCompanyReport.Controls.Add(this.label2);
            this.TabCompanyReport.Controls.Add(this.TxtAVGComp);
            this.TabCompanyReport.Controls.Add(this.label1);
            this.TabCompanyReport.Controls.Add(this.DatagridCompany);
            this.TabCompanyReport.Location = new System.Drawing.Point(4, 25);
            this.TabCompanyReport.Name = "TabCompanyReport";
            this.TabCompanyReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabCompanyReport.Size = new System.Drawing.Size(1125, 658);
            this.TabCompanyReport.TabIndex = 0;
            this.TabCompanyReport.Text = "Firma Raporu";
            this.TabCompanyReport.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(705, 440);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(124, 45);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "geri çık";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // TxtCountComp
            // 
            this.TxtCountComp.Location = new System.Drawing.Point(232, 513);
            this.TxtCountComp.Name = "TxtCountComp";
            this.TxtCountComp.Size = new System.Drawing.Size(119, 22);
            this.TxtCountComp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam firma sayısı:";
            // 
            // TxtSumComp
            // 
            this.TxtSumComp.Location = new System.Drawing.Point(232, 391);
            this.TxtSumComp.Name = "TxtSumComp";
            this.TxtSumComp.Size = new System.Drawing.Size(119, 22);
            this.TxtSumComp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Firmalar Toplam Maaş:";
            // 
            // TxtAVGComp
            // 
            this.TxtAVGComp.Location = new System.Drawing.Point(232, 450);
            this.TxtAVGComp.Name = "TxtAVGComp";
            this.TxtAVGComp.Size = new System.Drawing.Size(119, 22);
            this.TxtAVGComp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ortalama Maaş:";
            // 
            // DatagridCompany
            // 
            this.DatagridCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridCompany.Location = new System.Drawing.Point(7, 6);
            this.DatagridCompany.Name = "DatagridCompany";
            this.DatagridCompany.RowHeadersWidth = 51;
            this.DatagridCompany.RowTemplate.Height = 24;
            this.DatagridCompany.Size = new System.Drawing.Size(1110, 328);
            this.DatagridCompany.TabIndex = 0;
            // 
            // TabDriverReport
            // 
            this.TabDriverReport.Controls.Add(this.TxtCountDriver);
            this.TabDriverReport.Controls.Add(this.label4);
            this.TabDriverReport.Controls.Add(this.TxtSumDriver);
            this.TabDriverReport.Controls.Add(this.label5);
            this.TabDriverReport.Controls.Add(this.TxtAVGDriver);
            this.TabDriverReport.Controls.Add(this.label6);
            this.TabDriverReport.Controls.Add(this.DatagridDriver);
            this.TabDriverReport.Location = new System.Drawing.Point(4, 25);
            this.TabDriverReport.Name = "TabDriverReport";
            this.TabDriverReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabDriverReport.Size = new System.Drawing.Size(1125, 658);
            this.TabDriverReport.TabIndex = 1;
            this.TabDriverReport.Text = "Şoför Raporu";
            this.TabDriverReport.UseVisualStyleBackColor = true;
            // 
            // TxtCountDriver
            // 
            this.TxtCountDriver.Location = new System.Drawing.Point(230, 512);
            this.TxtCountDriver.Name = "TxtCountDriver";
            this.TxtCountDriver.Size = new System.Drawing.Size(119, 22);
            this.TxtCountDriver.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Toplam şoför sayısı:";
            // 
            // TxtSumDriver
            // 
            this.TxtSumDriver.Location = new System.Drawing.Point(230, 390);
            this.TxtSumDriver.Name = "TxtSumDriver";
            this.TxtSumDriver.Size = new System.Drawing.Size(119, 22);
            this.TxtSumDriver.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şoförler Toplam Maaş:";
            // 
            // TxtAVGDriver
            // 
            this.TxtAVGDriver.Location = new System.Drawing.Point(230, 449);
            this.TxtAVGDriver.Name = "TxtAVGDriver";
            this.TxtAVGDriver.Size = new System.Drawing.Size(119, 22);
            this.TxtAVGDriver.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ortalama Maaş:";
            // 
            // DatagridDriver
            // 
            this.DatagridDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridDriver.Location = new System.Drawing.Point(6, 6);
            this.DatagridDriver.Name = "DatagridDriver";
            this.DatagridDriver.RowHeadersWidth = 51;
            this.DatagridDriver.RowTemplate.Height = 24;
            this.DatagridDriver.Size = new System.Drawing.Size(1110, 328);
            this.DatagridDriver.TabIndex = 1;
            // 
            // TabAssistantReport
            // 
            this.TabAssistantReport.Controls.Add(this.TxtCountAssistant);
            this.TabAssistantReport.Controls.Add(this.label7);
            this.TabAssistantReport.Controls.Add(this.TxtSumAssistant);
            this.TabAssistantReport.Controls.Add(this.label8);
            this.TabAssistantReport.Controls.Add(this.TxtAVGAssistant);
            this.TabAssistantReport.Controls.Add(this.label9);
            this.TabAssistantReport.Controls.Add(this.DatagridAssistant);
            this.TabAssistantReport.Location = new System.Drawing.Point(4, 25);
            this.TabAssistantReport.Name = "TabAssistantReport";
            this.TabAssistantReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabAssistantReport.Size = new System.Drawing.Size(1125, 658);
            this.TabAssistantReport.TabIndex = 2;
            this.TabAssistantReport.Text = "Muavin Raporu";
            this.TabAssistantReport.UseVisualStyleBackColor = true;
            // 
            // TxtCountAssistant
            // 
            this.TxtCountAssistant.Location = new System.Drawing.Point(269, 500);
            this.TxtCountAssistant.Name = "TxtCountAssistant";
            this.TxtCountAssistant.Size = new System.Drawing.Size(119, 22);
            this.TxtCountAssistant.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Toplam muavin sayısı:";
            // 
            // TxtSumAssistant
            // 
            this.TxtSumAssistant.Location = new System.Drawing.Point(269, 378);
            this.TxtSumAssistant.Name = "TxtSumAssistant";
            this.TxtSumAssistant.Size = new System.Drawing.Size(119, 22);
            this.TxtSumAssistant.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Muavinler Toplam Maaş:";
            // 
            // TxtAVGAssistant
            // 
            this.TxtAVGAssistant.Location = new System.Drawing.Point(269, 437);
            this.TxtAVGAssistant.Name = "TxtAVGAssistant";
            this.TxtAVGAssistant.Size = new System.Drawing.Size(119, 22);
            this.TxtAVGAssistant.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ortalama Maaş:";
            // 
            // DatagridAssistant
            // 
            this.DatagridAssistant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridAssistant.Location = new System.Drawing.Point(7, 6);
            this.DatagridAssistant.Name = "DatagridAssistant";
            this.DatagridAssistant.RowHeadersWidth = 51;
            this.DatagridAssistant.RowTemplate.Height = 24;
            this.DatagridAssistant.Size = new System.Drawing.Size(1110, 328);
            this.DatagridAssistant.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 691);
            this.Controls.Add(this.TabControlReport);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.TabControlReport.ResumeLayout(false);
            this.TabCompanyReport.ResumeLayout(false);
            this.TabCompanyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCompany)).EndInit();
            this.TabDriverReport.ResumeLayout(false);
            this.TabDriverReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridDriver)).EndInit();
            this.TabAssistantReport.ResumeLayout(false);
            this.TabAssistantReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridAssistant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlReport;
        private System.Windows.Forms.TabPage TabCompanyReport;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.TextBox TxtCountComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSumComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAVGComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DatagridCompany;
        private System.Windows.Forms.TabPage TabDriverReport;
        private System.Windows.Forms.TextBox TxtCountDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSumDriver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAVGDriver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DatagridDriver;
        private System.Windows.Forms.TabPage TabAssistantReport;
        private System.Windows.Forms.TextBox TxtCountAssistant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSumAssistant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAVGAssistant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DatagridAssistant;
    }
}