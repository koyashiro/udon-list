using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList.Tests
{
    public static class Assert
    {
        public static void Equal(object expected, object actual)
        {
            if (!Equals(expected, actual))
            {
                Debug.LogError($"Test failed!\nexpected: {ToDebugString(expected)}    actual: {ToDebugString(actual)}");
            }
        }

        public static void True(bool actual)
        {
            if (!actual)
            {
                Debug.LogError($"Test failed!\nexpected: true    actual: {ToDebugString(actual)}");
            }
        }

        public static void False(bool actual)
        {
            if (actual)
            {
                Debug.LogError($"Test failed!\nexpected: false    actual: {ToDebugString(actual)}");
            }
        }

        [RecursiveMethod]
        private static bool Equals(object objA, object objB)
        {
            if (
                (objA == null && objB == null)
                || (objA == null && objB != null)
                || (objA != null && objB == null)
            )
            {
                return true;
            }

            if (objA.GetType() != objB.GetType())
            {
                return false;
            }

            if (
                objA.GetType() == typeof(object[])
                || objA.GetType() == typeof(string[])
            )
            {
                return Equals((object[])objA, (object[])objB);
            }
            else if (objA.GetType() == typeof(char[]))
            {
                return Equals((char[])objA, (char[])objB);
            }
            else if (objA.GetType() == typeof(byte[]))
            {
                return Equals((byte[])objA, (byte[])objB);
            }
            else if (objA.GetType() == typeof(int[]))
            {
                return Equals((int[])objA, (int[])objB);
            }
            else if (objA.GetType() == typeof(uint[]))
            {
                return Equals((uint[])objA, (uint[])objB);
            }
            else if (objA.GetType() == typeof(float[]))
            {
                return Equals((float[])objA, (float[])objB);
            }
            else if (objA.GetType() == typeof(double[]))
            {
                return Equals((double[])objA, (double[])objB);
            }
            else
            {
                return object.Equals(objA, objB);
            }
        }

        [RecursiveMethod]
        private static bool Equals<TA, TB>(TA[] objA, TB[] objB)
        {
            if (
                (objA == null && objB == null)
                || (objA == null && objB != null)
                || (objA != null && objB == null)
            )
            {
                return true;
            }

            if (objA.GetType() != objB.GetType())
            {
                return false;
            }

            if (objA.Length != objB.Length)
            {
                return false;
            }

            for (var i = 0; i < objA.Length; i++)
            {
                if (!Equals(objA[i], objA[i]))
                {
                    return false;
                }
            }

            return true;
        }

        [RecursiveMethod]
        public static string ToDebugString(object obj)
        {
            if (obj == null)
            {
                return "null";
            }

            var objType = obj.GetType();
            if (
                objType == typeof(object[])
                || objType == typeof(string[])
                || objType == typeof(char[])
                || objType == typeof(byte[])
                || objType == typeof(int[])
                || objType == typeof(uint[])
                || objType == typeof(float[])
                || objType == typeof(double[])
            )
            {
                var array = (object[])obj;

                var s = "[";
                for (var i = 0; i < array.Length; i++)
                {
                    if (i != 0)
                    {
                        s += ", ";
                    }

                    s += ToDebugString(array[i]);
                }
                s += "]";
                return s;
            }
            else if (objType == typeof(string))
            {
                return $"\"{obj}\"";
            }
            else
            {
                return obj.ToString();
            }
        }
    }
}
