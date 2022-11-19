namespace Koyashiro.UdonList
{
    public static class UdonByteListExt
    {
        public static int GetCapacity(this UdonByteList list)
        {
            return list.AsUdonList().GetCapacity();
        }

        public static void SetCapacity(this UdonByteList list, int capacity)
        {
            list.AsUdonList().SetCapacity(capacity);
        }

        public static int GetCount(this UdonByteList list)
        {
            return list.AsUdonList().GetCount();
        }

        public static byte GetItem(this UdonByteList list, int index)
        {
            return (byte)list.AsUdonList().GetItem(index);
        }

        public static void SetItem(this UdonByteList list, int index, byte item)
        {
            list.AsUdonList().SetItem(index, item);
        }

        public static void Add(this UdonByteList list, byte item)
        {
            list.AsUdonList().Add(item);
        }

        public static void AddRange(this UdonByteList list, byte[] collection)
        {
            list.AsUdonList().AddRange((object[])(object)collection);
        }

        public static void Clear(this UdonByteList list)
        {
            list.AsUdonList().Clear();
        }

        public static bool Contains(this UdonByteList list, byte item)
        {
            return list.AsUdonList().Contains(item);
        }

        public static void CopyTo(this UdonByteList list, int index, byte[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = list.GetItem(index + i);
            }
        }

        public static void CopyTo(this UdonByteList list, byte[] array)
        {
            list.CopyTo(0, array, 0, list.GetCount());
        }

        public static void CopyTo(this UdonByteList list, byte[] array, int arrayIndex)
        {
            list.CopyTo(0, array, 0, arrayIndex);
        }

        public static int EnsureCapacity(this UdonByteList list, int capacity)
        {
            return list.AsUdonList().EnsureCapacity(capacity);
        }

        public static UdonByteList GetRange(this UdonCharList list, int index, int count)
        {
            return (UdonByteList)(object)list.AsUdonList().GetRange(index, count);
        }

        public static int IndexOf(this UdonByteList list, byte item)
        {
            return list.AsUdonList().IndexOf(item);
        }

        public static int IndexOf(this UdonByteList list, byte item, int index)
        {
            return list.AsUdonList().IndexOf(item, index);
        }

        public static int IndexOf(this UdonByteList list, byte item, int index, int count)
        {
            return list.AsUdonList().IndexOf(item, index, count);
        }

        public static void Insert(this UdonByteList list, int index, byte item)
        {
            list.AsUdonList().Insert(index, item);
        }

        public static void InsertRange(this UdonByteList list, int index, byte[] items)
        {
            list.AsUdonList().InsertRange(index, (object[])(object)items);
        }

        public static int LastIndexOf(this UdonByteList list, byte item)
        {
            return list.AsUdonList().LastIndexOf(item);
        }

        public static int LastIndexOf(this UdonByteList list, byte item, int index)
        {
            return list.AsUdonList().LastIndexOf(item, index);
        }

        public static int LastIndexOf(this UdonByteList list, byte item, int index, int count)
        {
            return list.AsUdonList().LastIndexOf(item, index, count);
        }

        public static bool Remove(this UdonByteList list, byte item)
        {
            return list.AsUdonList().Remove(item);
        }

        public static void RemoveAt(this UdonByteList list, int index)
        {
            list.AsUdonList().RemoveAt(index);
        }

        public static void RemoveRange(this UdonByteList list, int index, int count)
        {
            list.AsUdonList().RemoveRange(index, count);
        }

        public static byte[] ToArray(this UdonByteList list)
        {
            var array = new byte[list.GetCount()];
            list.CopyTo(array);
            return array;
        }

        public static UdonList AsUdonList(this UdonByteList list)
        {
            return ((UdonList)(object)(list));
        }
    }
}
