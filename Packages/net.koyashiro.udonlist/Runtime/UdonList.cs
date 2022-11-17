namespace Koyashiro.UdonList
{
    public static class UdonList
    {
        public static object[] New()
        {
            var rawArray = new object[0];
            var length = 0;

            return new object[] { rawArray, length };
        }

        public static object[] New(object[] items)
        {
            var rawArray = (object[])items.Clone();
            var length = rawArray.Length;

            return new object[] { rawArray, length };
        }

        public static object[] New(int capacity)
        {
            var rawArray = new object[capacity];
            var length = 0;

            return new object[] { rawArray, length };
        }

        public static int GetCapacity(this object[] list)
        {
            ValidateList(list);

            return UdonListUnchecked.GetCapacityUnchecked(list);
        }

        public static void SetCapacity(this object[] list, int capacity)
        {
            ValidateList(list);

            UdonListUnchecked.SetCapacityUnchecked(list, capacity);
        }

        public static int GetCount(this object[] list)
        {
            ValidateList(list);

            return UdonListUnchecked.GetCountUnchecked(list);
        }

        public static object GetItem(this object[] list, int index)
        {
            ValidateList(list);

            if (index < 0 || UdonListUnchecked.GetCountUnchecked(list) <= index)
            {
                UdonException.ThrowArgumentOutOfRangeException();
                return default;
            }

            return UdonListUnchecked.GetItemUnchecked(list, index);
        }

        public static void SetItem(this object[] list, int index, object item)
        {
            ValidateList(list);

            if (index < 0 || UdonListUnchecked.GetCountUnchecked(list) < index)
            {
                UdonException.ThrowArgumentOutOfRangeException();
                return;
            }

            UdonListUnchecked.SetItemUnchecked(list, index, item);
        }

        public static void Add(this object[] list, object item)
        {
            ValidateList(list);

            UdonListUnchecked.AddUnchecked(list, item);
        }

        public static void AddRange(this object[] list, object[] collection)
        {
            ValidateList(list);

            foreach (var item in collection)
            {
                UdonListUnchecked.AddUnchecked(list, item);
            }
        }

        public static void Clear(this object[] list)
        {
            ValidateList(list);

            UdonListUnchecked.ClearUnchecked(list);
        }

        public static bool Contains(object[] list, object item)
        {
            if (!IsList(list))
            {
                return false;
            }

            return UdonListUnchecked.IndexOfUnchecked(list, item, 0, UdonListUnchecked.GetCountUnchecked(list)) != -1;
        }

        public static void CopyTo(object[] list, int index, object[] array, int arrayIndex, int count)
        {
            ValidateList(list);

            UdonListUnchecked.CopyToUnchecked(list, index, array, arrayIndex, count);
        }

        public static void CopyTo(object[] list, object[] array)
        {
            ValidateList(list);

            UdonListUnchecked.CopyToUnchecked(list, 0, array, 0, UdonListUnchecked.GetCountUnchecked(list));
        }

        public static void CopyTo(object[] list, object[] array, int arrayIndex)
        {
            ValidateList(list);

            UdonListUnchecked.CopyToUnchecked(list, 0, array, arrayIndex, UdonListUnchecked.GetCountUnchecked(list));
        }

        public static int EnsureCapacity(object[] list, int capacity)
        {
            ValidateList(list);

            return UdonListUnchecked.EnsureCapacityUnchecked(list, capacity);
        }

        public static object[] GetRange(object[] list, int index, int count)
        {
            ValidateList(list);

            var rangeList = New(UdonListUnchecked.GetCountUnchecked(list));
            for (var i = 0; i < UdonListUnchecked.GetCountUnchecked(list); i++)
            {
                UdonListUnchecked.SetItemUnchecked(rangeList, i, UdonListUnchecked.GetItemUnchecked(list, i));
            }
            UdonListUnchecked.SetCountUnchecked(list, count);
            return rangeList;
        }

        public static int IndexOf(object[] list, object item)
        {
            ValidateList(list);

            return UdonListUnchecked.IndexOfUnchecked(list, item, 0, UdonListUnchecked.GetCountUnchecked(list));
        }

        public static int IndexOf(object[] list, object item, int index)
        {
            ValidateList(list);

            return UdonListUnchecked.IndexOfUnchecked(list, item, index, UdonListUnchecked.GetCountUnchecked(list));
        }

        public static int IndexOf(object[] list, object item, int index, int count)
        {
            ValidateList(list);

            return UdonListUnchecked.IndexOfUnchecked(list, item, index, count);
        }

        public static void Insert(object[] list, int index, object item)
        {
            ValidateList(list);

            UdonListUnchecked.InsertUnchecked(list, index, item);
        }

        public static void InsertRange(object[] list, int index, object[] items)
        {
            ValidateList(list);

            for (var i = 0; i < items.Length; i++)
            {
                UdonListUnchecked.InsertUnchecked(list, index + i, items[i]);
            }
        }

        public static int LastIndexOf(object[] list, object item)
        {
            ValidateList(list);

            return UdonListUnchecked.LastIndexOfUnchecked(list, item, 0, UdonListUnchecked.GetCountUnchecked(list));
        }

        public static int LastIndexOf(object[] list, object item, int index)
        {
            ValidateList(list);

            return UdonListUnchecked.LastIndexOfUnchecked(list, item, index, UdonListUnchecked.GetCountUnchecked(list));
        }

        public static int LastIndexOf(object[] list, object item, int index, int count)
        {
            ValidateList(list);

            return UdonListUnchecked.LastIndexOfUnchecked(list, item, index, count);
        }

        public static bool Remove(object[] list, object item)
        {
            ValidateList(list);

            var index = UdonListUnchecked.IndexOfUnchecked(list, item, 0, UdonListUnchecked.GetCountUnchecked(list));
            if (index == -1)
            {
                return false;
            }

            return UdonListUnchecked.RemoveAtUnchecked(list, index);
        }

        public static bool RemoveAt(object[] list, int index)
        {
            ValidateList(list);

            return UdonListUnchecked.RemoveAtUnchecked(list, index);
        }

        public static void RemoveRange(object[] list, int index, int count)
        {
            ValidateList(list);

            for (var i = 0; i < count; i++)
            {
                UdonListUnchecked.RemoveAtUnchecked(list, i);
            }
        }

        public static void Reverse(object[] list)
        {
            ValidateList(list);

            UdonListUnchecked.ReverseUnchecked(list, 0, UdonListUnchecked.GetCountUnchecked(list));
        }

        public static void Reverse(object[] list, int index, int count)
        {
            ValidateList(list);

            UdonListUnchecked.ReverseUnchecked(list, index, count);
        }

        public static void Sort(object[] list, int index, int count)
        {
            ValidateList(list);

            UdonListUnchecked.SortUnchecked(list, index, count);
        }

        public static void Sort(object[] list)
        {
            ValidateList(list);

            UdonListUnchecked.SortUnchecked(list, 0, UdonListUnchecked.GetCountUnchecked(list));
        }

        public static object[] ToArray(object[] list)
        {
            ValidateList(list);

            return UdonListUnchecked.ToArrayUnchecked(list);
        }

        public static void TrimExcess(object[] list)
        {
            ValidateList(list);

            var rawArray = UdonListUnchecked.ToArrayUnchecked(list);
            UdonListUnchecked.SetRawArrayUnchecked(list, rawArray);
        }

        public static bool IsList(object[] list)
        {
            if (list == null || list.Length != 2)
            {
                return false;
            }

            if (list[0] == null || list[0].GetType() != typeof(object[]))
            {
                return false;
            }

            if (list[1] == null || list[1].GetType() != typeof(int))
            {
                return false;
            }

            if (GetCount(list) > GetCapacity(list))
            {
                return false;
            }

            return true;
        }

        private static void ValidateList(object[] list)
        {
            if (list == null)
            {
                UdonException.ThrowArgumentNullException(nameof(list));
            }

            if (
                list[0] == null
                || list[0].GetType() != typeof(object[])
                || list[1] == null
                || list[1].GetType() != typeof(int)
                || UdonListUnchecked.GetCountUnchecked(list) > UdonListUnchecked.GetCapacityUnchecked(list)
            )
            {
                UdonException.ThrowArgumentException("Invalid list.");
            }
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
