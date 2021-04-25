using System.Collections.Generic;

namespace _TRPO_Lab3
{
    public static class Database
    {

        public static int PersonalID = 0; // Счетчик персональных идешников

        public static List<Emigrant> Emigrants = new List<Emigrant>(); // База эмигрантов

        public static List<string> Countries = new List<string>(); // База стран

        public static List<string> Gender = new List<string>(); // База гендеров

        public static List<string> Nationality = new List<string>(); // База национальностей

        public static List<string> SP = new List<string>(); // База семейного положения

        public static List<string> Education = new List<string>(); // База образований

        public static List<string> Degrees = new List<string>(); // База ученых степеней

    }
}
 