using System.Collections.Generic;

namespace DrawingSim.Common
{
    public static class Extensions
    {
        public static List<T> AddFluent<T>(this List<T> list, T item)
        {
            list.Add(item);
            return list;
        }
        public static List<T> AddRangeFluent<T>(this List<T> list, IEnumerable<T> item)
        {
            list.AddRange(item);
            return list;
        }
    }
}
