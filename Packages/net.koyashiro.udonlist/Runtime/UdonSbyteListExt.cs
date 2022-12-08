namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonSbyteListExt
    {
        public static int Capacity(this UdonSbyteList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonSbyteList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonSbyteList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static sbyte GetItem(this UdonSbyteList list, int index)
        {
            return UdonList.GetItem<sbyte>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonSbyteList list, int index, sbyte item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonSbyteList list, sbyte item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonSbyteList list, sbyte[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonSbyteList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonSbyteList list, sbyte item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonSbyteList list, sbyte[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonSbyteList list, int index, sbyte[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonSbyteList list, sbyte[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonSbyteList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonSbyteList GetRange(this UdonSbyteList list, int index, int count)
        {
            return (UdonSbyteList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf(this UdonSbyteList list, sbyte item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonSbyteList list, sbyte item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonSbyteList list, sbyte item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonSbyteList list, int index, sbyte item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonSbyteList list, int index, sbyte[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonSbyteList list, sbyte item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonSbyteList list, sbyte item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonSbyteList list, sbyte item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonSbyteList list, sbyte item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonSbyteList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonSbyteList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonSbyteList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonSbyteList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonSbyteList list)
        {
            UdonList.Sort<sbyte>(list.AsObjectArray());
        }

        public static void Sort(this UdonSbyteList list, int index, int count)
        {
            UdonList.Sort<sbyte>(list.AsObjectArray(), index, count);
        }

        public static sbyte[] ToArray(this UdonSbyteList list)
        {
            return UdonList.ToArray<sbyte>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonSbyteList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonSbyteList list)
        {
            return (object[])(object)list;
        }
    }
}
