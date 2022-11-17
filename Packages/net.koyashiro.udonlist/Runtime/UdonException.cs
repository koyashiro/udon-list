using UnityEngine;

namespace Koyashiro.UdonList
{
    public static class UdonException
    {
        public static void ThrowException(string message)
        {
            // Write error log
            Debug.LogError(message);

            // Raise Exception
            ((object)null).ToString();
        }

        public static void ThrowArgumentException(string message)
        {
            ThrowException($"System.ArgumentException : {message}");
        }

        public static void ThrowArgumentOutOfRangeException()
        {
            ThrowException("System.IndexOutOfRangeException : Index was outside the bounds of the array.");
        }

        public static void ThrowArgumentNullException(string paramName)
        {
            ThrowArgumentException("System.NullReferenceException : Object reference not set to an instance of an object.");
        }
    }
}
