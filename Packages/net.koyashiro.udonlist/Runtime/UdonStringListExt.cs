namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonStringListExt
    {
        public static int Capacity(this UdonStringList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonStringList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonStringList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static string GetItem(this UdonStringList list, int index)
        {
            return UdonList.GetItem<string>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonStringList list, int index, string item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonStringList list, string item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonStringList list, string[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonStringList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonStringList list, string item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonStringList list, string[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonStringList list, int index, string[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonStringList list, string[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static UdonStringList GetRange(this UdonStringList list, int index, int count)
        {
            return (UdonStringList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf(this UdonStringList list, string item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonStringList list, string item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonStringList list, string item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonStringList list, int index, string item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonStringList list, int index, string[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonStringList list, string item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonStringList list, string item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonStringList list, string item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonStringList list, string item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonStringList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonStringList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonStringList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonStringList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonStringList list)
        {
            UdonList.Sort<string>(list.AsObjectArray());
        }

        public static void Sort(this UdonStringList list, int index, int count)
        {
            UdonList.Sort<string>(list.AsObjectArray(), index, count);
        }

        public static string[] ToArray(this UdonStringList list)
        {
            return UdonList.ToArray<string>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonStringList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonStringList list)
        {
            return (object[])(object)list;
        }
    }
}
