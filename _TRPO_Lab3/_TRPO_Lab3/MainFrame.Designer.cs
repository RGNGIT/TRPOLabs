namespace _TRPO_Lab3
{
    partial class MainFrame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewEmi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCommonAge = new System.Windows.Forms.Label();
            this.labelMostPCountry = new System.Windows.Forms.Label();
            this.chartCountry = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSNF = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxDestCountry = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDegree = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxExp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEdu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewEmi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmi
            // 
            this.dataGridViewEmi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmi.Name = "dataGridViewEmi";
            this.dataGridViewEmi.Size = new System.Drawing.Size(519, 400);
            this.dataGridViewEmi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelCommonAge);
            this.tabPage2.Controls.Add(this.labelMostPCountry);
            this.tabPage2.Controls.Add(this.chartCountry);
            this.tabPage2.Controls.Add(this.chartAge);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Анализ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCommonAge
            // 
            this.labelCommonAge.AutoSize = true;
            this.labelCommonAge.Location = new System.Drawing.Point(277, 26);
            this.labelCommonAge.Name = "labelCommonAge";
            this.labelCommonAge.Size = new System.Drawing.Size(96, 13);
            this.labelCommonAge.TabIndex = 3;
            this.labelCommonAge.Text = "$MostCommonAge";
            // 
            // labelMostPCountry
            // 
            this.labelMostPCountry.AutoSize = true;
            this.labelMostPCountry.Location = new System.Drawing.Point(277, 6);
            this.labelMostPCountry.Name = "labelMostPCountry";
            this.labelMostPCountry.Size = new System.Drawing.Size(108, 13);
            this.labelMostPCountry.TabIndex = 2;
            this.labelMostPCountry.Text = "$MostPopularCountry";
            // 
            // chartCountry
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCountry.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCountry.Legends.Add(legend1);
            this.chartCountry.Location = new System.Drawing.Point(6, 205);
            this.chartCountry.Name = "chartCountry";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCountry.Series.Add(series1);
            this.chartCountry.Size = new System.Drawing.Size(265, 189);
            this.chartCountry.TabIndex = 1;
            this.chartCountry.Text = "chart2";
            // 
            // chartAge
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAge.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAge.Legends.Add(legend2);
            this.chartAge.Location = new System.Drawing.Point(6, 6);
            this.chartAge.Name = "chartAge";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAge.Series.Add(series2);
            this.chartAge.Size = new System.Drawing.Size(265, 189);
            this.chartAge.TabIndex = 0;
            this.chartAge.Text = "chart1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(541, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(247, 385);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxStatus);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxNation);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBoxSex);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxAge);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxSNF);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(239, 359);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Личные данные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(6, 175);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(227, 20);
            this.textBoxStatus.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Семейное положение";
            // 
            // textBoxNation
            // 
            this.textBoxNation.Location = new System.Drawing.Point(6, 136);
            this.textBoxNation.Name = "textBoxNation";
            this.textBoxNation.Size = new System.Drawing.Size(227, 20);
            this.textBoxNation.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Национальность";
            // 
            // textBoxSex
            // 
            this.textBoxSex.Location = new System.Drawing.Point(6, 97);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.Size = new System.Drawing.Size(227, 20);
            this.textBoxSex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пол";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(6, 58);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(227, 20);
            this.textBoxAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Возраст";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // textBoxSNF
            // 
            this.textBoxSNF.Location = new System.Drawing.Point(6, 19);
            this.textBoxSNF.Name = "textBoxSNF";
            this.textBoxSNF.Size = new System.Drawing.Size(227, 20);
            this.textBoxSNF.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxDestCountry);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.textBoxDegree);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBoxExp);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.textBoxProf);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.textBoxEdu);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(239, 359);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Остальное";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxDestCountry
            // 
            this.textBoxDestCountry.Location = new System.Drawing.Point(6, 175);
            this.textBoxDestCountry.Name = "textBoxDestCountry";
            this.textBoxDestCountry.Size = new System.Drawing.Size(227, 20);
            this.textBoxDestCountry.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Страна назначения";
            // 
            // textBoxDegree
            // 
            this.textBoxDegree.Location = new System.Drawing.Point(6, 136);
            this.textBoxDegree.Name = "textBoxDegree";
            this.textBoxDegree.Size = new System.Drawing.Size(227, 20);
            this.textBoxDegree.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ученая степень";
            // 
            // textBoxExp
            // 
            this.textBoxExp.Location = new System.Drawing.Point(6, 97);
            this.textBoxExp.Name = "textBoxExp";
            this.textBoxExp.Size = new System.Drawing.Size(227, 20);
            this.textBoxExp.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Стаж";
            // 
            // textBoxProf
            // 
            this.textBoxProf.Location = new System.Drawing.Point(6, 58);
            this.textBoxProf.Name = "textBoxProf";
            this.textBoxProf.Size = new System.Drawing.Size(227, 20);
            this.textBoxProf.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Профессия";
            // 
            // textBoxEdu
            // 
            this.textBoxEdu.Location = new System.Drawing.Point(6, 19);
            this.textBoxEdu.Name = "textBoxEdu";
            this.textBoxEdu.Size = new System.Drawing.Size(227, 20);
            this.textBoxEdu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Образование";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(541, 415);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(247, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(541, 400);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(49, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "$OnError";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainFrame";
            this.Text = "Emigrants";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewEmi;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSNF;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEdu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProf;
        private System.Windows.Forms.TextBox textBoxExp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDegree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxDestCountry;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountry;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAge;
        private System.Windows.Forms.Label labelCommonAge;
        private System.Windows.Forms.Label labelMostPCountry;
    }
}

