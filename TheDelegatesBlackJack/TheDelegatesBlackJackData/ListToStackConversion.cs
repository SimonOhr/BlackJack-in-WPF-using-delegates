using System.Collections.Generic;


namespace TheDelegatesBlackJackData
{
    public static class ListToStackConversion<T>
    {
        public static Stack<T> ListToStack(List<T> list)
        {
            Stack<T> temp = new Stack<T>();
            for (int i = 0; i < list.Count; i++)            
                temp.Push(list[i]);
            
            return temp;
        }
    }
}
