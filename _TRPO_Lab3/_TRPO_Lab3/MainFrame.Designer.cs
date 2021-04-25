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
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.labelError = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBoxSP = new System.Windows.Forms.ComboBox();
            this.comboBoxNationality = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSNF = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxDestCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxDegree = new System.Windows.Forms.ComboBox();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxExp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxProf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBoxRedBox = new System.Windows.Forms.TextBox();
            this.comboBoxRedList = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRedact = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewEmi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCommonAge = new System.Windows.Forms.Label();
            this.labelMostPCountry = new System.Windows.Forms.Label();
            this.chartCountry = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAge = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.buttonDBAdd = new System.Windows.Forms.Button();
            this.comboBoxDBList = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDBAddField = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridViewDBTable = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl3);
            this.tabPage1.Controls.Add(this.dataGridViewEmi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Эмиграция";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(519, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(260, 400);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.labelError);
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.Controls.Add(this.Add);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(252, 374);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Добавление";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(7, 333);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(49, 13);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "$OnError";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(-4, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(260, 330);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBoxSP);
            this.tabPage3.Controls.Add(this.comboBoxNationality);
            this.tabPage3.Controls.Add(this.comboBoxSex);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxAge);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBoxSNF);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(252, 304);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Личные данные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBoxSP
            // 
            this.comboBoxSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSP.FormattingEnabled = true;
            this.comboBoxSP.Location = new System.Drawing.Point(6, 175);
            this.comboBoxSP.Name = "comboBoxSP";
            this.comboBoxSP.Size = new System.Drawing.Size(240, 21);
            this.comboBoxSP.TabIndex = 12;
            // 
            // comboBoxNationality
            // 
            this.comboBoxNationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNationality.FormattingEnabled = true;
            this.comboBoxNationality.Location = new System.Drawing.Point(6, 135);
            this.comboBoxNationality.Name = "comboBoxNationality";
            this.comboBoxNationality.Size = new System.Drawing.Size(240, 21);
            this.comboBoxNationality.TabIndex = 11;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(6, 96);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(240, 21);
            this.comboBoxSex.TabIndex = 10;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Национальность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Гендер";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(6, 58);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(240, 20);
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
            this.textBoxSNF.Size = new System.Drawing.Size(240, 20);
            this.textBoxSNF.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBoxDestCountry);
            this.tabPage4.Controls.Add(this.comboBoxDegree);
            this.tabPage4.Controls.Add(this.comboBoxEducation);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBoxExp);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.textBoxProf);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(252, 304);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Остальное";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBoxDestCountry
            // 
            this.comboBoxDestCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestCountry.FormattingEnabled = true;
            this.comboBoxDestCountry.Location = new System.Drawing.Point(6, 175);
            this.comboBoxDestCountry.Name = "comboBoxDestCountry";
            this.comboBoxDestCountry.Size = new System.Drawing.Size(240, 21);
            this.comboBoxDestCountry.TabIndex = 21;
            // 
            // comboBoxDegree
            // 
            this.comboBoxDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDegree.FormattingEnabled = true;
            this.comboBoxDegree.Location = new System.Drawing.Point(6, 136);
            this.comboBoxDegree.Name = "comboBoxDegree";
            this.comboBoxDegree.Size = new System.Drawing.Size(240, 21);
            this.comboBoxDegree.TabIndex = 20;
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Location = new System.Drawing.Point(6, 19);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(240, 21);
            this.comboBoxEducation.TabIndex = 19;
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
            this.textBoxExp.Size = new System.Drawing.Size(240, 20);
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
            this.textBoxProf.Size = new System.Drawing.Size(240, 20);
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
            this.Add.Location = new System.Drawing.Point(6, 349);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(240, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBoxRedBox);
            this.tabPage6.Controls.Add(this.comboBoxRedList);
            this.tabPage6.Controls.Add(this.buttonDelete);
            this.tabPage6.Controls.Add(this.buttonRedact);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(252, 374);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Редактировать/Удалить";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBoxRedBox
            // 
            this.textBoxRedBox.Location = new System.Drawing.Point(6, 19);
            this.textBoxRedBox.Name = "textBoxRedBox";
            this.textBoxRedBox.Size = new System.Drawing.Size(240, 20);
            this.textBoxRedBox.TabIndex = 12;
            // 
            // comboBoxRedList
            // 
            this.comboBoxRedList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRedList.FormattingEnabled = true;
            this.comboBoxRedList.Location = new System.Drawing.Point(6, 19);
            this.comboBoxRedList.Name = "comboBoxRedList";
            this.comboBoxRedList.Size = new System.Drawing.Size(240, 21);
            this.comboBoxRedList.TabIndex = 11;
            // 
            // buttonDelete
            // 
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(6, 316);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(240, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRedact
            // 
            this.buttonRedact.Location = new System.Drawing.Point(6, 345);
            this.buttonRedact.Name = "buttonRedact";
            this.buttonRedact.Size = new System.Drawing.Size(240, 23);
            this.buttonRedact.TabIndex = 5;
            this.buttonRedact.Text = "Редактировать";
            this.buttonRedact.UseVisualStyleBackColor = true;
            this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Выберите запись в списке и действие";
            // 
            // dataGridViewEmi
            // 
            this.dataGridViewEmi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmi.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmi.Name = "dataGridViewEmi";
            this.dataGridViewEmi.Size = new System.Drawing.Size(517, 400);
            this.dataGridViewEmi.TabIndex = 0;
            this.dataGridViewEmi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmi_CellClick);
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
            this.tabPage2.Size = new System.Drawing.Size(778, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отчет";
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
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridViewDBTable);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.buttonDBAdd);
            this.tabPage7.Controls.Add(this.comboBoxDBList);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.textBoxDBAddField);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(778, 400);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Справочник";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonDBAdd
            // 
            this.buttonDBAdd.Location = new System.Drawing.Point(6, 89);
            this.buttonDBAdd.Name = "buttonDBAdd";
            this.buttonDBAdd.Size = new System.Drawing.Size(240, 23);
            this.buttonDBAdd.TabIndex = 16;
            this.buttonDBAdd.Text = "Добавить";
            this.buttonDBAdd.UseVisualStyleBackColor = true;
            this.buttonDBAdd.Click += new System.EventHandler(this.buttonDBAdd_Click);
            // 
            // comboBoxDBList
            // 
            this.comboBoxDBList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDBList.FormattingEnabled = true;
            this.comboBoxDBList.Items.AddRange(new object[] {
            "Страна",
            "Гендер",
            "Национальность",
            "Семейное положение",
            "Образование",
            "Научная степень"});
            this.comboBoxDBList.Location = new System.Drawing.Point(6, 62);
            this.comboBoxDBList.Name = "comboBoxDBList";
            this.comboBoxDBList.Size = new System.Drawing.Size(240, 21);
            this.comboBoxDBList.TabIndex = 15;
            this.comboBoxDBList.SelectedIndexChanged += new System.EventHandler(this.comboBoxDBList_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Значение";
            // 
            // textBoxDBAddField
            // 
            this.textBoxDBAddField.Location = new System.Drawing.Point(6, 23);
            this.textBoxDBAddField.Name = "textBoxDBAddField";
            this.textBoxDBAddField.Size = new System.Drawing.Size(240, 20);
            this.textBoxDBAddField.TabIndex = 13;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(778, 400);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Помощь";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Таблица";
            // 
            // dataGridViewDBTable
            // 
            this.dataGridViewDBTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBTable.Location = new System.Drawing.Point(252, 0);
            this.dataGridViewDBTable.Name = "dataGridViewDBTable";
            this.dataGridViewDBTable.Size = new System.Drawing.Size(526, 400);
            this.dataGridViewDBTable.TabIndex = 18;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 445);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainFrame";
            this.Text = "Emigrants";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAge)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBTable)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProf;
        private System.Windows.Forms.TextBox textBoxExp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCountry;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAge;
        private System.Windows.Forms.Label labelCommonAge;
        private System.Windows.Forms.Label labelMostPCountry;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRedact;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxSP;
        private System.Windows.Forms.ComboBox comboBoxNationality;
        private System.Windows.Forms.ComboBox comboBoxDestCountry;
        private System.Windows.Forms.ComboBox comboBoxDegree;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDBAddField;
        private System.Windows.Forms.ComboBox comboBoxDBList;
        private System.Windows.Forms.Button buttonDBAdd;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox textBoxRedBox;
        private System.Windows.Forms.ComboBox comboBoxRedList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridViewDBTable;
    }
}

