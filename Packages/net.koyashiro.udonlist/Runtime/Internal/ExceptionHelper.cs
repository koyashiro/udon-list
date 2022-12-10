using UnityEngine;

namespace Koyashiro.UdonList.Internal
{
    public static class ExceptionHelper
    {
        private const string TAG = "UdonList";
        private const string COLOR_TAG = "red";
        private const string COLOR_EXCEPTION = "lime";
        private const string COLOR_PARAMETER = "cyan";
        private const string COLOR_ACTUAL_VALUE = "magenta";

        public static void ThrowArgumentException()
        {
            LogErrorMessage("System.ArgumentException", "Value does not fall within the expected range.");
        }

        public static void ThrowArgumentNullException(string paramName)
        {
            LogErrorMessage("System.ArgumentNullException", "Value cannot be null.", paramName);
        }

        public static void ThrowArgumentOutOfRangeException()
        {
            LogErrorMessage("System.ArgumentOutOfRangeException", "Specified argument was out of the range of valid values.");
        }

        public static void ThrowIndexOutOfRangeException()
        {
            LogErrorMessage("System.IndexOutOfRangeException", "Index was outside the bounds of the array.");
        }

        private static void LogErrorMessage(string exception, string message)
        {
            Debug.LogError($"[<color={COLOR_TAG}>{TAG}</color>] <color={COLOR_EXCEPTION}>{exception}</color>: {message}");
        }

        private static void LogErrorMessage(string exception, string message, string paramName)
        {
            Debug.LogError($"[<color={COLOR_TAG}>{TAG}</color>] <color={COLOR_EXCEPTION}>{exception}</color>: {message} (Parameter '<color={COLOR_PARAMETER}>{paramName}</color>')");
        }

        private static void LogErrorMessage(string exception, string message, string paramName, object actualValue)
        {
            Debug.LogError($"[<color={COLOR_TAG}>{TAG}</color>] <color={COLOR_EXCEPTION}>{exception}</color>: {message} (Parameter '<color={COLOR_PARAMETER}>{paramName}</color>')\nActual value was <color={COLOR_ACTUAL_VALUE}>{actualValue}</color>.");
        }
    }
}
