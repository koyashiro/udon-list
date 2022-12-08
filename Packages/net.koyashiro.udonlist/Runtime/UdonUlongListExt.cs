namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonUlongListExt
    {
        public static int Capacity(this UdonUlongList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonUlongList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonUlongList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static ulong GetItem(this UdonUlongList list, int index)
        {
            return UdonList.GetItem<ulong>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonUlongList list, int index, ulong item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonUlongList list, ulong item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonUlongList list, ulong[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonUlongList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonUlongList list, ulong item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonUlongList list, ulong[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonUlongList list, int index, ulong[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonUlongList list, ulong[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonUlongList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonUlongList GetRange(this UdonUlongList list, int index, int count)
        {
            return (UdonUlongList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonUlongList Slice(this UdonUlongList list, int start, int length)
        {
            return (UdonUlongList)(object)UdonList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonUlongList list, ulong item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonUlongList list, ulong item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonUlongList list, ulong item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonUlongList list, int index, ulong item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonUlongList list, int index, ulong[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonUlongList list, ulong item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonUlongList list, ulong item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonUlongList list, ulong item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonUlongList list, ulong item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonUlongList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonUlongList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonUlongList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonUlongList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonUlongList list)
        {
            UdonList.Sort<ulong>(list.AsObjectArray());
        }

        public static void Sort(this UdonUlongList list, int index, int count)
        {
            UdonList.Sort<ulong>(list.AsObjectArray(), index, count);
        }

        public static ulong[] ToArray(this UdonUlongList list)
        {
            return UdonList.ToArray<ulong>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonUlongList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonUlongList list)
        {
            return (object[])(object)list;
        }
    }
}
