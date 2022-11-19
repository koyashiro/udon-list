using UdonSharp;

namespace Koyashiro.UdonList
{
    public class UdonByteList : UdonSharpBehaviour
    {
        public static UdonByteList New()
        {
            return (UdonByteList)(object)UdonList.New();
        }

        public static UdonByteList New(string[] items)
        {
            return (UdonByteList)(object)UdonList.New(items);
        }

        public static UdonByteList New(int capacity)
        {
            return (UdonByteList)(object)UdonList.New(capacity);
        }
    }
}
