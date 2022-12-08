namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonUintListExt
    {
        public static int Capacity(this UdonUintList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonUintList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonUintList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static uint GetItem(this UdonUintList list, int index)
        {
            return UdonList.GetItem<uint>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonUintList list, int index, uint item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonUintList list, uint item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonUintList list, uint[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonUintList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonUintList list, uint item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonUintList list, uint[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonUintList list, int index, uint[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonUintList list, uint[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonUintList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonUintList GetRange(this UdonUintList list, int index, int count)
        {
            return (UdonUintList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static UdonUintList Slice(this UdonUintList list, int start, int length)
        {
            return (UdonUintList)(object)UdonList.Slice(list.AsObjectArray(), start, length);
        }

        public static int IndexOf(this UdonUintList list, uint item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonUintList list, uint item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonUintList list, uint item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonUintList list, int index, uint item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonUintList list, int index, uint[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonUintList list, uint item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonUintList list, uint item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonUintList list, uint item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonUintList list, uint item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonUintList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonUintList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonUintList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonUintList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonUintList list)
        {
            UdonList.Sort<uint>(list.AsObjectArray());
        }

        public static void Sort(this UdonUintList list, int index, int count)
        {
            UdonList.Sort<uint>(list.AsObjectArray(), index, count);
        }

        public static uint[] ToArray(this UdonUintList list)
        {
            return UdonList.ToArray<uint>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonUintList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonUintList list)
        {
            return (object[])(object)list;
        }
    }
}
