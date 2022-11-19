using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    public static class UdonUintListExt
    {
        public static int Capacity(this UdonUintList list)
        {
            return UdonGenericList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonUintList list, int capacity)
        {
            UdonGenericList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonUintList list)
        {
            return UdonGenericList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonUintList list, int count)
        {
            UdonGenericList.SetCount(list.AsObjectArray(), count);
        }

        public static uint GetItem(this UdonUintList list, int index)
        {
            return UdonGenericList.GetItem<uint>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonUintList list, int index, uint item)
        {
            UdonGenericList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonUintList list, uint item)
        {
            UdonGenericList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonUintList list, uint[] collection)
        {
            UdonGenericList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonUintList list)
        {
            UdonGenericList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonUintList list, uint item)
        {
            return UdonGenericList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonUintList list, uint[] array)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonUintList list, int index, uint[] array, int arrayIndex, int count)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonUintList list, uint[] array, int arrayIndex)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonUintList list, int capacity)
        {
            return UdonGenericList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonUintList GetRange(this UdonUintList list, int index, int count)
        {
            return (UdonUintList)(object)UdonGenericList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonUintList Slice(this UdonUintList list, int start, int length)
        {
            return (UdonUintList)(object)UdonGenericList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonUintList list, uint item)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonUintList list, uint item, int index)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonUintList list, uint item, int index, int count)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonUintList list, int index, uint item)
        {
            UdonGenericList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonUintList list, int index, uint[] collection)
        {
            UdonGenericList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonUintList list, uint item)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonUintList list, uint item, int index)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonUintList list, uint item, int index, int count)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonUintList list, uint item)
        {
            return UdonGenericList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonUintList list, int index)
        {
            UdonGenericList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonUintList list, int index, int count)
        {
            UdonGenericList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static uint[] ToArray(this UdonUintList list)
        {
            return UdonGenericList.ToArray<uint>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonUintList list)
        {
            UdonGenericList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonUintList list)
        {
            return (object[])(object)list;
        }
    }
}
