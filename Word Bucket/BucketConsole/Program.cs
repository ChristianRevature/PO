using System;
using WordBucket;

namespace BucketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string shells = "she sells sea shells by the sea";
            string cheese = "the mouse jumped over the cheese";
            string fairy = "fairy dust coated the air";
            string letters = "a b c d e";
            Bucket bucket = new Bucket(shells, 10);
            bucket.Bucketinator(shells,10);
            bucket.ReadArray();
            Bucket bucket2 = new Bucket(cheese, 7);
            bucket.Bucketinator(cheese, 7);
            bucket.ReadArray();
            Bucket bucket3 = new Bucket(fairy, 20);
            bucket.Bucketinator(fairy, 20);
            bucket.ReadArray();
            Bucket bucket4 = new Bucket(letters, 2);
            bucket.Bucketinator(letters, 2);
            bucket.ReadArray();
        }
    }
}
