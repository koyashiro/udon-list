using UdonSharp;

namespace Koyashiro.UdonList
{
    public class UdonCharList : UdonSharpBehaviour
    {
        public static UdonCharList New()
        {
            return (UdonCharList)(object)UdonList.New();
        }

        public static UdonCharList New(string[] items)
        {
            return (UdonCharList)(object)UdonList.New(items);
        }

        public static UdonCharList New(int capacity)
        {
            return (UdonCharList)(object)UdonList.New(capacity);
        }
    }
}
