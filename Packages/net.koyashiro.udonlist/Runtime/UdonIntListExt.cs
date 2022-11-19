namespace Koyashiro.UdonList
{
    public static class UdonIntListExt
    {
        public static int GetCapacity(this UdonIntList list)
        {
            return list.AsUdonList().GetCapacity();
        }

        public static void SetCapacity(this UdonIntList list, int capacity)
        {
            list.AsUdonList().SetCapacity(capacity);
        }

        public static int GetCount(this UdonIntList list)
        {
            return list.AsUdonList().GetCount();
        }

        public static int GetItem(this UdonIntList list, int index)
        {
            return (int)list.AsUdonList().GetItem(index);
        }

        public static void SetItem(this UdonIntList list, int index, int item)
        {
            list.AsUdonList().SetItem(index, item);
        }

        public static void Add(this UdonIntList list, int item)
        {
            list.AsUdonList().Add(item);
        }

        public static void AddRange(this UdonIntList list, int[] collection)
        {
            list.AsUdonList().AddRange((object[])(object)collection);
        }

        public static void Clear(this UdonIntList list)
        {
            list.AsUdonList().Clear();
        }

        public static bool Contains(this UdonIntList list, int item)
        {
            return list.AsUdonList().Contains(item);
        }

        public static void CopyTo(this UdonIntList list, int index, int[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = list.GetItem(index + i);
            }
        }

        public static void CopyTo(this UdonIntList list, int[] array)
        {
            list.CopyTo(0, array, 0, list.GetCount());
        }

        public static void CopyTo(this UdonIntList list, int[] array, int arrayIndex)
        {
            list.CopyTo(0, array, 0, arrayIndex);
        }

        public static int EnsureCapacity(this UdonIntList list, int capacity)
        {
            return list.AsUdonList().EnsureCapacity(capacity);
        }

        public static UdonIntList GetRange(this UdonCharList list, int index, int count)
        {
            return (UdonIntList)(object)list.AsUdonList().GetRange(index, count);
        }

        public static int IndexOf(this UdonIntList list, int item)
        {
            return list.AsUdonList().IndexOf(item);
        }

        public static int IndexOf(this UdonIntList list, int item, int index)
        {
            return list.AsUdonList().IndexOf(item, index);
        }

        public static int IndexOf(this UdonIntList list, int item, int index, int count)
        {
            return list.AsUdonList().IndexOf(item, index, count);
        }

        public static void Insert(this UdonIntList list, int index, int item)
        {
            list.AsUdonList().Insert(index, item);
        }

        public static void InsertRange(this UdonIntList list, int index, int[] items)
        {
            list.AsUdonList().InsertRange(index, (object[])(object)items);
        }

        public static int LastIndexOf(this UdonIntList list, int item)
        {
            return list.AsUdonList().LastIndexOf(item);
        }

        public static int LastIndexOf(this UdonIntList list, int item, int index)
        {
            return list.AsUdonList().LastIndexOf(item, index);
        }

        public static int LastIndexOf(this UdonIntList list, int item, int index, int count)
        {
            return list.AsUdonList().LastIndexOf(item, index, count);
        }

        public static bool Remove(this UdonIntList list, int item)
        {
            return list.AsUdonList().Remove(item);
        }

        public static void RemoveAt(this UdonIntList list, int index)
        {
            list.AsUdonList().RemoveAt(index);
        }

        public static void RemoveRange(this UdonIntList list, int index, int count)
        {
            list.AsUdonList().RemoveRange(index, count);
        }

        public static int[] ToArray(this UdonIntList list)
        {
            var array = new int[list.GetCount()];
            list.CopyTo(array);
            return array;
        }

        public static UdonList AsUdonList(this UdonIntList list)
        {
            return ((UdonList)(object)(list));
        }
    }
}
