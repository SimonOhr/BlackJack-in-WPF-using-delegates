using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDelegatesBlackJackData
{
    public static class StackToListConversion<T>
    {
        /// <summary>
        /// converts a stack to a list
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        public static List<T> StackToList(Stack<T> stack)
        {
            List<T> temp = new List<T>();
            for (int i = 0; i < stack.Count; i++)
            {
                temp.Add(stack.Pop());
            }
            return temp;
        }
    }
}
