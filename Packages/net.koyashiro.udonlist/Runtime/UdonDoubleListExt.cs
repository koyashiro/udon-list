namespace Koyashiro.UdonList
{
    public static class UdonDoubleListExt
    {
        public static int GetCapacity(this UdonDoubleList list)
        {
            return list.AsUdonList().GetCapacity();
        }

        public static void SetCapacity(this UdonDoubleList list, int capacity)
        {
            list.AsUdonList().SetCapacity(capacity);
        }

        public static int GetCount(this UdonDoubleList list)
        {
            return list.AsUdonList().GetCount();
        }

        public static double GetItem(this UdonDoubleList list, int index)
        {
            return (double)list.AsUdonList().GetItem(index);
        }

        public static void SetItem(this UdonDoubleList list, int index, double item)
        {
            list.AsUdonList().SetItem(index, item);
        }

        public static void Add(this UdonDoubleList list, double item)
        {
            list.AsUdonList().Add(item);
        }

        public static void AddRange(this UdonDoubleList list, double[] collection)
        {
            list.AsUdonList().AddRange((object[])(object)collection);
        }

        public static void Clear(this UdonDoubleList list)
        {
            list.AsUdonList().Clear();
        }

        public static bool Contains(this UdonDoubleList list, double item)
        {
            return list.AsUdonList().Contains(item);
        }

        public static void CopyTo(this UdonDoubleList list, int index, double[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = list.GetItem(index + i);
            }
        }

        public static void CopyTo(this UdonDoubleList list, double[] array)
        {
            list.CopyTo(0, array, 0, list.GetCount());
        }

        public static void CopyTo(this UdonDoubleList list, double[] array, int arrayIndex)
        {
            list.CopyTo(0, array, 0, arrayIndex);
        }

        public static int EnsureCapacity(this UdonDoubleList list, int capacity)
        {
            return list.AsUdonList().EnsureCapacity(capacity);
        }

        public static UdonDoubleList GetRange(this UdonCharList list, int index, int count)
        {
            return (UdonDoubleList)(object)list.AsUdonList().GetRange(index, count);
        }

        public static int IndexOf(this UdonDoubleList list, double item)
        {
            return list.AsUdonList().IndexOf(item);
        }

        public static int IndexOf(this UdonDoubleList list, double item, int index)
        {
            return list.AsUdonList().IndexOf(item, index);
        }

        public static int IndexOf(this UdonDoubleList list, double item, int index, int count)
        {
            return list.AsUdonList().IndexOf(item, index, count);
        }

        public static void Insert(this UdonDoubleList list, int index, double item)
        {
            list.AsUdonList().Insert(index, item);
        }

        public static void InsertRange(this UdonDoubleList list, int index, double[] items)
        {
            list.AsUdonList().InsertRange(index, (object[])(object)items);
        }

        public static int LastIndexOf(this UdonDoubleList list, double item)
        {
            return list.AsUdonList().LastIndexOf(item);
        }

        public static int LastIndexOf(this UdonDoubleList list, double item, int index)
        {
            return list.AsUdonList().LastIndexOf(item, index);
        }

        public static int LastIndexOf(this UdonDoubleList list, double item, int index, int count)
        {
            return list.AsUdonList().LastIndexOf(item, index, count);
        }

        public static bool Remove(this UdonDoubleList list, double item)
        {
            return list.AsUdonList().Remove(item);
        }

        public static void RemoveAt(this UdonDoubleList list, int index)
        {
            list.AsUdonList().RemoveAt(index);
        }

        public static void RemoveRange(this UdonDoubleList list, int index, int count)
        {
            list.AsUdonList().RemoveRange(index, count);
        }

        public static double[] ToArray(this UdonDoubleList list)
        {
            var array = new double[list.GetCount()];
            list.CopyTo(array);
            return array;
        }

        public static UdonList AsUdonList(this UdonDoubleList list)
        {
            return ((UdonList)(object)(list));
        }
    }
}
