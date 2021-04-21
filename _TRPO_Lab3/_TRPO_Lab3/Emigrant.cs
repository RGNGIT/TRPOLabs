using System;

namespace _TRPO_Lab3
{
    public class Emigrant
    {
        private string SNF;
        private int Age;
        private string Sex;
        private string Nationality;
        private string Status;
        private string Edu;
        private string Prof;
        private int Exp;
        private string Degree;
        private string DestCountry;

        private int ID;

        public int EID
        {
            get
            {
                return this.ID;
            }
            set
            {
                this.ID = value is int ? value : -1;
            }
        }

        public string ESNF
        {
            get
            {
                return this.SNF;
            }
            set
            {
                this.SNF = value != String.Empty ? value : null;
            }
        }

        public int EAge
        {
            get
            {
                return this.Age;
            }
            set
            {
                this.Age = value is int ? value : -1;
            }
        }

        public string ESex
        {
            get
            {
                return this.Sex;
            }
            set
            {
                this.Sex = value != String.Empty ? value : null; 
            }
        }

        public string ENationality
        {
            get
            {
                return this.Nationality;
            }
            set
            {
                this.Nationality = value != String.Empty ? value : null;
            }
        }

        public string EStatus
        {
            get
            {
                return this.Status;
            }
            set
            {
                this.Status = value != String.Empty ? value : null;
            }
        }

        public string EEdu
        {
            get
            {
                return this.Edu;
            }
            set
            {
                this.Edu = value != String.Empty ? value : null;
            }
        }

        public string EProf
        {
            get
            {
                return this.Prof;
            }
            set
            {
                this.Prof = value != String.Empty ? value : null;
            }
        }

        public int EExp
        {
            get
            {
                return this.Exp;
            }
            set
            {
                this.Exp = value is int ? value : -1;
            }
        }

        public string EDegree
        {
            get
            {
                return this.Degree;
            }
            set
            {
                this.Degree = value != String.Empty ? value : null;
            }
        }

        public string EDCountry
        {
            get
            {
                return this.DestCountry;
            }
            set
            {
                this.DestCountry = value != String.Empty ? value : null;
            }
        }

    }
}
