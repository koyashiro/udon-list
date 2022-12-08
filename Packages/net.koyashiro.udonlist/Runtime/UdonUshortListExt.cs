namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonUshortListExt
    {
        public static int Capacity(this UdonUshortList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonUshortList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonUshortList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static ushort GetItem(this UdonUshortList list, int index)
        {
            return UdonList.GetItem<ushort>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonUshortList list, int index, ushort item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonUshortList list, ushort item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonUshortList list, ushort[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonUshortList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonUshortList list, ushort item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonUshortList list, ushort[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonUshortList list, int index, ushort[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonUshortList list, ushort[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonUshortList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonUshortList GetRange(this UdonUshortList list, int index, int count)
        {
            return (UdonUshortList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonUshortList Slice(this UdonUshortList list, int start, int length)
        {
            return (UdonUshortList)(object)UdonList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonUshortList list, ushort item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonUshortList list, ushort item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonUshortList list, ushort item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonUshortList list, int index, ushort item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonUshortList list, int index, ushort[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonUshortList list, ushort item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonUshortList list, ushort item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonUshortList list, ushort item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonUshortList list, ushort item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonUshortList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonUshortList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonUshortList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonUshortList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonUshortList list)
        {
            UdonList.Sort<ushort>(list.AsObjectArray());
        }

        public static void Sort(this UdonUshortList list, int index, int count)
        {
            UdonList.Sort<ushort>(list.AsObjectArray(), index, count);
        }

        public static ushort[] ToArray(this UdonUshortList list)
        {
            return UdonList.ToArray<ushort>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonUshortList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonUshortList list)
        {
            return (object[])(object)list;
        }
    }
}
