namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonCharListExt
    {
        public static int Capacity(this UdonCharList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonCharList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonCharList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonCharList list, int count)
        {
            UdonList.SetCount(list.AsObjectArray(), count);
        }

        public static char GetItem(this UdonCharList list, int index)
        {
            return UdonList.GetItem<char>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonCharList list, int index, char item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonCharList list, char item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonCharList list, char[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonCharList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonCharList list, char item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonCharList list, char[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonCharList list, int index, char[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonCharList list, char[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonCharList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonCharList GetRange(this UdonCharList list, int index, int count)
        {
            return (UdonCharList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonCharList Slice(this UdonCharList list, int start, int length)
        {
            return (UdonCharList)(object)UdonList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonCharList list, char item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonCharList list, char item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonCharList list, char item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonCharList list, int index, char item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonCharList list, int index, char[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonCharList list, char item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonCharList list, char item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonCharList list, char item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonCharList list, char item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonCharList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonCharList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static char[] ToArray(this UdonCharList list)
        {
            return UdonList.ToArray<char>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonCharList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonCharList list)
        {
            return (object[])(object)list;
        }
    }
}
