namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    public static class UdonBoolListExt
    {
        public static int Capacity(this UdonBoolList list)
        {
            return UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity(this UdonBoolList list, int capacity)
        {
            UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count(this UdonBoolList list)
        {
            return UdonList.Count(list.AsObjectArray());
        }

        public static bool GetItem(this UdonBoolList list, int index)
        {
            return UdonList.GetItem<bool>(list.AsObjectArray(), index);
        }

        public static void SetItem(this UdonBoolList list, int index, bool item)
        {
            UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add(this UdonBoolList list, bool item)
        {
            UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange(this UdonBoolList list, bool[] collection)
        {
            UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear(this UdonBoolList list)
        {
            UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains(this UdonBoolList list, bool item)
        {
            return UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo(this UdonBoolList list, bool[] array)
        {
            UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo(this UdonBoolList list, int index, bool[] array, int arrayIndex, int count)
        {
            UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo(UdonBoolList list, bool[] array, int arrayIndex)
        {
            UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonBoolList list, int capacity)
        {
            return UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonBoolList GetRange(this UdonBoolList list, int index, int count)
        {
            return (UdonBoolList)(object)UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf(this UdonBoolList list, bool item)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf(this UdonBoolList list, bool item, int index)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf(this UdonBoolList list, bool item, int index, int count)
        {
            return UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert(this UdonBoolList list, int index, bool item)
        {
            UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange(this UdonBoolList list, int index, bool[] collection)
        {
            UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf(this UdonBoolList list, bool item)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf(this UdonBoolList list, bool item, int index)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf(this UdonBoolList list, bool item, int index, int count)
        {
            return UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove(this UdonBoolList list, bool item)
        {
            return UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt(this UdonBoolList list, int index)
        {
            UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange(this UdonBoolList list, int index, int count)
        {
            UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse(this UdonBoolList list)
        {
            UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse(this UdonBoolList list, int index, int count)
        {
            UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort(this UdonBoolList list)
        {
            UdonList.Sort<bool>(list.AsObjectArray());
        }

        public static void Sort(this UdonBoolList list, int index, int count)
        {
            UdonList.Sort<bool>(list.AsObjectArray(), index, count);
        }

        public static bool[] ToArray(this UdonBoolList list)
        {
            return UdonList.ToArray<bool>(list.AsObjectArray());
        }

        public static void TrimExcess(this UdonBoolList list)
        {
            UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray(this UdonBoolList list)
        {
            return (object[])(object)list;
        }
    }
}
