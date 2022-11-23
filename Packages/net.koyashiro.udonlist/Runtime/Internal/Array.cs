namespace Koyashiro.UdonList.Internal
{
    using Koyashiro.UdonException;

    public static class Array
    {
        public static void Copy<TS, TD>(TS[] sourceArray, TD[] destinationArray, int length)
        {
            Copy(sourceArray, 0, destinationArray, 0, length);
        }

        public static void Copy<TS, TD>(TS[] sourceArray, int sourceIndex, TD[] destinationArray, int destinationIndex, int length)
        {
            if (sourceArray == null)
            {
                UdonException.ThrowArgumentNullException(nameof(sourceArray));
            }

            if (sourceArray == null)
            {
                UdonException.ThrowArgumentNullException(nameof(sourceArray));
            }

            for (var i = 0; i < length; i++)
            {
                destinationArray[destinationIndex + i] = (TD)(object)(sourceArray[sourceIndex + i]);
            }
        }
    }
}
