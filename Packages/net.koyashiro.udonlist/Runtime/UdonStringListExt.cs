namespace Koyashiro.UdonList
{
    public static class UdonStringListExt
    {
        public static int GetCapacity(this UdonStringList list)
        {
            return list.AsUdonList().GetCapacity();
        }

        public static void SetCapacity(this UdonStringList list, int capacity)
        {
            list.AsUdonList().SetCapacity(capacity);
        }

        public static int GetCount(this UdonStringList list)
        {
            return list.AsUdonList().GetCount();
        }

        public static string GetItem(this UdonStringList list, int index)
        {
            return (string)list.AsUdonList().GetItem(index);
        }

        public static void SetItem(this UdonStringList list, int index, string item)
        {
            list.AsUdonList().SetItem(index, item);
        }

        public static void Add(this UdonStringList list, string item)
        {
            list.AsUdonList().Add(item);
        }

        public static void AddRange(this UdonStringList list, string[] collection)
        {
            list.AsUdonList().AddRange(collection);
        }

        public static void Clear(this UdonStringList list)
        {
            list.AsUdonList().Clear();
        }

        public static bool Contains(this UdonStringList list, string item)
        {
            return list.AsUdonList().Contains(item);
        }

        public static void CopyTo(this UdonStringList list, int index, string[] array, int arrayIndex, int count)
        {
            list.AsUdonList().CopyTo(index, array, arrayIndex, count);
        }

        public static void CopyTo(this UdonStringList list, string[] array)
        {
            list.AsUdonList().CopyTo(array);
        }

        public static void CopyTo(this UdonStringList list, string[] array, int arrayIndex)
        {
            list.AsUdonList().CopyTo(array, arrayIndex);
        }

        public static int EnsureCapacity(this UdonStringList list, int capacity)
        {
            return list.AsUdonList().EnsureCapacity(capacity);
        }

        public static UdonStringList GetRange(this UdonStringList list, int index, int count)
        {
            return (UdonStringList)(object)list.AsUdonList().GetRange(index, count);
        }

        public static int IndexOf(this UdonStringList list, string item)
        {
            return list.AsUdonList().IndexOf(item);
        }

        public static int IndexOf(this UdonStringList list, string item, int index)
        {
            return list.AsUdonList().IndexOf(item, index);
        }

        public static int IndexOf(this UdonStringList list, string item, int index, int count)
        {
            return list.AsUdonList().IndexOf(item, index, count);
        }

        public static void Insert(this UdonStringList list, int index, string item)
        {
            list.AsUdonList().Insert(index, item);
        }

        public static void InsertRange(this UdonStringList list, int index, string[] items)
        {
            list.AsUdonList().InsertRange(index, items);
        }

        public static int LastIndexOf(this UdonStringList list, string item)
        {
            return list.AsUdonList().LastIndexOf(item);
        }

        public static int LastIndexOf(this UdonStringList list, string item, int index)
        {
            return list.AsUdonList().LastIndexOf(item, index);
        }

        public static int LastIndexOf(this UdonStringList list, string item, int index, int count)
        {
            return list.AsUdonList().LastIndexOf(item, index, count);
        }

        public static bool Remove(this UdonStringList list, string item)
        {
            return list.AsUdonList().Remove(item);
        }

        public static void RemoveAt(this UdonStringList list, int index)
        {
            list.AsUdonList().RemoveAt(index);
        }

        public static void RemoveRange(this UdonStringList list, int index, int count)
        {
            list.AsUdonList().RemoveRange(index, count);
        }

        public static string[] ToArray(this UdonStringList list)
        {
            var array = new string[list.GetCount()];
            list.CopyTo(array);
            return array;
        }

        public static UdonList AsUdonList(this UdonStringList list)
        {
            return ((UdonList)(object)(list));
        }
    }
}
