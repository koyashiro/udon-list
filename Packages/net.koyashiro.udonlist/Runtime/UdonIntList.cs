using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    public class UdonIntList : UdonSharpBehaviour
    {
        public static UdonIntList New()
        {
            return (UdonIntList)(object)UdonGenericList.New();
        }

        public static UdonIntList New(int[] collection)
        {
            return (UdonIntList)(object)UdonGenericList.New(collection);
        }

        public static UdonIntList New(int capacity)
        {
            return (UdonIntList)(object)UdonGenericList.New(capacity);
        }
    }
}
