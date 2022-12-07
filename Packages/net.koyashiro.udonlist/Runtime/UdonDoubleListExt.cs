namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonDoubleListExt
    {
        public static int Capacity(this UdonDoubleList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonDoubleList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonDoubleList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonDoubleList list, int count)
        {
            UdonList.SetCount(list.AsObjectArray(), count);
        }

        public static double GetItem(this UdonDoubleList list, int index)
        {
            return UdonList.GetItem<double>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonDoubleList list, int index, double item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonDoubleList list, double item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonDoubleList list, double[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonDoubleList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonDoubleList list, double item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonDoubleList list, double[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonDoubleList list, int index, double[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonDoubleList list, double[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonDoubleList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonDoubleList GetRange(this UdonDoubleList list, int index, int count)
        {
            return (UdonDoubleList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonDoubleList Slice(this UdonDoubleList list, int start, int length)
        {
            return (UdonDoubleList)(object)UdonList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonDoubleList list, double item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonDoubleList list, double item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonDoubleList list, double item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonDoubleList list, int index, double item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonDoubleList list, int index, double[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonDoubleList list, double item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonDoubleList list, double item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonDoubleList list, double item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonDoubleList list, double item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonDoubleList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonDoubleList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonDoubleList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonDoubleList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonDoubleList list)
        {
            UdonList.Sort<double>(list.AsObjectArray());
        }

        public static void Sort(this UdonDoubleList list, int index, int count)
        {
            UdonList.Sort<double>(list.AsObjectArray(), index, count);
        }

        public static double[] ToArray(this UdonDoubleList list)
        {
            return UdonList.ToArray<double>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonDoubleList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonDoubleList list)
        {
            return (object[])(object)list;
        }
    }
}
