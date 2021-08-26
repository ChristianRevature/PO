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
            char[] sortedsocks = sockbasket.ToCharArray(); 
            Array.Sort(sortedsocks);
            Console.WriteLine(sortedsocks);


            int pairs = 0;
            int i = 0;
            while(i < sortedsocks.Length - 1)
            {
                //if index i and index i+1 are the same, add to the count and count by 2's
                if (sortedsocks[i] == sortedsocks[i + 1]){
                    pairs++;
                    i=i + 2;
                }
                //if index i and index i+1 are not the same, then move over to next index
                try
                {
                    if (sortedsocks[i] != sortedsocks[i + 1] && sortedsocks[i] != sortedsocks.Length - 1)
                    {
                        i++;
                        sockpairs.Add(sortedsocks[i], pairs);
                    }
                }
                catch(IndexOutOfRangeException )
                {
                    Console.WriteLine("IndexOutOfRangeException was handled");
                }
                //finally
                //{
                //    foreach (var key in sockpairs)
                //    {
                //        foreach (var value in sockpairs)
                //        {
                //            Console.WriteLine($"Sock Type {key} has {value} pairs");
                //        }
                //    }
                //}
                
            }


            Console.WriteLine($"The total number of sockpairs is {pairs}");
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
