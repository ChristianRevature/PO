using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockPairs
{
    public class Pairinator
    {
        public string sockbasket { get; set; }
        private int _Pairs;

        public int Pairs
        {
            get { return _Pairs; }
            set { _Pairs = value; }
        }

       public  Pairinator() { }


        /// <summary>
        /// This is a method that assigns the number of sock pairs from the sockbasket to a class variable
        /// </summary>
        /// <param name="sockbasket">a string of characters that represent 'socks'</param>
        public void CountPairs(string sockbasket)
        {
            // pass the input string to a char array
            char[] letter = sockbasket.ToCharArray(); 
            Array.Sort(letter);

            Dictionary<char, int> sockpairs = new Dictionary<char, int>();
            // make X number of collections of each unique sock type

            //foreach(char x in letter)
            //{

            //}

            ////for each unique socktype in the sockbasket, count the number of times they appear in the sockbasket 
            //foreach(char type in sockbasket)
            //{
                
            //    sockpairs.Add( type,  count);
            //}
        }

        public static void NumberOfSockTypes(string sockbasket)
        {
            int types = sockbasket.Distinct().Count();
            Console.WriteLine("The number of sock types in the sock basket is:" + types);
        }

    }//eoc
}//eon
