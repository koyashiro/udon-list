using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList.Test
{
    public class Assert : UdonSharpBehaviour
    {
        public static void Equal(object expected, object actual)
        {
            if (!Equals(expected, actual))
            {
                Debug.LogError($"Test failed!\nexpected: {ToDebugString(expected)}    actual: {ToDebugString(actual)}");
            }
        }

        [RecursiveMethod]
        private static bool Equals(object objA, object objB)
        {
            if (objA == null && objB == null)
            {
                return true;
            }

            if ((objA == null && objB != null) || (objA != null && objB == null))
            {
                return false;
            }

            if (objA.GetType() != objB.GetType())
            {
                return false;
            }

            if (objA.GetType() == typeof(object[]))
            {
                var arrayA = (object[])objA;
                var arrayB = (object[])objB;

                if (arrayA.Length != arrayB.Length)
                {
                    return false;
                }

                for (var i = 0; i < arrayA.Length; i++)
                {
                    if (!Equals(arrayA[i], arrayB[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return object.Equals(objA, objB);
            }
        }

        [RecursiveMethod]
        private static string ToDebugString(object obj)
        {
            if (obj == null)
            {
                return "null";
            }

            var objType = obj.GetType();
            if (objType == typeof(object[]))
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
