namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonShortListExt
    {
        public static int Capacity(this UdonShortList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonShortList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonShortList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static short GetItem(this UdonShortList list, int index)
        {
            return UdonList.GetItem<short>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonShortList list, int index, short item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonShortList list, short item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonShortList list, short[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonShortList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonShortList list, short item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonShortList list, short[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonShortList list, int index, short[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonShortList list, short[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static UdonShortList GetRange(this UdonShortList list, int index, int count)
        {
            return (UdonShortList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf(this UdonShortList list, short item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonShortList list, short item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonShortList list, short item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonShortList list, int index, short item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonShortList list, int index, short[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonShortList list, short item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonShortList list, short item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonShortList list, short item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonShortList list, short item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonShortList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonShortList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonShortList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonShortList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonShortList list)
        {
            UdonList.Sort<short>(list.AsObjectArray());
        }

        public static void Sort(this UdonShortList list, int index, int count)
        {
            UdonList.Sort<short>(list.AsObjectArray(), index, count);
        }

        public static short[] ToArray(this UdonShortList list)
        {
            return UdonList.ToArray<short>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonShortList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonShortList list)
        {
            return (object[])(object)list;
        }
    }
}
