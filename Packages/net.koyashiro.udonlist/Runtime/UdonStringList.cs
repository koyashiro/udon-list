using UdonSharp;

namespace Koyashiro.UdonList
{
    public class UdonStringList : UdonSharpBehaviour
    {
        public static UdonStringList New()
        {
            return (UdonStringList)(object)UdonList.New();
        }

        public static UdonStringList New(string[] items)
        {
            return (UdonStringList)(object)UdonList.New(items);
        }

        public static UdonStringList New(int capacity)
        {
            return (UdonStringList)(object)UdonList.New(capacity);
        }
    }
}
