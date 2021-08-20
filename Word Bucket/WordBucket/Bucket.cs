using System;
using System.Linq;

namespace WordBucket
{
    public class Bucket
    {
        //properties
        private string _phrase;

        public string phrase
        {
            get { return _phrase; }
            set { _phrase = value; }
        }

        private string[] _bucketArray;

        public string[]  bucketArray
        {
            get { return _bucketArray; }
            set { _bucketArray = value; }
        }

        private int  _bucketSize;

        public int   bucketSize
        {
            get { return _bucketSize; }
            set { _bucketSize = value; }
        }
        //constructors
        public Bucket(string input, int size)
        {
            this.phrase = input;
            this.bucketSize = size;
        }
        public Bucket() { }
        /// <summary>
        /// This is a method that bucketizes a phrase.
        /// </summary>
        /// <param name="phrase">An array of phrase</param>
        /// <returns></returns>
        public string[] Bucketinator(string input, int size)
        {
            input = input.Trim();//this trims any whitespaces
            string[] stringArray = input.Split();//creates string array
            this.bucketArray = new string[stringArray.Length];

            string s = "";
            int counter = 0;
            int i = 0;
            while (counter < input.Length)
            {
                //this block of logic says 'go through each letter from the input phrase, and as long as the length is less than bucketsize, keep adding a letter to the bucket'
                if ((s + " " + input[counter]).Trim().Length <= size)
                {
                    s += " ";
                    s += input[counter];
                    s = s.Trim();
                    counter++;
                    continue;
                }
                //this says 'whenever "s" is not the original value, then put that value into the corresponding index of stringArray'
                if (s != "")
                {

                    this.bucketArray[i] = s;
                    i++;
                    s = "";
                    continue;
                }
                if (s == "")
                {
                    break;
                }

                if (s != "")
                {
                    this.bucketArray[i] = s;
                }

                if (counter != stringArray.Length)
                {
                    return new string[0];
                }

                this.bucketArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                
            }
            return this.bucketArray;
        }

        /// <summary>
        /// This read the array
        /// </summary>
        public void ReadArray()
        {
            foreach (string x in this.bucketArray)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
        }
    }//eoc
}//eon
