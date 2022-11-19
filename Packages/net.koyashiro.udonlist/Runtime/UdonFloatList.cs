using UdonSharp;

namespace Koyashiro.UdonList
{
    public class UdonFloatList : UdonSharpBehaviour
    {
        public static UdonFloatList New()
        {
            return (UdonFloatList)(object)UdonList.New();
        }

        public static UdonFloatList New(string[] items)
        {
            return (UdonFloatList)(object)UdonList.New(items);
        }

        public static UdonFloatList New(int capacity)
        {
            return (UdonFloatList)(object)UdonList.New(capacity);
        }
    }
}
