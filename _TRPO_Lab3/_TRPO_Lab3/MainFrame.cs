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
            Emigrants = new List<Emigrant>();
        }

        List<Emigrant> Emigrants;

        List<string> Countries()
        {
            List<string> Temp = new List<string>();
            foreach(Emigrant i in Emigrants)
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
            foreach(Emigrant i in Emigrants)
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
                foreach(Emigrant emigrant in Emigrants)
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
                foreach(Emigrant j in Emigrants)
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
            foreach(Emigrant i in Emigrants)
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
            foreach(Emigrant i in Emigrants)
            {
                dataGridViewEmi.Rows.Add(i.ESNF, i.EAge, i.ESex, i.ENationality, i.EStatus, i.EEdu, i.EProf, i.EExp, i.EDegree, i.EDCountry);
            }
        }

        Emigrant AddNew(Emigrant emigrant)
        {
            emigrant.ESNF = textBoxSNF.Text;
            emigrant.EAge = Convert.ToInt32(textBoxAge.Text);
            emigrant.ESex = textBoxSex.Text;
            emigrant.ENationality = textBoxNation.Text;
            emigrant.EStatus = textBoxStatus.Text;
            emigrant.EEdu = textBoxEdu.Text;
            emigrant.EProf = textBoxProf.Text;
            emigrant.EExp = Convert.ToInt32(textBoxExp.Text);
            emigrant.EDegree = textBoxDegree.Text;
            emigrant.EDCountry = textBoxDestCountry.Text;
            return emigrant;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Emigrants.Add(AddNew(new Emigrant()));
                UpdateGridData();
                MostCalculate();
                ChartWorks();
            }
            catch(FormatException)
            {
                labelError.Text = "Ошибка формата данных!";
            }
        }

    }
}
