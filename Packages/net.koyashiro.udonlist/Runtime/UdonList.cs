using System;
using UnityEngine;

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

        public static int GetCapacity(object[] list)
        {
            ValidateList(list);

            return GetCapacityUnchecked(list);
        }

        public static void SetCapacity(object[] list, int capacity)
        {
            ValidateList(list);

            SetCapacityUnchecked(list, capacity);
        }

        public static int GetCount(object[] list)
        {
            ValidateList(list);

            return GetCountUnchecked(list);
        }

        public static object GetItem(object[] list, int index)
        {
            ValidateList(list);

            if (index < 0 || GetCountUnchecked(list) <= index)
            {
                ThrowArgumentOutOfRangeException();
                return default;
            }

            return GetItemUnchecked(list, index);
        }

        public static void SetItem(object[] list, int index, object item)
        {
            ValidateList(list);

            if (index < 0 || GetCountUnchecked(list) < index)
            {
                ThrowArgumentOutOfRangeException();
                return;
            }

            SetItemUnchecked(list, index, item);
        }

        public static void Add(object[] list, object item)
        {
            ValidateList(list);

            AddUnchecked(list, item);
        }

        public static void AddRange(object[] list, object[] collection)
        {
            ValidateList(list);

            foreach (var item in collection)
            {
                AddUnchecked(list, item);
            }
        }

        public static void Clear(object[] list)
        {
            ValidateList(list);

            SetCountUnchecked(list, 0);
        }

        public static bool Contains(object[] list, object item)
        {
            if (!IsList(list))
            {
                return false;
            }

            return IndexOfUnchecked(list, item, 0, GetCountUnchecked(list)) != -1;
        }

        public static void CopyTo(object[] list, int index, object[] array, int arrayIndex, int count)
        {
            ValidateList(list);

            CopyToUnchecked(list, index, array, arrayIndex, count);
        }

        public static void CopyTo(object[] list, object[] array)
        {
            ValidateList(list);

            CopyToUnchecked(list, 0, array, 0, GetCountUnchecked(list));
        }

        public static void CopyTo(object[] list, object[] array, int arrayIndex)
        {
            ValidateList(list);

            CopyToUnchecked(list, 0, array, arrayIndex, GetCountUnchecked(list));
        }

        public static int EnsureCapacity(object[] list, int capacity)
        {
            ValidateList(list);

            SetCapacityUnchecked(list, capacity);
            return capacity;
        }

        public static object[] GetRange(object[] list, int index, int count)
        {
            ValidateList(list);

            var rangeList = New(GetCountUnchecked(list));
            for (var i = 0; i < GetCountUnchecked(list); i++)
            {
                SetItemUnchecked(rangeList, i, GetItemUnchecked(list, i));
            }
            SetCountUnchecked(list, count);
            return rangeList;
        }

        public static int IndexOf(object[] list, object item)
        {
            ValidateList(list);

            return IndexOfUnchecked(list, item, 0, GetCountUnchecked(list));
        }

        public static int IndexOf(object[] list, object item, int index)
        {
            ValidateList(list);

            return IndexOfUnchecked(list, item, index, GetCountUnchecked(list));
        }

        public static int IndexOf(object[] list, object item, int index, int count)
        {
            ValidateList(list);

            return IndexOfUnchecked(list, item, index, count);
        }

        public static void Insert(object[] list, int index, object item)
        {
            ValidateList(list);

            InsertUnchecked(list, index, item);
        }

        public static void InsertRange(object[] list, int index, object[] items)
        {
            ValidateList(list);

            for (var i = 0; i < items.Length; i++)
            {
                InsertUnchecked(list, index + i, items[i]);
            }
        }

        public static int LastIndexOf(object[] list, object item)
        {
            ValidateList(list);

            return LastIndexOfUnchecked(list, item, 0, GetCountUnchecked(list));
        }

        public static int LastIndexOf(object[] list, object item, int index)
        {
            ValidateList(list);

            return LastIndexOfUnchecked(list, item, index, GetCountUnchecked(list));
        }

        public static int LastIndexOf(object[] list, object item, int index, int count)
        {
            ValidateList(list);

            return LastIndexOfUnchecked(list, item, index, count);
        }

        public static bool Remove(object[] list, object item)
        {
            ValidateList(list);

            var index = IndexOfUnchecked(list, item, 0, GetCountUnchecked(list));
            if (index == -1)
            {
                return false;
            }

            return RemoveAtUnchecked(list, index);
        }

        public static bool RemoveAt(object[] list, int index)
        {
            ValidateList(list);

            return RemoveAtUnchecked(list, index);
        }

        public static void RemoveRange(object[] list, int index, int count)
        {
            ValidateList(list);

            for (var i = 0; i < count; i++)
            {
                RemoveAtUnchecked(list, i);
            }
        }

        public static void Reverse(object[] list)
        {
            ValidateList(list);

            ReverseUnchecked(list, 0, GetCountUnchecked(list));
        }

        public static void Reverse(object[] list, int index, int count)
        {
            ValidateList(list);

            ReverseUnchecked(list, index, count);
        }

        public static void Sort(object[] list, int index, int count)
        {
            ValidateList(list);

            SortUnchecked(list, index, count);
        }

        public static void Sort(object[] list)
        {
            ValidateList(list);

            SortUnchecked(list, 0, GetCountUnchecked(list));
        }

        public static object[] ToArray(object[] list)
        {
            ValidateList(list);

            return ToArrayUnchecked(list);
        }

        public static void TrimExcess(object[] list)
        {
            ValidateList(list);

            var rawArray = ToArrayUnchecked(list);
            SetRawArrayUnchecked(list, rawArray);
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
                ThrowArgumentNullException(nameof(list));
            }

            if (
                list[0] == null
                || list[0].GetType() != typeof(object[])
                || list[1] == null
                || list[1].GetType() != typeof(int)
                || GetCountUnchecked(list) > GetCapacityUnchecked(list)
            )
            {
                ThrowArgumentException("Invalid list.");
            }
        }

        private static object GetItemUnchecked(object[] list, int index)
        {
            return GetRawArrayUnchecked(list)[index];
        }

        private static void SetItemUnchecked(object[] list, int index, object item)
        {
            GetRawArrayUnchecked(list)[index] = item;
        }

        private static int GetCountUnchecked(object[] list)
        {
            return (int)(((object[])list)[1]);
        }

        private static int GetCapacityUnchecked(object[] list)
        {
            return GetRawArrayUnchecked(list).Length;
        }

        private static void SetCapacityUnchecked(object[] list, int capacity)
        {
            if (capacity == GetCapacityUnchecked(list))
            {
                return;
            }

            var newRawArray = new object[capacity];
            for (var i = 0; i < GetCapacity(list); i++)
            {
                newRawArray[i] = GetRawArrayUnchecked(list)[i];
            }
            SetRawArrayUnchecked(list, newRawArray);

            if (capacity < GetCountUnchecked(list))
            {
                SetCountUnchecked(list, capacity);
            }
        }

        private static void AddUnchecked(object[] list, object item)
        {
            if (GetCapacityUnchecked(list) <= GetCountUnchecked(list))
            {
                EnsureCapacity(list, NextCapacity(GetCapacityUnchecked(list)));
            }

            SetItemUnchecked(list, GetCount(list), item);
            SetCountUnchecked(list, GetCount(list) + 1);
        }

        private static void CopyToUnchecked(object[] list, int index, object[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = GetItem(list, index + i);
            }
        }

        private static int IndexOfUnchecked(object[] list, object item, int index, int count)
        {
            for (var i = index; i < count; i++)
            {
                if (object.Equals(GetItemUnchecked(list, i), item))
                {
                    return i;
                }
            }
            return -1;
        }

        private static int LastIndexOfUnchecked(object[] list, object item, int index, int count)
        {
            for (var i = count; i >= index; i--)
            {
                if (object.Equals(GetItemUnchecked(list, i), item))
                {
                    return i;
                }
            }

            return -1;
        }

        public static void InsertUnchecked(object[] list, int index, object item)
        {
            if (GetCountUnchecked(list) <= index)
            {
                AddUnchecked(list, item);
            }
            else if (index < 0)
            {
                InsertUnchecked(list, 0, item);
            }
            else
            {
                AddUnchecked(list, GetItemUnchecked(list, GetCountUnchecked(list) - 1));
                for (int i = GetCountUnchecked(list) - 1; i >= index + 1; i--)
                {
                    SetItemUnchecked(list, i, GetItemUnchecked(list, i - 1));
                }
                SetItemUnchecked(list, index, item);
            }
        }

        private static bool RemoveAtUnchecked(object[] list, int index)
        {

            if (index < GetCountUnchecked(list) - 1)
            {
                for (var i = index; i < GetCountUnchecked(list) - 1; i++)
                {
                    SetItemUnchecked(list, i, GetItemUnchecked(list, i + 1));
                }
            }
            SetCountUnchecked(list, GetCountUnchecked(list) - 1);

            return true;
        }

        private static void ReverseUnchecked(object[] list, int index, int count)
        {
            Array.Reverse(GetRawArrayUnchecked(list), index, count);
        }

        private static void SortUnchecked(object[] list, int index, int count)
        {
            Array.Sort(GetRawArrayUnchecked(list), index, count);
        }

        private static object[] ToArrayUnchecked(object[] list)
        {
            var array = new object[GetCount(list)];
            Array.Copy(GetRawArrayUnchecked(list), 0, array, 0, GetCount(list));
            return array;
        }

        private static object[] GetRawArrayUnchecked(object[] list)
        {
            return (object[])(((object[])list)[0]);
        }

        private static void SetRawArrayUnchecked(object list, object[] rawArray)
        {
            ((object[])list)[0] = rawArray;
        }

        private static void SetCountUnchecked(object list, int length)
        {
            ((object[])list)[1] = length;
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

        private static void ThrowException(string message)
        {
            // Write error log
            Debug.LogError(message);

            // Raise Exception
            ((object)null).ToString();
        }

        private static void ThrowArgumentException(string message)
        {
            ThrowException($"System.ArgumentException : {message}");
        }

        private static void ThrowArgumentOutOfRangeException()
        {
            ThrowException("System.IndexOutOfRangeException : Index was outside the bounds of the array.");
        }

        private static void ThrowArgumentNullException(string paramName)
        {
            ThrowArgumentException("System.NullReferenceException : Object reference not set to an instance of an object.");
        }
    }
}
