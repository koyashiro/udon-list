namespace Koyashiro.UdonList
{
    public static class UdonCharListExt
    {
        public static int GetCapacity(this UdonCharList list)
        {
            return list.AsUdonList().GetCapacity();
        }

        public static void SetCapacity(this UdonCharList list, int capacity)
        {
            list.AsUdonList().SetCapacity(capacity);
        }

        public static int GetCount(this UdonCharList list)
        {
            return list.AsUdonList().GetCount();
        }

        public static char GetItem(this UdonCharList list, int index)
        {
            return (char)list.AsUdonList().GetItem(index);
        }

        public static void SetItem(this UdonCharList list, int index, char item)
        {
            list.AsUdonList().SetItem(index, item);
        }

        public static void Add(this UdonCharList list, char item)
        {
            list.AsUdonList().Add(item);
        }

        public static void AddRange(this UdonCharList list, char[] collection)
        {
            list.AsUdonList().AddRange((object[])(object)collection);
        }

        public static void Clear(this UdonCharList list)
        {
            list.AsUdonList().Clear();
        }

        public static bool Contains(this UdonCharList list, char item)
        {
            return list.AsUdonList().Contains(item);
        }

        public static void CopyTo(this UdonCharList list, int index, char[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = list.GetItem(index + i);
            }
        }

        public static void CopyTo(this UdonCharList list, char[] array)
        {
            list.CopyTo(0, array, 0, list.GetCount());
        }

        public static void CopyTo(this UdonCharList list, char[] array, int arrayIndex)
        {
            list.CopyTo(0, array, 0, arrayIndex);
        }

        public static int EnsureCapacity(this UdonCharList list, int capacity)
        {
            return list.AsUdonList().EnsureCapacity(capacity);
        }

        public static UdonCharList GetRange(this UdonCharList list, int index, int count)
        {
            return (UdonCharList)(object)list.AsUdonList().GetRange(index, count);
        }

        public static int IndexOf(this UdonCharList list, char item)
        {
            return list.AsUdonList().IndexOf(item);
        }

        public static int IndexOf(this UdonCharList list, char item, int index)
        {
            return list.AsUdonList().IndexOf(item, index);
        }

        public static int IndexOf(this UdonCharList list, char item, int index, int count)
        {
            return list.AsUdonList().IndexOf(item, index, count);
        }

        public static void Insert(this UdonCharList list, int index, char item)
        {
            list.AsUdonList().Insert(index, item);
        }

        public static void InsertRange(this UdonCharList list, int index, char[] items)
        {
            list.AsUdonList().InsertRange(index, (object[])(object)items);
        }

        public static int LastIndexOf(this UdonCharList list, char item)
        {
            return list.AsUdonList().LastIndexOf(item);
        }

        public static int LastIndexOf(this UdonCharList list, char item, int index)
        {
            return list.AsUdonList().LastIndexOf(item, index);
        }

        public static int LastIndexOf(this UdonCharList list, char item, int index, int count)
        {
            return list.AsUdonList().LastIndexOf(item, index, count);
        }

        public static bool Remove(this UdonCharList list, char item)
        {
            return list.AsUdonList().Remove(item);
        }

        public static void RemoveAt(this UdonCharList list, int index)
        {
            list.AsUdonList().RemoveAt(index);
        }

        public static void RemoveRange(this UdonCharList list, int index, int count)
        {
            list.AsUdonList().RemoveRange(index, count);
        }

        public static char[] ToArray(this UdonCharList list)
        {
            var array = new char[list.GetCount()];
            list.CopyTo(array);
            return array;
        }

        public static UdonList AsUdonList(this UdonCharList list)
        {
            return ((UdonList)(object)(list));
        }
    }
}
