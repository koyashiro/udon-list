using UdonSharp;

namespace Koyashiro.UdonList
{
    public class UdonIntList : UdonSharpBehaviour
    {
        public static UdonIntList New()
        {
            return (UdonIntList)(object)UdonList.New();
        }

        public static UdonIntList New(string[] items)
        {
            return (UdonIntList)(object)UdonList.New(items);
        }

        public static UdonIntList New(int capacity)
        {
            return (UdonIntList)(object)UdonList.New(capacity);
        }
    }
}
