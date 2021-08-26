using System;


namespace SockPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //To use this program, simply replace the "sockbasket" string with your desired string
            Pairinator.SockTypes("AA");
            Pairinator.NumberOfSockTypes("AA");
            Pairinator.CountPairs("AA");

            Pairinator.SockTypes("ABABC");
            Pairinator.NumberOfSockTypes("ABABC");
            Pairinator.CountPairs("ABABC");

            Pairinator.SockTypes("CABBACCC");
            Pairinator.NumberOfSockTypes("CABBACCC");
            Pairinator.CountPairs("CABBACCC");

            Pairinator.SockTypes("KJDQWASZXCFDREWQASZXCFDREWAHKSLJFBJADKLKJ12345678900987654566548790763457689UIHJGFGJKJJDCXTEMPT");
            Pairinator.NumberOfSockTypes("KJDQWASZXCFDREWQASZXCFDREWAHKSLJFBJADKLKJ12345678900987654566548790763457689UIHJGFGJKJJDCXTEMPT");
            Pairinator.CountPairs("KJDQWASZXCFDREWQASZXCFDREWAHKSLJFBJADKLKJ12345678900987654566548790763457689UIHJGFGJKJJDCXTEMPT");
        }
    }
}
