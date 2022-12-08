namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonGenericListExt
    {
        public static int Capacity(this UdonGenericList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonGenericList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonGenericList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static T GetItem<T>(this UdonGenericList list, int index)
        {
            return UdonList.GetItem<T>(list.AsObjectArray(), index);
        }

        public static void SetItem<T>(this UdonGenericList list, int index, T item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add<T>(this UdonGenericList list, T item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange<T>(this UdonGenericList list, T[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonGenericList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains<T>(this UdonGenericList list, T item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo<T>(this UdonGenericList list, T[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo<T>(this UdonGenericList list, int index, T[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo<T>(UdonGenericList list, T[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static UdonGenericList GetRange(this UdonGenericList list, int index, int count)
        {
            return (UdonGenericList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf(this UdonGenericList list, double item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonGenericList list, double item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonGenericList list, double item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonGenericList list, int index, double item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonGenericList list, int index, double[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonGenericList list, double item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonGenericList list, double item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonGenericList list, double item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonGenericList list, double item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonGenericList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonGenericList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonGenericList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonGenericList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonGenericList list)
        {
            UdonList.Sort<double>(list.AsObjectArray());
        }

        public static void Sort(this UdonGenericList list, int index, int count)
        {
            UdonList.Sort<double>(list.AsObjectArray(), index, count);
        }

        public static double[] ToArray(this UdonGenericList list)
        {
            return UdonList.ToArray<double>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonGenericList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonGenericList list)
        {
            return (object[])(object)list;
        }
    }
}
