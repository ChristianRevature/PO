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

       public Pairinator() { }


        /// <summary>
        /// This is a method that assigns the number of sock pairs from the sockbasket to a class variable
        /// </summary>
        /// <param name="sockbasket">a string of characters that represent 'socks'</param>
        public static void CountPairs(string sockbasket)
        {
            Dictionary<char, int> sockpairs = new Dictionary<char, int>();
            // pass the input string to a char array
            char[] letter = sockbasket.ToCharArray(); 
            Array.Sort(letter);
            Console.WriteLine(letter);

            //returns index numbers 

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

        /// <summary>
        /// This is a method which returns the total number of socks in a sockbasket
        /// </summary>
        /// <param name="sockbasket"></param>
        public static void NumberOfSockTypes(string sockbasket)
        {
            int types = sockbasket.Distinct().Count();
            Console.WriteLine("The number of sock types in the sock basket is:" + types);
        }

        /// <summary>
        /// This is a method which returns all the unique socks in the sockbasket
        /// </summary>
        /// <param name="sockbasket">The string of characters that represents all socks</param>
        public static void SockTypes(string sockbasket)
        {
            IEnumerable<char> typelist = sockbasket.Distinct();
           Console.WriteLine("The sock types in the sockbasket are:");
            foreach(char x in typelist)
            {
                Console.WriteLine(x);
            }
        }
    }//eoc
}//eon
