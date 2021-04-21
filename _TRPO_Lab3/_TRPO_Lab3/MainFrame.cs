using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace _TRPO_Lab3
{

    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            chartAge.Series.Clear();
            chartCountry.Series.Clear();
            labelError.Text = String.Empty;
            labelCommonAge.Text = String.Empty;
            labelMostPCountry.Text = String.Empty;
            dataGridViewEmi.Columns.Add("_SNF", "ФИО");
            dataGridViewEmi.Columns.Add("_Age", "Возраст");
            dataGridViewEmi.Columns.Add("_Sex", "Пол");
            dataGridViewEmi.Columns.Add("_Nationality", "Национальность");
            dataGridViewEmi.Columns.Add("_Status", "СП");
            dataGridViewEmi.Columns.Add("_Edu", "Образование");
            dataGridViewEmi.Columns.Add("_Prof", "Профессия");
            dataGridViewEmi.Columns.Add("_Exp", "Стаж");
            dataGridViewEmi.Columns.Add("_Degree", "Ученая степень");
            dataGridViewEmi.Columns.Add("_DestCountry", "Страна назначения");
            dataGridViewEmi.Columns.Add("_ID", "Personal_ID");
        }

        List<string> Countries()
        {
            List<string> Temp = new List<string>();
            foreach(Emigrant i in Database.Emigrants)
            {
                if(!Temp.Contains(i.EDCountry))
                {
                    Temp.Add(i.EDCountry);
                }
            }
            return Temp;
        }

        int FindIndex(int[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                if(Array[i] == Array.Max())
                {
                    return i;
                }
            }
            return -1;
        }

        string FindMajorityAge()
        {
            int[] Ages = new int[3];
            string[] AgeStrings = new string[3] {"20-30", "31-40", "41+"};
            foreach(Emigrant i in Database.Emigrants)
            {
                if (i.EAge >= 20 && i.EAge <= 30)
                {
                    Ages[0]++;
                }
                if(i.EAge >= 31 && i.EAge <= 40)
                {
                    Ages[1]++;
                }
                if(i.EAge >= 41)
                {
                    Ages[2]++;
                }
            }
            return AgeStrings[FindIndex(Ages)];
        }

        string FindMajorityCountries()
        {
            int[] CountriesAmount = new int[Countries().Count];
            for(int i = 0; i < Countries().Count; i++)
            {
                foreach(Emigrant emigrant in Database.Emigrants)
                {
                    if(emigrant.EDCountry == Countries()[i])
                    {
                        CountriesAmount[i]++;
                    }
                }
            }
            return Countries()[FindIndex(CountriesAmount)];
        }

        void MostCalculate()
        {
            labelCommonAge.Text = $"Самая частая возр. группа: {FindMajorityAge()} лет";
            labelMostPCountry.Text = $"Самая популярная страна: {FindMajorityCountries()}";
        }

        void ChartWorks()
        {
            chartAge.Series.Clear();
            chartAge.Titles.Clear();
            chartCountry.Series.Clear();
            chartCountry.Titles.Clear();
            chartAge.Titles.Add("Возрастные группы");
            chartCountry.Titles.Add("Страны эмиграции");
            int[] CountriesCount = new int[Countries().Count];
            chartAge.Series.Add(new Series("Age")
            {
                ChartType = SeriesChartType.Pie
            });
            chartCountry.Series.Add(new Series("Country")
            {
                ChartType = SeriesChartType.Pie
            });
            int Current = 0;
            foreach(string i in Countries())
            {
                foreach(Emigrant j in Database.Emigrants)
                {
                    if(j.EDCountry == i)
                    {
                        CountriesCount[Current]++;
                    }
                }
                Current++;
            }
            chartCountry.Series["Country"].Points.DataBindXY(Countries(), CountriesCount);
            // 20-30 / 31-40 / 41+
            int[] AgesCount = new int[3];
            foreach(Emigrant i in Database.Emigrants)
            {
                if(i.EAge >= 20 && i.EAge <= 30)
                {
                    AgesCount[0]++;
                }
                if(i.EAge >= 31 && i.EAge <= 40)
                {
                    AgesCount[1]++;
                }
                if(i.EAge >= 41)
                {
                    AgesCount[2]++;
                }
            }
            chartAge.Series["Age"].Points.DataBindXY(new string[] { AgesCount[0] != 0 ? "20-30" : null, AgesCount[1] != 0 ? "31-40" : null, AgesCount[2] != 0 ? "41+" : null }, AgesCount);
        }

        void UpdateGridData()
        {
            dataGridViewEmi.Rows.Clear();
            foreach(Emigrant i in Database.Emigrants)
            {
                dataGridViewEmi.Rows.Add(i.ESNF, i.EAge, i.ESex, i.ENationality, i.EStatus, i.EEdu, i.EProf, i.EExp, i.EDegree, i.EDCountry, i.EID);
            }
        }

        void UpdateLists()
        {
            comboBoxDestCountry.Items.Clear();
            comboBoxSex.Items.Clear();
            comboBoxNationality.Items.Clear();
            comboBoxSP.Items.Clear();
            comboBoxEducation.Items.Clear();
            comboBoxDegree.Items.Clear();
            comboBoxDestCountry.Items.AddRange(Database.Countries.ToArray());
            comboBoxSex.Items.AddRange(Database.Gender.ToArray());
            comboBoxNationality.Items.AddRange(Database.Nationality.ToArray());
            comboBoxSP.Items.AddRange(Database.SP.ToArray());
            comboBoxEducation.Items.AddRange(Database.Education.ToArray());
            comboBoxDegree.Items.AddRange(Database.Degrees.ToArray());
        }

        Emigrant AddNew(Emigrant emigrant)
        {
            emigrant.ESNF = textBoxSNF.Text;
            emigrant.EAge = Convert.ToInt32(textBoxAge.Text);
            emigrant.ESex = (string)comboBoxSex.SelectedItem;
            emigrant.ENationality = (string)comboBoxNationality.SelectedItem;
            emigrant.EStatus = (string)comboBoxSP.SelectedItem;
            emigrant.EEdu = (string)comboBoxEducation.SelectedItem;
            emigrant.EProf = textBoxProf.Text;
            emigrant.EExp = Convert.ToInt32(textBoxExp.Text);
            emigrant.EDegree = (string)comboBoxDegree.SelectedItem;
            emigrant.EDCountry = (string)comboBoxDestCountry.SelectedItem;
            emigrant.EID = Database.PersonalID;
            return emigrant;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Database.Emigrants.Add(AddNew(new Emigrant()));
                Database.PersonalID++;
                UpdateGridData();
                MostCalculate();
                ChartWorks();
            }
            catch(FormatException)
            {
                labelError.Text = "Ошибка формата данных!";
            }
        }

        private void buttonRedact_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int Index = 0;
            foreach(Emigrant i in Database.Emigrants)
            {
                if (i.EID == (int)dataGridViewEmi.SelectedRows[0].Cells[10].Value)
                {
                    break;
                }
                Index++;
            }
            Database.Emigrants.RemoveAt(Index);
            UpdateGridData();
        }

        private void buttonDBAdd_Click(object sender, EventArgs e)
        {
            switch(comboBoxDBList.SelectedIndex)
            {
                case 0:
                    Database.Countries.Add(textBoxDBAddField.Text);
                    break;
                case 1:
                    Database.Gender.Add(textBoxDBAddField.Text);
                    break;
                case 2:
                    Database.Nationality.Add(textBoxDBAddField.Text);
                    break;
                case 3:
                    Database.SP.Add(textBoxDBAddField.Text);
                    break;
                case 4:
                    Database.Education.Add(textBoxDBAddField.Text);
                    break;
                case 5:
                    Database.Degrees.Add(textBoxDBAddField.Text);
                    break;
            }
            UpdateLists();
        }
    }
}
