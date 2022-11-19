namespace Koyashiro.UdonList
{
    public static class UdonFloatListExt
    {
        public static int GetCapacity(this UdonFloatList list)
        {
            return list.AsUdonList().GetCapacity();
        }

        public static void SetCapacity(this UdonFloatList list, int capacity)
        {
            list.AsUdonList().SetCapacity(capacity);
        }

        public static int GetCount(this UdonFloatList list)
        {
            return list.AsUdonList().GetCount();
        }

        public static float GetItem(this UdonFloatList list, int index)
        {
            return (float)list.AsUdonList().GetItem(index);
        }

        public static void SetItem(this UdonFloatList list, int index, float item)
        {
            list.AsUdonList().SetItem(index, item);
        }

        public static void Add(this UdonFloatList list, float item)
        {
            list.AsUdonList().Add(item);
        }

        public static void AddRange(this UdonFloatList list, float[] collection)
        {
            list.AsUdonList().AddRange((object[])(object)collection);
        }

        public static void Clear(this UdonFloatList list)
        {
            list.AsUdonList().Clear();
        }

        public static bool Contains(this UdonFloatList list, float item)
        {
            return list.AsUdonList().Contains(item);
        }

        public static void CopyTo(this UdonFloatList list, int index, float[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = list.GetItem(index + i);
            }
        }

        public static void CopyTo(this UdonFloatList list, float[] array)
        {
            list.CopyTo(0, array, 0, list.GetCount());
        }

        public static void CopyTo(this UdonFloatList list, float[] array, int arrayIndex)
        {
            list.CopyTo(0, array, 0, arrayIndex);
        }

        public static int EnsureCapacity(this UdonFloatList list, int capacity)
        {
            return list.AsUdonList().EnsureCapacity(capacity);
        }

        public static UdonFloatList GetRange(this UdonCharList list, int index, int count)
        {
            return (UdonFloatList)(object)list.AsUdonList().GetRange(index, count);
        }

        public static int IndexOf(this UdonFloatList list, float item)
        {
            return list.AsUdonList().IndexOf(item);
        }

        public static int IndexOf(this UdonFloatList list, float item, int index)
        {
            return list.AsUdonList().IndexOf(item, index);
        }

        public static int IndexOf(this UdonFloatList list, float item, int index, int count)
        {
            return list.AsUdonList().IndexOf(item, index, count);
        }

        public static void Insert(this UdonFloatList list, int index, float item)
        {
            list.AsUdonList().Insert(index, item);
        }

        public static void InsertRange(this UdonFloatList list, int index, float[] items)
        {
            list.AsUdonList().InsertRange(index, (object[])(object)items);
        }

        public static int LastIndexOf(this UdonFloatList list, float item)
        {
            return list.AsUdonList().LastIndexOf(item);
        }

        public static int LastIndexOf(this UdonFloatList list, float item, int index)
        {
            return list.AsUdonList().LastIndexOf(item, index);
        }

        public static int LastIndexOf(this UdonFloatList list, float item, int index, int count)
        {
            return list.AsUdonList().LastIndexOf(item, index, count);
        }

        public static bool Remove(this UdonFloatList list, float item)
        {
            return list.AsUdonList().Remove(item);
        }

        public static void RemoveAt(this UdonFloatList list, int index)
        {
            list.AsUdonList().RemoveAt(index);
        }

        public static void RemoveRange(this UdonFloatList list, int index, int count)
        {
            list.AsUdonList().RemoveRange(index, count);
        }

        public static float[] ToArray(this UdonFloatList list)
        {
            var array = new float[list.GetCount()];
            list.CopyTo(array);
            return array;
        }

        public static UdonList AsUdonList(this UdonFloatList list)
        {
            return ((UdonList)(object)(list));
        }
    }
}
