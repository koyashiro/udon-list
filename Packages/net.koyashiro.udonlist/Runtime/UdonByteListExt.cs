namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonByteListExt
    {
        public static int Capacity(this UdonByteList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonByteList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonByteList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static byte GetItem(this UdonByteList list, int index)
        {
            return UdonList.GetItem<byte>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonByteList list, int index, byte item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonByteList list, byte item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonByteList list, byte[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonByteList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonByteList list, byte item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonByteList list, byte[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonByteList list, int index, byte[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonByteList list, byte[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonByteList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonByteList GetRange(this UdonByteList list, int index, int count)
        {
            return (UdonByteList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonByteList Slice(this UdonByteList list, int start, int length)
        {
            return (UdonByteList)(object)UdonList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonByteList list, byte item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonByteList list, byte item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonByteList list, byte item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonByteList list, int index, byte item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonByteList list, int index, byte[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonByteList list, byte item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonByteList list, byte item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonByteList list, byte item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonByteList list, byte item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonByteList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonByteList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonByteList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonByteList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonByteList list)
        {
            UdonList.Sort<byte>(list.AsObjectArray());
        }

        public static void Sort(this UdonByteList list, int index, int count)
        {
            UdonList.Sort<byte>(list.AsObjectArray(), index, count);
        }

        public static byte[] ToArray(this UdonByteList list)
        {
            return UdonList.ToArray<byte>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonByteList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonByteList list)
        {
            return (object[])(object)list;
        }
    }
}
