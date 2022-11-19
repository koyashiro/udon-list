namespace Koyashiro.UdonList
{
    public static class UdonUintListExt
    {
        public static int GetCapacity(this UdonUintList list)
        {
            return list.AsUdonList().GetCapacity();
        }

        public static void SetCapacity(this UdonUintList list, int capacity)
        {
            list.AsUdonList().SetCapacity(capacity);
        }

        public static int GetCount(this UdonUintList list)
        {
            return list.AsUdonList().GetCount();
        }

        public static uint GetItem(this UdonUintList list, int index)
        {
            return (uint)list.AsUdonList().GetItem(index);
        }

        public static void SetItem(this UdonUintList list, int index, uint item)
        {
            list.AsUdonList().SetItem(index, item);
        }

        public static void Add(this UdonUintList list, uint item)
        {
            list.AsUdonList().Add(item);
        }

        public static void AddRange(this UdonUintList list, uint[] collection)
        {
            list.AsUdonList().AddRange((object[])(object)collection);
        }

        public static void Clear(this UdonUintList list)
        {
            list.AsUdonList().Clear();
        }

        public static bool Contains(this UdonUintList list, uint item)
        {
            return list.AsUdonList().Contains(item);
        }

        public static void CopyTo(this UdonUintList list, int index, uint[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = list.GetItem(index + i);
            }
        }

        public static void CopyTo(this UdonUintList list, uint[] array)
        {
            list.CopyTo(0, array, 0, list.GetCount());
        }

        public static void CopyTo(this UdonUintList list, uint[] array, int arrayIndex)
        {
            list.CopyTo(0, array, 0, arrayIndex);
        }

        public static int EnsureCapacity(this UdonUintList list, int capacity)
        {
            return list.AsUdonList().EnsureCapacity(capacity);
        }

        public static UdonUintList GetRange(this UdonUintList list, int index, int count)
        {
            return (UdonUintList)(object)list.AsUdonList().GetRange(index, count);
        }

        public static int IndexOf(this UdonUintList list, uint item)
        {
            return list.AsUdonList().IndexOf(item);
        }

        public static int IndexOf(this UdonUintList list, uint item, int index)
        {
            return list.AsUdonList().IndexOf(item, index);
        }

        public static int IndexOf(this UdonUintList list, uint item, int index, int count)
        {
            return list.AsUdonList().IndexOf(item, index, count);
        }

        public static void Insert(this UdonUintList list, int index, uint item)
        {
            list.AsUdonList().Insert(index, item);
        }

        public static void InsertRange(this UdonUintList list, int index, uint[] items)
        {
            list.AsUdonList().InsertRange(index, (object[])(object)items);
        }

        public static int LastIndexOf(this UdonUintList list, uint item)
        {
            return list.AsUdonList().LastIndexOf(item);
        }

        public static int LastIndexOf(this UdonUintList list, uint item, int index)
        {
            return list.AsUdonList().LastIndexOf(item, index);
        }

        public static int LastIndexOf(this UdonUintList list, uint item, int index, int count)
        {
            return list.AsUdonList().LastIndexOf(item, index, count);
        }

        public static bool Remove(this UdonUintList list, uint item)
        {
            return list.AsUdonList().Remove(item);
        }

        public static void RemoveAt(this UdonUintList list, int index)
        {
            list.AsUdonList().RemoveAt(index);
        }

        public static void RemoveRange(this UdonUintList list, int index, int count)
        {
            list.AsUdonList().RemoveRange(index, count);
        }

        public static uint[] ToArray(this UdonUintList list)
        {
            var array = new uint[list.GetCount()];
            list.CopyTo(array);
            return array;
        }

        public static UdonList AsUdonList(this UdonUintList list)
        {
            return ((UdonList)(object)(list));
        }
    }
}
