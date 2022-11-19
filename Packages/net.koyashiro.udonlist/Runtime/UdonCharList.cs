using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    public class UdonCharList : UdonSharpBehaviour
    {
        public static UdonCharList New()
        {
            return (UdonCharList)(object)UdonGenericList.New();
        }

        public static UdonCharList New(char[] collection)
        {
            return (UdonCharList)(object)UdonGenericList.New(collection);
        }

        public static UdonCharList New(int capacity)
        {
            return (UdonCharList)(object)UdonGenericList.New(capacity);
        }
    }
}
