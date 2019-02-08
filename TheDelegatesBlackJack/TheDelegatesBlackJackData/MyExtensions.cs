using System;
using System.Collections.Generic;

namespace TheDelegatesBlackJackData
{
    public static class MyExtensions
    {
        /// <summary>
        /// Fisher-Yates shuffle technique
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();         
            int n = list.Count;
            while (n > 1)
            {               
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
