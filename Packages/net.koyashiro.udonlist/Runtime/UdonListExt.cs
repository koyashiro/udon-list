namespace Koyashiro.UdonList
{
    using System;

    public static class UdonListExt
    {
        public static int Capacity<T>(this UdonList<T> list)
        {
            return Core.UdonList.Capacity(list.AsObjectArray());
        }

        public static void SetCapacity<T>(this UdonList<T> list, int capacity)
        {
            Core.UdonList.SetCapacity(list.AsObjectArray(), capacity);
        }

        public static int Count<T>(this UdonList<T> list)
        {
            return Core.UdonList.Count(list.AsObjectArray());
        }

        public static T GetItem<T>(this UdonList<T> list, int index)
        {
            return Core.UdonList.GetItem<T>(list.AsObjectArray(), index);
        }

        public static void SetItem<T>(this UdonList<T> list, int index, T item)
        {
            Core.UdonList.SetItem(list.AsObjectArray(), index, item);
        }

        public static void Add<T>(this UdonList<T> list, T item)
        {
            Core.UdonList.Add(list.AsObjectArray(), item);
        }

        public static void AddRange<T>(this UdonList<T> list, T[] collection)
        {
            Core.UdonList.AddRange(list.AsObjectArray(), collection);
        }

        public static void Clear<T>(this UdonList<T> list)
        {
            Core.UdonList.Clear(list.AsObjectArray());
        }

        public static bool Contains<T>(this UdonList<T> list, T item)
        {
            return Core.UdonList.Contains(list.AsObjectArray(), item);
        }

        public static void CopyTo<T>(this UdonList<T> list, T[] array)
        {
            Core.UdonList.CopyTo(list.AsObjectArray(), array);
        }

        public static void CopyTo<T>(this UdonList<T> list, int index, T[] array, int arrayIndex, int count)
        {
            Core.UdonList.CopyTo(list.AsObjectArray(), index, array, arrayIndex, count);
        }

        public static void CopyTo<T>(UdonList<T> list, T[] array, int arrayIndex)
        {
            Core.UdonList.CopyTo(list.AsObjectArray(), array, arrayIndex);
        }

        public static int EnsureCapacity<T>(this UdonList<T> list, int capacity)
        {
            return Core.UdonList.EnsureCapacity(list.AsObjectArray(), capacity);
        }

        public static UdonList<T> GetRange<T>(this UdonList<T> list, int index, int count)
        {
            return (UdonList<T>)(object)Core.UdonList.GetRange(list.AsObjectArray(), index, count);
        }

        public static int IndexOf<T>(this UdonList<T> list, T item)
        {
            return Core.UdonList.IndexOf(list.AsObjectArray(), item);
        }

        public static int IndexOf<T>(this UdonList<T> list, T item, int index)
        {
            return Core.UdonList.IndexOf(list.AsObjectArray(), item, index);
        }

        public static int IndexOf<T>(this UdonList<T> list, T item, int index, int count)
        {
            return Core.UdonList.IndexOf(list.AsObjectArray(), item, index, count);
        }

        public static void Insert<T>(this UdonList<T> list, int index, T item)
        {
            Core.UdonList.Insert(list.AsObjectArray(), index, item);
        }

        public static void InsertRange<T>(this UdonList<T> list, int index, T[] collection)
        {
            Core.UdonList.InsertRange(list.AsObjectArray(), index, collection);
        }

        public static int LastIndexOf<T>(this UdonList<T> list, T item)
        {
            return Core.UdonList.LastIndexOf(list.AsObjectArray(), item);
        }

        public static int LastIndexOf<T>(this UdonList<T> list, T item, int index)
        {
            return Core.UdonList.LastIndexOf(list.AsObjectArray(), item, index);
        }

        public static int LastIndexOf<T>(this UdonList<T> list, T item, int index, int count)
        {
            return Core.UdonList.LastIndexOf(list.AsObjectArray(), item, index, count);
        }

        public static bool Remove<T>(this UdonList<T> list, T item)
        {
            return Core.UdonList.Remove(list.AsObjectArray(), item);
        }

        public static void RemoveAt<T>(this UdonList<T> list, int index)
        {
            Core.UdonList.RemoveAt(list.AsObjectArray(), index);
        }

        public static void RemoveRange<T>(this UdonList<T> list, int index, int count)
        {
            Core.UdonList.RemoveRange(list.AsObjectArray(), index, count);
        }

        public static void Reverse<T>(this UdonList<T> list)
        {
            Core.UdonList.Reverse(list.AsObjectArray());
        }

        public static void Reverse<T>(this UdonList<T> list, int index, int count)
        {
            Core.UdonList.Reverse(list.AsObjectArray(), index, count);
        }

        public static void Sort<T>(this UdonList<T> list) where T : IComparable
        {
            Core.UdonList.Sort<T>(list.AsObjectArray());
        }

        public static void Sort<T>(this UdonList<T> list, int index, int count) where T : IComparable
        {
            Core.UdonList.Sort<T>(list.AsObjectArray(), index, count);
        }

        public static T[] ToArray<T>(this UdonList<T> list)
        {
            return Core.UdonList.ToArray<T>(list.AsObjectArray());
        }

        public static void TrimExcess<T>(this UdonList<T> list)
        {
            Core.UdonList.TrimExcess(list.AsObjectArray());
        }

        private static object[] AsObjectArray<T>(this UdonList<T> list)
        {
            return (object[])(object)list;
        }
    }
}
