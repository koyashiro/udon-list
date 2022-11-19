using UdonSharp;

namespace Koyashiro.UdonList
{
    public class UdonDoubleList : UdonSharpBehaviour
    {
        public static UdonDoubleList New()
        {
            return (UdonDoubleList)(object)UdonList.New();
        }

        public static UdonDoubleList New(string[] items)
        {
            return (UdonDoubleList)(object)UdonList.New(items);
        }

        public static UdonDoubleList New(int capacity)
        {
            return (UdonDoubleList)(object)UdonList.New(capacity);
        }
    }
}
