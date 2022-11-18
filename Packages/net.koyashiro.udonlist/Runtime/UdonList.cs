using UdonSharp;

namespace Koyashiro.UdonList
{
    public class UdonList : UdonSharpBehaviour
    {
        public static UdonList New()
        {
            return New(0);
        }

        public static UdonList New(object[] items)
        {
            var rawArray = (object[])items.Clone();
            var count = rawArray.Length;

            return (UdonList)(object)(new object[] { rawArray, count });
        }

        public static UdonList New(int capacity)
        {
            var rawArray = new object[capacity];
            var count = 0;

            return (UdonList)(object)(new object[] { rawArray, count });
        }
    }
}
