namespace Koyashiro.UdonList.Internal
{
    using Koyashiro.UdonException;

    public static class Array
    {
        public static int IndexOf(object[] array, object value, int startIndex, int count)
        {
            return System.Array.IndexOf(array, value, startIndex, count);

            // if (array == null)
            // {
            //     UdonException.ThrowArgumentNullException(nameof(array));
            // }
            // 
            // if ((uint)startIndex > (uint)array.Length)
            // {
            //     UdonException.ThrowArgumentOutOfRangeException();
            // }
            // 
            // if ((uint)count > (uint)(array.Length - startIndex))
            // {
            //     UdonException.ThrowArgumentOutOfRangeException();
            // }
            // 
            // for (var i = startIndex; i < startIndex + count; i++)
            // {
            //     if (object.Equals(array[i], value))
            //     {
            //         return i;
            //     }
            // }
            // 
            // return -1;
        }

        public static int LastIndexOf(object[] array, object value, int startIndex, int count)
        {
            return System.Array.LastIndexOf(array, value, startIndex, count);

            // if (array == null)
            // {
            //     UdonException.ThrowArgumentNullException(nameof(array));
            // }
            // 
            // if (array.Length == 0)
            // {
            //     if (startIndex != -1 && startIndex != 0)
            //     {
            //         UdonException.ThrowArgumentOutOfRangeException();
            //     }
            // 
            //     if (count != 0)
            //     {
            //         UdonException.ThrowArgumentOutOfRangeException();
            //     }
            // 
            //     return -1;
            // }
            // 
            // if ((uint)startIndex >= (uint)array.Length)
            // {
            //     UdonException.ThrowArgumentOutOfRangeException();
            // }
            // 
            // if (count < 0 || startIndex - count + 1 < 0)
            // {
            //     UdonException.ThrowArgumentOutOfRangeException();
            // }
            // 
            // for (var i = 0; i < count; i++)
            // {
            //     if (object.Equals(array[startIndex - i], value))
            //     {
            //         return i;
            //     }
            // }
            // 
            // return -1;
        }

        public static void Copy<TS, TD>(TS[] sourceArray, TD[] destinationArray, int length)
        {
            if (typeof(TS) == typeof(TD))
            {
                System.Array.Copy(sourceArray, destinationArray, length);
                return;
            }

            Copy(sourceArray, 0, destinationArray, 0, length);
        }

        public static void Copy<TS, TD>(TS[] sourceArray, int sourceIndex, TD[] destinationArray, int destinationIndex, int length)
        {
            if (typeof(TS) == typeof(TD))
            {
                System.Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
                return;
            }

            if (sourceArray == null)
            {
                UdonException.ThrowArgumentNullException(nameof(sourceArray));
            }

            if (sourceArray == null)
            {
                UdonException.ThrowArgumentNullException(nameof(sourceArray));
            }

            for (var i = 0; i < length; i++)
            {
                destinationArray[destinationIndex + i] = (TD)(object)(sourceArray[sourceIndex + i]);
            }
        }
    }
}
