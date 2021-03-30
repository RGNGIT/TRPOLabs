using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace _TRPO_Lab2
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear(); // Очистка чарта
            dataGridView1.Columns.Add("_index", "Index"); // Создание колонок списка значений
            dataGridView1.Columns.Add("_value", "Value");
        }

        double dLambda = 0.5f; // Лямбда
        List<double> NumList = new List<double>(); // Список значений
        
        private void FrameMain(object sender, EventArgs e)
        {
            try
            {
                vFillList(); // Метод заполнения массива
                NumList.Sort(); // Метод сортировки
                vMakePattern(); // Метод создания новой последовательности
                vShowData(); // Метод вывода данных на экран
                vFillChart(); // Метод построения гистограммы
                vCalc(); // Метод вычисления среднего значения и дисперсии
            }
            catch(Exception)
            {
                vReset();
                FrameMain(sender, e);
            }
        }

        void vReset()
        {
            NumList.Clear();
            chart1.Series.Clear();
            dataGridView1.Rows.Clear();
        }

        void vCalc()
        {
            double Average = 0; // Объявление переменных для поиска среднего значения и дисперсии
            double Dispersion = 0;
            foreach (var i in NumList)
            {
                Average += i; // Сложение всех элеентов списка
            }
            foreach (var i in NumList)
            {
                Dispersion += Math.Pow(i - (Average / NumList.Count), 2); // Поиск числителя дроби формулы вычисления дисперсии
            }
            Dispersion /= NumList.Count - 1; // Вычисление дисперсии
            label1.Text = $"Среднее значение: {Average / NumList.Count} Дисперсия: {Dispersion}"; // Вычисление среднего значения и вывод на экран
        }

        void vFillChart()
        {
            List<int> Counters = new List<int>();
            List<string> Intervals = new List<string>();
            double Min = NumList[0], Max = NumList[NumList.Count - 1];
            double Interval = (Max - Min) / 10;
            double Left = Min, Right = Left + Interval;
            int Counter = 0;
            for(int i = 0; i < 10; i++)
            {
                Intervals.Add($"~{Math.Round(Left, 3)}-{Math.Round(Right, 3)}");
                foreach(double j in NumList)
                {
                    if(j >= Left && j <= Right)
                    {
                        Counter++;
                    }
                }
                Left += Interval;
                Right += Interval;
                Counters.Add(Counter);
                Counter = 0;
            }
            chart1.Series.Add(new Series("ExpRange")); // Создание нового чарта гистограммы и ее заполнение
            chart1.Series["ExpRange"].Points.DataBindXY(Intervals, Counters);
        }

        void vMakePattern()
        {
            for (int i = 1; i < NumList.Count; i++)
            {
                NumList[i] -= NumList[i - 1]; // Создание новой последовательности по формуле Xi - Xi-1 для каждого элемента
            }
        }

        void vShowData()
        {
            int i = 1;
            foreach (var num in NumList)
            {
                dataGridView1.Rows.Add(i, num); // Вывод значений на экран
                i++;
            }
        }

        void vFillList()
        {
            int rnd;
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                rnd = random.Next(0, 100); // Заполнение массива случайными значениями
                NumList.Add(dGenValue(rnd));
            }
        }

        double dGenValue(int Random) => dLambda * Math.Exp(dLambda * -1 * Random); // Формула экспоненциального распределения

    }
}
