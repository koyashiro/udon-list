using System;

namespace Koyashiro.UdonList
{
    public static class UdonListUnchecked
    {
        public static void ValidateList(object[] list)
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
                || GetCountUnchecked(list) > GetCapacityUnchecked(list)
            )
            {
                UdonException.ThrowArgumentException("Invalid list.");
            }
        }

        public static object GetItemUnchecked(object[] list, int index)
        {
            return GetRawArrayUnchecked(list)[index];
        }

        public static void SetItemUnchecked(object[] list, int index, object item)
        {
            GetRawArrayUnchecked(list)[index] = item;
        }

        public static int GetCountUnchecked(object[] list)
        {
            return (int)(((object[])list)[1]);
        }

        public static int GetCapacityUnchecked(object[] list)
        {
            return GetRawArrayUnchecked(list).Length;
        }

        public static void SetCapacityUnchecked(object[] list, int capacity)
        {
            if (capacity == GetCapacityUnchecked(list))
            {
                return;
            }

            var newRawArray = new object[capacity];
            for (var i = 0; i < UdonListUnchecked.GetCapacityUnchecked(list); i++)
            {
                newRawArray[i] = GetRawArrayUnchecked(list)[i];
            }
            SetRawArrayUnchecked(list, newRawArray);

            if (capacity < GetCountUnchecked(list))
            {
                SetCountUnchecked(list, capacity);
            }
        }

        public static void AddUnchecked(object[] list, object item)
        {
            if (GetCapacityUnchecked(list) <= GetCountUnchecked(list))
            {
                EnsureCapacityUnchecked(list, NextCapacity(GetCapacityUnchecked(list)));
            }

            SetItemUnchecked(list, GetCountUnchecked(list), item);
            SetCountUnchecked(list, GetCountUnchecked(list) + 1);
        }

        public static void ClearUnchecked(object[] list)
        {
            UdonListUnchecked.SetCountUnchecked(list, 0);
        }

        public static void CopyToUnchecked(object[] list, int index, object[] array, int arrayIndex, int count)
        {
            for (var i = 0; i < count; i++)
            {
                array[arrayIndex + i] = GetItemUnchecked(list, index + i);
            }
        }

        public static int EnsureCapacityUnchecked(object[] list, int capacity)
        {
            SetCapacityUnchecked(list, capacity);
            return capacity;
        }

        public static int IndexOfUnchecked(object[] list, object item, int index, int count)
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

        public static int LastIndexOfUnchecked(object[] list, object item, int index, int count)
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

        public static bool RemoveAtUnchecked(object[] list, int index)
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

        public static void ReverseUnchecked(object[] list, int index, int count)
        {
            Array.Reverse(GetRawArrayUnchecked(list), index, count);
        }

        public static void SortUnchecked(object[] list, int index, int count)
        {
            Array.Sort(GetRawArrayUnchecked(list), index, count);
        }

        public static object[] ToArrayUnchecked(object[] list)
        {
            var array = new object[GetCountUnchecked(list)];
            Array.Copy(GetRawArrayUnchecked(list), 0, array, 0, GetCountUnchecked(list));
            return array;
        }

        public static object[] GetRawArrayUnchecked(object[] list)
        {
            return (object[])(((object[])list)[0]);
        }

        public static void SetRawArrayUnchecked(object list, object[] rawArray)
        {
            ((object[])list)[0] = rawArray;
        }

        public static void SetCountUnchecked(object list, int length)
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
    }
}
