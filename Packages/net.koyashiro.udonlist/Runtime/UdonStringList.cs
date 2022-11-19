using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    public class UdonStringList : UdonSharpBehaviour
    {
        public static UdonStringList New()
        {
            return (UdonStringList)(object)UdonGenericList.New();
        }

        public static UdonStringList New(char[] collection)
        {
            return (UdonStringList)(object)UdonGenericList.New(collection);
        }

        public static UdonStringList New(int capacity)
        {
            return (UdonStringList)(object)UdonGenericList.New(capacity);
        }
    }
}
