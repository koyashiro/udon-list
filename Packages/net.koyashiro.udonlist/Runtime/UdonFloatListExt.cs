using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    public static class UdonFloatListExt
    {
        public static int Capacity(this UdonFloatList list)
        {
            return UdonGenericList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonFloatList list, int capacity)
        {
            UdonGenericList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonFloatList list)
        {
            return UdonGenericList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonFloatList list, int count)
        {
            UdonGenericList.SetCount(list.AsObjectArray(), count);
        }

        public static float GetItem(this UdonFloatList list, int index)
        {
            return UdonGenericList.GetItem<float>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonFloatList list, int index, float item)
        {
            UdonGenericList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonFloatList list, float item)
        {
            UdonGenericList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonFloatList list, float[] collection)
        {
            UdonGenericList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonFloatList list)
        {
            UdonGenericList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonFloatList list, float item)
        {
            return UdonGenericList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonFloatList list, float[] array)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonFloatList list, int index, float[] array, int arrayIndex, int count)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonFloatList list, float[] array, int arrayIndex)
        {
            UdonGenericList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonFloatList list, int capacity)
        {
            return UdonGenericList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonFloatList GetRange(this UdonFloatList list, int index, int count)
        {
            return (UdonFloatList)(object)UdonGenericList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonFloatList Slice(this UdonFloatList list, int start, int length)
        {
            return (UdonFloatList)(object)UdonGenericList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonFloatList list, float item)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonFloatList list, float item, int index)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonFloatList list, float item, int index, int count)
        {
            return UdonGenericList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonFloatList list, int index, float item)
        {
            UdonGenericList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonFloatList list, int index, float[] collection)
        {
            UdonGenericList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonFloatList list, float item)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonFloatList list, float item, int index)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonFloatList list, float item, int index, int count)
        {
            return UdonGenericList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonFloatList list, float item)
        {
            return UdonGenericList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonFloatList list, int index)
        {
            UdonGenericList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonFloatList list, int index, int count)
        {
            UdonGenericList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static float[] ToArray(this UdonFloatList list)
        {
            return UdonGenericList.ToArray<float>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonFloatList list)
        {
            UdonGenericList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonFloatList list)
        {
            return (object[])(object)list;
        }
    }
}
