using System;

namespace Value.Math
{
    public static partial class ValueMath
    {
        #region 合计

        public static Int32 Sum(Int32[] list)
        {
            return Sum(list, 0, list.Length);
        }

        public static Int32 Sum(Int32[] list, Int32 start, Int32 end)
        {
            var sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += list[i];
            }
            return sum;
        }

        #endregion

        #region 最大值

        public static Int32 Max(out Int32 count, params Int32[] parameters)
        {
            count = 0;
            Int32 max = parameters[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] > max)
                {
                    max = parameters[i];
                    count = 1;
                }
                if (parameters[i] == max)
                    count++;
            }
            return max;
        }

        /// <summary>
        ///  获得最大值
        /// </summary>
        public static float Max(params float[] parameters)
        {
            float max = parameters[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] > max)
                    max = parameters[i];
            }
            return max;
        }

        /// <summary>
        ///  获得最大值
        /// </summary>
        public static Double Max(params Double[] parameters)
        {
            Double max = parameters[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] > max)
                    max = parameters[i];
            }
            return max;
        }

        /// <summary>
        ///  获得最大值
        /// </summary>
        public static Int32 Max(params Int32[] parameters)
        {
            Int32 max = parameters[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] > max)
                    max = parameters[i];
            }
            return max;
        }

        /// <summary>
        ///  获得最大值索引值
        /// </summary>
        public static float MaxIndex(params float[] parameters)
        {
            var max = Max(parameters);
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == max)
                    return i;
            }
            return 0;
        }

        /// <summary>
        ///  获得最大值索引值
        /// </summary>
        public static Double MaxIndex(params Double[] parameters)
        {
            var max = Max(parameters);
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == max)
                    return i;
            }
            return 0;
        }

        /// <summary>
        ///  获得最大值索引值
        /// </summary>
        public static Int32 MaxIndex(params Int32[] parameters)
        {
            var max = Max(parameters);
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == max)
                    return i;
            }
            return 0;
        }

        #endregion

        #region 最小值

        public static Int32 Min(out Int32 count, params Int32[] parameters)
        {
            count = 0;
            Int32 min = parameters[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] < min)
                {
                    min = parameters[i];
                    count = 1;
                }
                if (min == parameters[i])
                    count++;
            }
            return min;
        }

        /// <summary>
        ///  获得最小值
        /// </summary>
        public static float Min(params float[] parameters)
        {
            float min = parameters[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] < min)
                    min = parameters[i];
            }
            return min;
        }

        /// <summary>
        ///  获得最小值
        /// </summary>
        public static Double Min(params Double[] parameters)
        {
            Double min = parameters[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] < min)
                    min = parameters[i];
            }
            return min;
        }

        /// <summary>
        ///  获得最小值
        /// </summary>
        public static Int32 Min(params Int32[] parameters)
        {
            Int32 min = parameters[0];
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] < min)
                    min = parameters[i];
            }
            return min;
        }

        /// <summary>
        ///  获得最小值索引值
        /// </summary>
        public static float MinIndex(params float[] parameters)
        {
            var min = Min(parameters);
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == min)
                    return i;
            }
            return 0;
        }

        /// <summary>
        ///  获得最小值索引值
        /// </summary>
        public static Double MinIndex(params Double[] parameters)
        {
            var min = Min(parameters);
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == min)
                    return i;
            }
            return 0;
        }

        /// <summary>
        ///  获得最小值索引值
        /// </summary>
        public static Int32 MinIndex(params Int32[] parameters)
        {
            var min = Min(parameters);
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] == min)
                    return i;
            }
            return 0;
        }

        #endregion

        #region 平均数

        /// <summary>
        ///  获得平均数
        /// </summary>
        public static float Average(params float[] parameters)
        {
            Double sum = 0F;
            for (int i = 0; i < parameters.Length; i++)
            {
                sum += parameters[i];
            }

            return (float)(sum / parameters.Length);
        }

        /// <summary>
        ///  获得平均数
        /// </summary>
        public static Double Average(params Double[] parameters)
        {
            Double sum = 0D;
            for (int i = 0; i < parameters.Length; i++)
            {
                sum += parameters[i];
            }

            return sum / parameters.Length;
        }

        /// <summary>
        ///  获得平均数
        /// </summary>
        public static Int32 Average(params Int32[] parameters)
        {
            Int64 sum = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                sum += parameters[i];
            }

            return (Int32)(sum / parameters.Length);
        }

        #endregion

        #region 均方差

        /// <summary>
        ///  计算均方差
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static Double StandardDeviation(Int32[] list)
        {
            Int32 average = Average(list);
            Double result = 0.0D;
            for (int i = 0; i < list.Length; i++)
            {
                result += (list[i] - average) * (list[i] - average);
            }

            return System.Math.Sqrt(result / list.Length);
        }

        #endregion
    }
}
