using UdonSharp;

namespace Koyashiro.UdonList
{
    public class UdonUintList : UdonSharpBehaviour
    {
        public static UdonUintList New()
        {
            return (UdonUintList)(object)UdonList.New();
        }

        public static UdonUintList New(string[] items)
        {
            return (UdonUintList)(object)UdonList.New(items);
        }

        public static UdonUintList New(int capacity)
        {
            return (UdonUintList)(object)UdonList.New(capacity);
        }
    }
}
