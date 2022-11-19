using Koyashiro.UdonList.Internal;

namespace Koyashiro.UdonList.Generic
{
    public static class UdonGenericList
    {
        private const int DEFAULT_CAPACITY = 4;

        public static object[] New()
        {
            return New(0);
        }

        public static object[] New<T>(T[] collection)
        {
            if (collection == null)
            {
                UdonException.ThrowArgumentNullException(nameof(collection));
            }

            var items = new object[collection.Length];
            if (collection.Length > 0)
            {
                Array.Copy(collection, items, items.Length);
            }
            var size = collection.Length;
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

        private static object[] Items(object[] list)
        {
            return (object[])list[0];
        }

        private static void SetItems(object[] list, object[] items)
        {
            list[0] = items;
        }

        public static int Capacity(object[] list)
        {
            return Items(list).Length;
        }

        public static void SetCapacity(object[] list, int capacity)
        {
            var size = Count(list);
            if (capacity < size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = Items(list);
            if (capacity != items.Length)
            {
                if (capacity > 0)
                {
                    var newItems = new object[capacity];
                    if (capacity > 0)
                    {
                        Array.Copy(items, newItems, size);
                    }
                    SetItems(list, newItems);
                }
                else
                {
                    SetItems(list, new object[0]);
                }
            }
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
            var size = Count(list);
            if ((uint)index >= (uint)size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            return (T)Items(list)[index];
        }

        public static void SetItem<T>(object[] list, int index, T item)
        {
            var size = Count(list);
            if ((uint)index >= (uint)size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = Items(list);
            items[index] = item;
        }

        public static void Add<T>(object[] list, T item)
        {
            var size = Count(list);
            var items = Items(list);
            if ((uint)size < (uint)items.Length)
            {
                SetCount(list, size + 1);
                SetItem(list, size, item);
            }
            else
            {
                AddWithResize(list, item);
            }
        }

        private static void AddWithResize<T>(object[] list, T item)
        {
            var size = Count(list);
            Grow(list, size + 1);
            SetCount(list, size + 1);
            SetItem(list, size, item);
        }

        public static void AddRange<T>(object[] list, T[] collection)
        {
            if (collection == null)
            {
                UdonException.ThrowArgumentNullException(nameof(collection));
            }

            if (collection.Length > 0)
            {
                var items = Items(list);
                var size = Count(list);
                if (items.Length - size < collection.Length)
                {
                    Grow(list, size + items.Length);
                }

                items = Items(list);
                Array.Copy(collection, items, collection.Length);
                SetCount(list, size + items.Length);
            }
        }

        public static void Clear(object[] list)
        {
            int size = Count(list);
            SetCount(list, 0);
        }

        public static bool Contains<T>(object[] list, T item)
        {
            var size = Count(list);
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

            var size = Count(list);
            if (size - index < count)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = Items(list);
            Array.Copy(items, index, array, arrayIndex, count);
        }

        public static void CopyTo<T>(object[] list, T[] array, int arrayIndex)
        {
            if (array == null)
            {
                UdonException.ThrowArgumentNullException(nameof(array));
            }

            var items = Items(list);
            var size = Count(list);
            Array.Copy(items, 0, array, arrayIndex, size);
        }

        public static int EnsureCapacity(object[] list, int capacity)
        {
            if (capacity < 0)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = Items(list);
            if (items.Length > capacity)
            {
                Grow(list, capacity);
            }

            return items.Length;
        }

        private static void Grow(object[] list, int capacity)
        {
            var items = Items(list);
            int newCapacity = items.Length == 0 ? DEFAULT_CAPACITY : items.Length * 2;

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

            var size = Count(list);
            if (size - index < count)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = Items(list);
            var newList = New(count);
            var newListItems = Items(newList);
            Array.Copy(items, index, newListItems, 0, count);
            SetCount(newList, count);
            return newList;
        }

        public static object[] Slice(object[] list, int start, int length)
        {
            return GetRange(list, start, length);
        }

        public static int IndexOf<T>(object[] list, T item)
        {
            var items = Items(list);
            var size = Count(list);
            return Array.IndexOf(items, item, 0, size);
        }

        public static int IndexOf<T>(object[] list, T item, int index)
        {
            if (index > Count(list))
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = Items(list);
            var size = Count(list);
            return Array.IndexOf(items, item, index, size - index);
        }

        public static int IndexOf<T>(object[] list, T item, int index, int count)
        {
            var size = Count(list);
            if (index > size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (count < 0 || index > size - count)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = Items(list);
            return Array.IndexOf(items, item, index, count);
        }

        public static void Insert<T>(object[] list, int index, T item)
        {
            var size = Count(list);
            if ((uint)index > (uint)size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            var items = Items(list);
            if (size == items.Length)
            {
                Grow(list, size + 1);
                items = Items(list);
            }

            if (index < size)
            {
                Array.Copy(items, index, items, index + 1, size - index);
            }
            items[index] = item;
            SetCount(list, size + 1);
        }

        public static void InsertRange<T>(object[] list, int index, T[] collection)
        {
            if (collection == null)
            {
                UdonException.ThrowArgumentNullException(nameof(collection));
            }

            var size = Count(list);
            if ((uint)index > (uint)size)
            {
                UdonException.ThrowArgumentNullException(nameof(collection));
            }

            if (collection.Length > 0)
            {
                var items = Items(list);
                if (items.Length - size < collection.Length)
                {
                    Grow(list, size + collection.Length);
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
                {
                    Array.Copy(collection, items, index);
                }
                SetCount(list, collection.Length);
            }
        }

        public static int LastIndexOf<T>(object[] list, T item)
        {
            var size = Count(list);
            if (size == 0)
            {
                return -1;
            }

            return LastIndexOf(list, item, size - 1, size);
        }

        public static int LastIndexOf<T>(object[] list, T item, int index)
        {
            var size = Count(list);
            if (index >= size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            return LastIndexOf(list, item, index, index + 1);
        }

        public static int LastIndexOf<T>(object[] list, T item, int index, int count)
        {
            var size = Count(list);
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

            var items = Items(list);
            return Array.LastIndexOf(items, item, index, count);
        }

        public static bool Remove<T>(object[] list, T item)
        {
            var index = IndexOf(list, item);
            if (index >= 0)
            {
                RemoveAt(list, index);
                return true;
            }

            return false;
        }

        public static void RemoveAt(object[] list, int index)
        {
            var size = Count(list);
            if ((uint)index >= (uint)size)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }
            size--;
            if (index < size)
            {
                var items = Items(list);
                Array.Copy(items, index + 1, items, index, size - index);
            }
            SetCount(list, size);
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

            var size = Count(list);
            if (size - index < count)
            {
                UdonException.ThrowArgumentOutOfRangeException();
            }

            if (count > 0)
            {
                size -= count;
                var items = Items(list);
                if (index < size)
                {
                    Array.Copy(items, index + count, items, index, size - index);
                }
                SetCount(list, size);
            }
        }

        public static T[] ToArray<T>(object[] list)
        {
            var size = Count(list);
            if (size == 0)
            {
                return new T[0];
            }

            var array = new T[size];
            var items = Items(list);
            Array.Copy(items, array, size);
            return array;
        }

        public static void TrimExcess(object[] list)
        {
            var items = Items(list);
            var size = Count(list);
            int threshold = (int)(((double)items.Length) * 0.9);
            if (size < threshold)
            {
                SetCapacity(list, size);
            }
        }
    }
}
