using System;

namespace Koyashiro.UdonList.Static
{
    using Koyashiro.UdonException;

    public static class UdonList
    {
        private const int DEFAULT_CAPACITY = 4;

        public static object[] New()
        {
            var items = new object[0];
            var size = 0;

            return new object[] { items, size };
        }

        public static object[] New<T>(T[] collection)
        {
            if (collection == null)
            {
                UdonException.ThrowArgumentNullException(nameof(collection));
            }

            var items = new object[collection.Length];
            var size = collection.Length;

            if (collection.Length > 0)
            {
                Array.Copy(collection, items, items.Length);
            }

            return new object[] { items, size };
        }

        public static object[] New(int capacity)
        {
            if (capacity < 0)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = new object[capacity];
            var size = 0;

            return new object[] { items, size };
        }

        public static int Capacity(object[] list)
        {
            var items = (object[])list[0];

            return items.Length;
        }

        public static void SetCapacity(object[] list, int capacity)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if (capacity < size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (capacity == items.Length)
            {
                return;
            }

            if (capacity == 0)
            {
                list[0] = new object[0];
                return;
            }

            var newItems = new object[capacity];
            Array.Copy(items, newItems, size);
            list[0] = newItems;
        }

        public static int Count(object[] list)
        {
            return (int)list[1];
        }

        public static void SetCount(object[] list, int count)
        {
            list[1] = count;
        }

        public static T GetItem<T>(object[] list, int index)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if ((uint)index >= (uint)size)
            {
                UdonException.ThrowIndexOutOfRangeException();
            }

            return (T)items[index];
        }

        public static void SetItem<T>(object[] list, int index, T item)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if ((uint)index >= (uint)size)
            {
                UdonException.ThrowIndexOutOfRangeException();
            }

            items[index] = item;
        }

        public static void Add<T>(object[] list, T item)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if ((uint)size >= (uint)items.Length)
            {
                Grow(list, size + 1);
                items = (object[])list[0];
            }

            items[size] = item;
            list[1] = size + 1;
        }

        public static void AddRange<T>(object[] list, T[] collection)
        {
            if (collection == null)
            {
                UdonException.ThrowArgumentNullException(nameof(collection));
            }

            if (collection.Length == 0)
            {
                return;
            }

            var items = (object[])list[0];
            var size = (int)list[1];

            if (items.Length - size < collection.Length)
            {
                Grow(list, size + collection.Length);
                items = (object[])list[0];
            }

            Array.Copy(collection, 0, items, size, collection.Length);
            list[1] = size + items.Length;
        }

        public static void Clear(object[] list)
        {
            list[1] = 0;
        }

        public static bool Contains<T>(object[] list, T item)
        {
            var size = (int)list[1];

            return size != 0 && IndexOf(list, item) >= 0;
        }

        public static void CopyTo<T>(object[] list, T[] array)
        {
            CopyTo(list, array, 0);
        }

        public static void CopyTo<T>(object[] list, int index, T[] array, int arrayIndex, int count)
        {
            if (array == null)
            {
                UdonException.ThrowArgumentNullException(nameof(array));
            }

            var items = (object[])list[0];
            var size = (int)list[1];

            if (size - index < count)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            Array.Copy(items, index, array, arrayIndex, count);
        }

        public static void CopyTo<T>(object[] list, T[] array, int arrayIndex)
        {
            if (array == null)
            {
                UdonException.ThrowArgumentNullException(nameof(array));
            }

            var items = (object[])list[0];
            var size = (int)list[1];

            Array.Copy(items, 0, array, arrayIndex, size);
        }

        public static int EnsureCapacity(object[] list, int capacity)
        {
            if (capacity < 0)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = (object[])list[0];

            if (items.Length > capacity)
            {
                Grow(list, capacity);
                items = (object[])list[0];
            }

            return items.Length;
        }

        private static void Grow(object[] list, int capacity)
        {
            var items = (object[])list[0];
            int newCapacity = items.Length == 0 ? DEFAULT_CAPACITY : 2 * items.Length;

            if (newCapacity < capacity)
            {
                newCapacity = capacity;
            }

            SetCapacity(list, newCapacity);
        }

        public static object[] GetRange(object[] list, int index, int count)
        {
            if (index < 0)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (count < 0)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = (object[])list[0];
            var size = (int)list[1];

            if (size - index < count)
            {
                UdonException.ThrowArgumentException();
            }

            var newItems = new object[count];
            Array.Copy(items, index, newItems, 0, count);

            return new object[] { newItems, count };
        }

        public static object[] Slice(object[] list, int start, int length)
        {
            return GetRange(list, start, length);
        }

        public static int IndexOf<T>(object[] list, T item)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            return Array.IndexOf(items, item, 0, size);
        }

        public static int IndexOf<T>(object[] list, T item, int index)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if (index > size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            return Array.IndexOf(items, item, index, size - index);
        }

        public static int IndexOf<T>(object[] list, T item, int index, int count)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if (index > size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (count < 0 || index > size - count)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            return Array.IndexOf(items, item, index, count);
        }

        public static void Insert<T>(object[] list, int index, T item)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if ((uint)index > (uint)size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (size == items.Length)
            {
                Grow(list, size + 1);
                items = (object[])list[0];
            }

            if (index < size)
            {
                Array.Copy(items, index, items, index + 1, size - index);
            }

            items[index] = item;
            list[1] = size + 1;
        }

        public static void InsertRange<T>(object[] list, int index, T[] collection)
        {
            if (collection == null)
            {
                UdonException.ThrowArgumentNullException(nameof(collection));
            }

            var items = (object[])list[0];
            var size = (int)list[1];

            if ((uint)index > (uint)size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (collection.Length == 0)
            {
                return;
            }

            if (items.Length - size < collection.Length)
            {
                Grow(list, size + collection.Length);
                items = (object[])list[0];
            }

            if (index < size)
            {
                Array.Copy(items, index, items, index + collection.Length, size - index);
            }

            if (object.Equals(list, collection))
            {
                Array.Copy(items, 0, items, index, index);
                Array.Copy(items, index + collection.Length, items, index * 2, size - index);
            }
            else
            {
                Array.Copy(collection, items, index);
            }

            list[1] = size + collection.Length;
        }

        public static int LastIndexOf<T>(object[] list, T item)
        {
            var size = (int)list[1];
            if (size == 0)
            {
                return -1;
            }

            return LastIndexOf(list, item, size - 1, size);
        }

        public static int LastIndexOf<T>(object[] list, T item, int index)
        {
            var size = (int)list[1];
            if (index >= size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            return LastIndexOf(list, item, index, index + 1);
        }

        public static int LastIndexOf<T>(object[] list, T item, int index, int count)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if ((size != 0) && (index < 0))
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if ((size != 0) && (count < 0))
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (size == 0)
            {
                return -1;
            }

            if (index >= size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (count > index + 1)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            return Array.LastIndexOf(items, item, index, count);
        }

        public static bool Remove<T>(object[] list, T item)
        {
            var index = IndexOf(list, item);
            if (index < 0)
            {
                return false;
            }

            RemoveAt(list, index);
            return true;
        }

        public static void RemoveAt(object[] list, int index)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if ((uint)index >= (uint)size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            size--;

            if (index < size)
            {
                Array.Copy(items, index + 1, items, index, size - index);
            }

            list[1] = size;
        }

        public static void RemoveRange(object[] list, int index, int count)
        {
            if (index < 0)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (count < 0)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = (object[])list[0];
            var size = (int)list[1];

            if (size - index < count)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (count == 0)
            {
                return;
            }

            size -= count;
            if (index < size)
            {
                Array.Copy(items, index + count, items, index, size - index);
            }

            list[1] = size;
        }

        public static T[] ToArray<T>(object[] list)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            if (size == 0)
            {
                return new T[0];
            }

            var array = new T[size];
            Array.Copy(items, array, size);

            return array;
        }

        public static void TrimExcess(object[] list)
        {
            var items = (object[])list[0];
            var size = (int)list[1];

            int threshold = (int)(((double)items.Length) * 0.9);

            if (size < threshold)
            {
                return;
            }

            SetCapacity(list, size);
        }
    }
}
