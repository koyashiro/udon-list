namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonDecimalListExt
    {
        public static int Capacity(this UdonDecimalList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonDecimalList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonDecimalList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static decimal GetItem(this UdonDecimalList list, int index)
        {
            return UdonList.GetItem<decimal>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonDecimalList list, int index, decimal item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonDecimalList list, decimal item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonDecimalList list, decimal[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonDecimalList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonDecimalList list, decimal item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonDecimalList list, decimal[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonDecimalList list, int index, decimal[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonDecimalList list, decimal[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static UdonDecimalList GetRange(this UdonDecimalList list, int index, int count)
        {
            return (UdonDecimalList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf(this UdonDecimalList list, decimal item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonDecimalList list, decimal item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonDecimalList list, decimal item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonDecimalList list, int index, decimal item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonDecimalList list, int index, decimal[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonDecimalList list, decimal item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonDecimalList list, decimal item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonDecimalList list, decimal item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonDecimalList list, decimal item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonDecimalList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonDecimalList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonDecimalList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonDecimalList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonDecimalList list)
        {
            UdonList.Sort<decimal>(list.AsObjectArray());
        }

        public static void Sort(this UdonDecimalList list, int index, int count)
        {
            UdonList.Sort<decimal>(list.AsObjectArray(), index, count);
        }

        public static decimal[] ToArray(this UdonDecimalList list)
        {
            return UdonList.ToArray<decimal>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonDecimalList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonDecimalList list)
        {
            return (object[])(object)list;
        }
    }
}
