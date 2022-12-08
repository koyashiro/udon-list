namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonLongListExt
    {
        public static int Capacity(this UdonLongList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonLongList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonLongList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static long GetItem(this UdonLongList list, int index)
        {
            return UdonList.GetItem<long>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonLongList list, int index, long item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonLongList list, long item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonLongList list, long[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonLongList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonLongList list, long item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonLongList list, long[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonLongList list, int index, long[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonLongList list, long[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonLongList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonLongList GetRange(this UdonLongList list, int index, int count)
        {
            return (UdonLongList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf(this UdonLongList list, long item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonLongList list, long item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonLongList list, long item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonLongList list, int index, long item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonLongList list, int index, long[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonLongList list, long item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonLongList list, long item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonLongList list, long item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonLongList list, long item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonLongList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonLongList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonLongList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonLongList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonLongList list)
        {
            UdonList.Sort<long>(list.AsObjectArray());
        }

        public static void Sort(this UdonLongList list, int index, int count)
        {
            UdonList.Sort<long>(list.AsObjectArray(), index, count);
        }

        public static long[] ToArray(this UdonLongList list)
        {
            return UdonList.ToArray<long>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonLongList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonLongList list)
        {
            return (object[])(object)list;
        }
    }
}
