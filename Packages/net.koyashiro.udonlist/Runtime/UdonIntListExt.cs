using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    public static class UdonIntListExt
    {
        public static int Capacity(this UdonIntList list)
        {
            return UdonGenericList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonIntList list, int capacity)
        {
            UdonGenericList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonIntList list)
        {
            return UdonGenericList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonIntList list, int count)
        {
            UdonGenericList.SetCount(list.AsObjectArray(), count);
        }

        public static int GetItem(this UdonIntList list, int index)
        {
            return UdonGenericList.GetItem<int>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonIntList list, int index, int item)
        {
            UdonGenericList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonIntList list, int item)
        {
            UdonGenericList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonIntList list, int[] collection)
        {
            UdonGenericList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonIntList list)
        {
            UdonGenericList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonIntList list, int item)
        {
            return UdonGenericList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonIntList list, int[] array)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonIntList list, int index, int[] array, int arrayIndex, int count)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonIntList list, int[] array, int arrayIndex)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonIntList list, int capacity)
        {
            return UdonGenericList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonIntList GetRange(this UdonIntList list, int index, int count)
        {
            return (UdonIntList)(object)UdonGenericList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonIntList Slice(this UdonIntList list, int start, int length)
        {
            return (UdonIntList)(object)UdonGenericList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonIntList list, int item)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonIntList list, int item, int index)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonIntList list, int item, int index, int count)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonIntList list, int index, int item)
        {
            UdonGenericList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonIntList list, int index, int[] collection)
        {
            UdonGenericList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonIntList list, int item)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonIntList list, int item, int index)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonIntList list, int item, int index, int count)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonIntList list, int item)
        {
            return UdonGenericList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonIntList list, int index)
        {
            UdonGenericList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonIntList list, int index, int count)
        {
            UdonGenericList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static int[] ToArray(this UdonIntList list)
        {
            return UdonGenericList.ToArray<int>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonIntList list)
        {
            UdonGenericList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonIntList list)
        {
            return (object[])(object)list;
        }
    }
}
