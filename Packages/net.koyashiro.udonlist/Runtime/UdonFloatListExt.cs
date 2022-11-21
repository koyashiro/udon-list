namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Internal;

    public static class UdonFloatListExt
    {
        public static int Capacity(this UdonFloatList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonFloatList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonFloatList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static void SetCount(this UdonFloatList list, int count)
        {
            UdonList.SetCount(list.AsObjectArray(), count);
        }

        public static float GetItem(this UdonFloatList list, int index)
        {
            return UdonList.GetItem<float>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonFloatList list, int index, float item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonFloatList list, float item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonFloatList list, float[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonFloatList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonFloatList list, float item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonFloatList list, float[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonFloatList list, int index, float[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonFloatList list, float[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonFloatList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonFloatList GetRange(this UdonFloatList list, int index, int count)
        {
            return (UdonFloatList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonFloatList Slice(this UdonFloatList list, int start, int length)
        {
            return (UdonFloatList)(object)UdonList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonFloatList list, float item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonFloatList list, float item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonFloatList list, float item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonFloatList list, int index, float item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonFloatList list, int index, float[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonFloatList list, float item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonFloatList list, float item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonFloatList list, float item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonFloatList list, float item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonFloatList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonFloatList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static float[] ToArray(this UdonFloatList list)
        {
            return UdonList.ToArray<float>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonFloatList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonFloatList list)
        {
            return (object[])(object)list;
        }
    }
}
