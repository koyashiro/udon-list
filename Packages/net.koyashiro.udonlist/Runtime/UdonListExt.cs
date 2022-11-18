using System;

namespace Koyashiro.UdonList
{
    public static class UdonListExt
    {
        public static int GetCapacity(this UdonList list)
        {
            return list.GetRawArray().Length;
        }

        public static void SetCapacity(this UdonList list, int capacity)
        {
            if (capacity == list.GetCapacity())
            {
                return;
            }

            var newRawArray = new object[capacity];
            for (var i = 0; i < list.GetCapacity(); i++)
            {
                newRawArray[i] = list.GetItem(i);
            }
            list.SetRawArray(newRawArray);

            if (capacity < list.GetCapacity())
            {
                list.SetCount(capacity);
            }
        }

        public static int GetCount(this UdonList list)
        {
            return (int)list.AsArray()[1];
        }

        public static object GetItem(this UdonList list, int index)
        {
            if (index < 0 || list.GetCapacity() <= index)
            {
                UdonException.ThrowArgumentOutOfRangeException();
                return default;
            }

            return list.GetRawArray()[index];
        }

        public static void SetItem(this UdonList list, int index, object item)
        {
            if (index < 0 || list.GetCapacity() <= index)
            {
                UdonException.ThrowArgumentOutOfRangeException();
                return;
            }

            list.GetRawArray()[index] = item;
        }

        public static void Add(this UdonList list, object item)
        {
            if (list.GetCapacity() <= list.GetCount())
            {
                list.EnsureCapacity(NextCapacity(list.GetCapacity()));
            }

            list.SetItem(list.GetCount(), item);
            list.SetCount(list.GetCount() + 1);
        }

        public static void AddRange(this UdonList list, object[] collection)
        {
            foreach (var item in collection)
            {
                list.Add(item);
            }
        }

        public static void Clear(this UdonList list)
        {
            list.SetCount(0);
        }

        public static bool Contains(this UdonList list, object item)
        {
            return list.IndexOf(item) != -1;
        }

        public static void CopyTo(this UdonList list, int index, object[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = list.GetItem(index + 1);
            }
        }

        public static void CopyTo(this UdonList list, object[] array)
        {
            list.CopyTo(0, array, 0, list.GetCount());
        }

        public static void CopyTo(this UdonList list, object[] array, int arrayIndex)
        {
            list.CopyTo(0, array, 0, arrayIndex);
        }

        public static int EnsureCapacity(this UdonList list, int capacity)
        {
            list.SetCapacity(capacity);
            return capacity;
        }

        public static UdonList GetRange(this UdonList list, int index, int count)
        {
            var rangeList = UdonList.New(count);
            list.CopyTo(index, rangeList.GetRawArray(), 0, count);
            list.SetCount(count);
            return rangeList;
        }

        public static int IndexOf(this UdonList list, object item)
        {
            return list.IndexOf(item, 0, list.GetCount());
        }

        public static int IndexOf(this UdonList list, object item, int index)
        {
            return list.IndexOf(item, index, list.GetCount());
        }

        public static int IndexOf(this UdonList list, object item, int index, int count)
        {
            for (var i = index; i < count; i++)
            {
                if (object.Equals(list.GetItem(i), item))
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Insert(this UdonList list, int index, object item)
        {
            if (index < 0 || list.GetCount() < index)
            {
                UdonException.ThrowArgumentOutOfRangeException();
                return;
            }

            if (index == list.GetCount())
            {
                list.Add(item);
            }
            else
            {
                list.Add(list.GetItem(list.GetCount() - 1));
                for (int i = list.GetCount() - 2; i >= index + 1; i--)
                {
                    list.SetItem(i, list.GetItem(i - 1));
                }
                list.SetItem(index, item);
            }
        }

        public static void InsertRange(this UdonList list, int index, object[] items)
        {
            for (var i = 0; i < items.Length; i++)
            {
                list.Insert(index + i, items[i]);
            }
        }

        public static int LastIndexOf(this UdonList list, object item)
        {
            return list.LastIndexOf(item, 0, list.GetCount());
        }

        public static int LastIndexOf(this UdonList list, object item, int index)
        {
            return list.LastIndexOf(item, index, list.GetCount());
        }

        public static int LastIndexOf(this UdonList list, object item, int index, int count)
        {
            for (var i = count; i >= index; i--)
            {
                if (object.Equals(list.GetItem(i), item))
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool Remove(this UdonList list, object item)
        {
            var index = list.IndexOf(item);
            if (index == -1)
            {
                return false;
            }

            list.RemoveAt(index);
            return true;
        }

        public static void RemoveAt(this UdonList list, int index)
        {
            if (index < 0 || list.GetCount() <= index)
            {
                UdonException.ThrowArgumentOutOfRangeException();
                return;
            }

            if (index < list.GetCount() - 1)
            {
                for (var i = index; i < list.GetCount() - 1; i++)
                {
                    list.SetItem(i, list.GetItem(i + 1));
                }
            }
            list.SetCount(list.GetCount() - 1);
        }

        public static void RemoveRange(this UdonList list, int index, int count)
        {
            if (
                index < 0
                || list.GetCount() <= index
                || list.GetCount() < index + count
            )
            {
                UdonException.ThrowArgumentOutOfRangeException();
                return;
            }


            if (index + count == list.GetCount())
            {
                list.SetCapacity(index);
            }
            else
            {
                for (var i = 0; i < count; i++)
                {
                    list.RemoveAt(i);
                }
            }
        }

        public static object[] ToArray(this UdonList list)
        {
            var array = new object[list.GetCount()];
            list.CopyTo(array);
            return array;
        }

        private static object[] AsArray(this UdonList list)
        {
            return (object[])(object)list;
        }

        private static object[] GetRawArray(this UdonList list)
        {
            return (object[])list.AsArray()[0];
        }

        private static void SetRawArray(this UdonList list, object[] rawArray)
        {
            list.AsArray()[0] = rawArray;
        }

        private static void SetCount(this UdonList list, int count)
        {
            list.AsArray()[1] = count;
        }

        private static int NextCapacity(int currentCupacity)
        {
            if (currentCupacity <= 0)
            {
                return 4;
            }
            else
            {
                return currentCupacity << 1;
            }
        }
    }
}
