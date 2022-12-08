namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonIntListExt
    {
        public static int Capacity(this UdonIntList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonIntList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonIntList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static int GetItem(this UdonIntList list, int index)
        {
            return UdonList.GetItem<int>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonIntList list, int index, int item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonIntList list, int item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonIntList list, int[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonIntList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonIntList list, int item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonIntList list, int[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonIntList list, int index, int[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonIntList list, int[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static UdonIntList GetRange(this UdonIntList list, int index, int count)
        {
            return (UdonIntList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf(this UdonIntList list, int item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonIntList list, int item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonIntList list, int item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonIntList list, int index, int item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonIntList list, int index, int[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonIntList list, int item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonIntList list, int item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonIntList list, int item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonIntList list, int item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonIntList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonIntList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonIntList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonIntList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonIntList list)
        {
            UdonList.Sort<int>(list.AsObjectArray());
        }

        public static void Sort(this UdonIntList list, int index, int count)
        {
            UdonList.Sort<int>(list.AsObjectArray(), index, count);
        }

        public static int[] ToArray(this UdonIntList list)
        {
            return UdonList.ToArray<int>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonIntList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonIntList list)
        {
            return (object[])(object)list;
        }
    }
}
