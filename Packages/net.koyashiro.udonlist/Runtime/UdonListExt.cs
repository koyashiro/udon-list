using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    public static class UdonObjectListExt
    {
        public static int Capacity(this UdonObjectList list)
        {
            return UdonGenericList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonObjectList list, int capacity)
        {
            UdonGenericList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonObjectList list)
        {
            return UdonGenericList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonObjectList list, int count)
        {
            UdonGenericList.SetCount(list.AsObjectArray(), count);
        }

        public static object GetItem(this UdonObjectList list, int index)
        {
            return UdonGenericList.GetItem<object>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonObjectList list, int index, object item)
        {
            UdonGenericList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonObjectList list, object item)
        {
            UdonGenericList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonObjectList list, object[] collection)
        {
            UdonGenericList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonObjectList list)
        {
            UdonGenericList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonObjectList list, object item)
        {
            return UdonGenericList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonObjectList list, object[] array)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonObjectList list, int index, object[] array, int arrayIndex, int count)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonObjectList list, object[] array, int arrayIndex)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonObjectList list, int capacity)
        {
            return UdonGenericList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonObjectList GetRange(this UdonObjectList list, int index, int count)
        {
            return (UdonObjectList)(object)UdonGenericList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonObjectList Slice(this UdonObjectList list, int start, int length)
        {
            return (UdonObjectList)(object)UdonGenericList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonObjectList list, object item)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonObjectList list, object item, int index)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonObjectList list, object item, int index, int count)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonObjectList list, int index, object item)
        {
            UdonGenericList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonObjectList list, int index, object[] collection)
        {
            UdonGenericList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonObjectList list, object item)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonObjectList list, object item, int index)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonObjectList list, object item, int index, int count)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonObjectList list, object item)
        {
            return UdonGenericList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonObjectList list, int index)
        {
            UdonGenericList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonObjectList list, int index, int count)
        {
            UdonGenericList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static object[] ToArray(this UdonObjectList list)
        {
            return UdonGenericList.ToArray<object>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonObjectList list)
        {
            UdonGenericList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonObjectList list)
        {
            return (object[])(object)list;
        }
    }
}
