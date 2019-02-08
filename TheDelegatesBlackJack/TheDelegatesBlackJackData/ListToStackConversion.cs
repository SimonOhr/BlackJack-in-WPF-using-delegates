using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDelegatesBlackJackData
{
    public static class ListToStackConversion<T>
    {
        public static Stack<T> ListToStack(List<T> list)
        {
            Stack<T> temp = new Stack<T>();
            for (int i = 0; i < list.Count; i++)
            {
                temp.Push(list[i]);
            }
            return temp;
        }
    }
}
