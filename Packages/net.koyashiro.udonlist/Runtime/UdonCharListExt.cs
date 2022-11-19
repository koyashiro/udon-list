using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    public static class UdonCharListExt
    {
        public static int Capacity(this UdonCharList list)
        {
            return UdonGenericList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonCharList list, int capacity)
        {
            UdonGenericList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonCharList list)
        {
            return UdonGenericList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonCharList list, int count)
        {
            UdonGenericList.SetCount(list.AsObjectArray(), count);
        }

        public static char GetItem(this UdonCharList list, int index)
        {
            return UdonGenericList.GetItem<char>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonCharList list, int index, char item)
        {
            UdonGenericList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonCharList list, char item)
        {
            UdonGenericList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonCharList list, char[] collection)
        {
            UdonGenericList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonCharList list)
        {
            UdonGenericList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonCharList list, char item)
        {
            return UdonGenericList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonCharList list, char[] array)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonCharList list, int index, char[] array, int arrayIndex, int count)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonCharList list, char[] array, int arrayIndex)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonCharList list, int capacity)
        {
            return UdonGenericList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonCharList GetRange(this UdonCharList list, int index, int count)
        {
            return (UdonCharList)(object)UdonGenericList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonCharList Slice(this UdonCharList list, int start, int length)
        {
            return (UdonCharList)(object)UdonGenericList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonCharList list, char item)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonCharList list, char item, int index)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonCharList list, char item, int index, int count)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonCharList list, int index, char item)
        {
            UdonGenericList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonCharList list, int index, char[] collection)
        {
            UdonGenericList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonCharList list, char item)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonCharList list, char item, int index)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonCharList list, char item, int index, int count)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonCharList list, char item)
        {
            return UdonGenericList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonCharList list, int index)
        {
            UdonGenericList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonCharList list, int index, int count)
        {
            UdonGenericList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static char[] ToArray(this UdonCharList list)
        {
            return UdonGenericList.ToArray<char>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonCharList list)
        {
            UdonGenericList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonCharList list)
        {
            return (object[])(object)list;
        }
    }
}
