using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nerdery_coinsorter.Models
{
    public class Coin
    {
        public string CoinType { get; set; }
        public decimal CoinValue { get; set; }
        //public int CoinCount { get; set; }


        //public static int GetCoinCount(int coin_total, int[] coin_array)
        //{
        //    const int MAX = Int32.MaxValue;

        //    int[] coin_count = new int[coin_total + 1];
        //    coin_count[0] = 0;

        //    for (int x = 1; x <= coin_total; x++)
        //    {
        //        int total = MAX;
        //        for(int y = 0; y < coin_array.Length; y++)
        //        {
        //            if (x - coin_array[y] >= 0 && total > coin_count[x - coin_array[y]])
        //                total = coin_count[x - coin_array[y]];
        //        }
        //        if (total < MAX)
        //            coin_array[x] = total + 1;
        //        else
        //            coin_array[x] = MAX;
        //    }
        //    return coin_count[coin_total];
        //}
        //===============================Testing=================//
        //private static void SampleRun(String TestCase, int coin_total,int[] coin_array, int Answer)
        //{
        //    Console.Write(TestCase + " starting: ");

        //    if (GetCoinCount(coin_total, coin_array) == Answer)
        //        Console.Write("Success.\n");
        //    else
        //        Console.Write("Error.\n");
        //}
        //private static void Case1()
        //{ 
        //    int[] coin_array = { 1, 3, 9, 10 };
        //    int coin_total = 15;
        //    int Answer = 3;

        //    SampleRun("Case1", coin_total, coin_array, Answer);
        //}
        //static void Main(string[] args)
        //{
        //    Case1();
        //}

    }
}