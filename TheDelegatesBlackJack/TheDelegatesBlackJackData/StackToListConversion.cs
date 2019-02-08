using System.Collections.Generic;

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
                temp.Add(stack.Pop());
            
            return temp;
        }
    }
}
