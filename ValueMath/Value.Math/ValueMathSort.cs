using System;
using Value.Math.Infrastructure;

namespace Value.Math
{
    public static partial class ValueMath
    {
        /// <summary>
        ///  插入算法
        /// </summary>
        /// <typeparam name="T">实现IComparable接口的对象</typeparam>
        /// <param name="list">对象数组</param>
        /// <param name="mode">排序的顺序</param>
        public static void InsertSort<T>(T[] list, SortMode mode) where T : IComparable
        {
            if (mode == SortMode.Ascending)
            {
                for (int i = 1; i < list.Length; i++)
                {
                    if (list[i - 1].CompareTo(list[i]) > 0)
                    {
                        T temp = list[i];
                        Int32 j = i;
                        // 与取出的temp值比较 比他大的向后移动
                        while (j > 0 && list[j - 1].CompareTo(temp) > 0)
                        {
                            list[j] = list[j - 1];
                            j--;
                        }
                        list[j] = temp;
                    }
                }
            }
            else if (mode == SortMode.Descending)
            {
                for (int i = 1; i < list.Length; i++)
                {
                    if (list[i - 1].CompareTo(list[i]) < 0)
                    {
                        T temp = list[i];
                        Int32 j = i;
                        // 与取出的temp值比较 比他小的向后移动
                        while (j > 0 && list[j - 1].CompareTo(temp) < 0)
                        {
                            list[j] = list[j - 1];
                            j--;
                        }
                        list[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        ///  插入算法
        /// </summary>
        /// <typeparam name="T">需排序的对象类型</typeparam>
        /// <param name="list">需排序的数组对象</param>
        /// <param name="sortField">对象需排序的字段</param>
        /// <param name="mode">排序的顺序</param>
        public static void InsertSort<T>(T[] list, String sortField, SortMode mode)
        {
            System.Reflection.PropertyInfo propertInfo = null;
            try
            {
                propertInfo = typeof(T).GetProperty(sortField);
                if (propertInfo == null) throw new InvalidOperationException("该对象不存在'" + sortField + "'属性");

                if (mode == SortMode.Ascending)
                {
                    for (int i = 1; i < list.Length; i++)
                    {
                        Object vi = propertInfo.GetValue(list[i], null);
                        if (((IComparable)propertInfo.GetValue(list[i - 1], null)).CompareTo(vi) > 0)
                        {
                            T temp = list[i];
                            Int32 j = i;

                            while (j > 0 && ((IComparable)propertInfo.GetValue(list[j - 1], null)).CompareTo(vi) > 0)
                            {
                                list[j] = list[j - 1];
                                j--;
                            }
                            list[j] = temp;
                        }
                    }
                }
                else if (mode == SortMode.Descending)
                {
                    for (int i = 1; i < list.Length; i++)
                    {
                        Object vi = propertInfo.GetValue(list[i], null);
                        if (((IComparable)propertInfo.GetValue(list[i - 1], null)).CompareTo(vi) < 0)
                        {
                            T temp = list[i];
                            Int32 j = i;
                            while (j > 0 && ((IComparable)propertInfo.GetValue(list[j - 1], null)).CompareTo(vi) < 0)
                            {
                                list[j] = list[j - 1];
                                j--;
                            }
                            list[j] = temp;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (propertInfo != null)
                    propertInfo = null;
            }
        }
    }
}
