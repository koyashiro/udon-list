namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonObjectListExt
    {
        public static int Capacity(this UdonObjectList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonObjectList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonObjectList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonObjectList list, int count)
        {
            UdonList.SetCount(list.AsObjectArray(), count);
        }

        public static object GetItem(this UdonObjectList list, int index)
        {
            return UdonList.GetItem<object>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonObjectList list, int index, object item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonObjectList list, object item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonObjectList list, object[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonObjectList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonObjectList list, object item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonObjectList list, object[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonObjectList list, int index, object[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonObjectList list, object[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonObjectList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonObjectList GetRange(this UdonObjectList list, int index, int count)
        {
            return (UdonObjectList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonObjectList Slice(this UdonObjectList list, int start, int length)
        {
            return (UdonObjectList)(object)UdonList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonObjectList list, object item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonObjectList list, object item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonObjectList list, object item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonObjectList list, int index, object item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonObjectList list, int index, object[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonObjectList list, object item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonObjectList list, object item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonObjectList list, object item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonObjectList list, object item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonObjectList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonObjectList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonObjectList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonObjectList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonObjectList list)
        {
            UdonException.UdonException.ThrowNotSupportedException();
        }

        public static void Sort(this UdonObjectList list, int index, int count)
        {
            UdonException.UdonException.ThrowNotSupportedException();
        }

        public static object[] ToArray(this UdonObjectList list)
        {
            return UdonList.ToArray<object>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonObjectList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonObjectList list)
        {
            return (object[])(object)list;
        }
    }
}
