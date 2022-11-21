using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Internal;

    [AddComponentMenu("")]
    public class UdonIntList : UdonSharpBehaviour
    {
        public static UdonIntList New()
        {
            return (UdonIntList)(object)UdonList.New();
        }

        public static UdonIntList New(int[] collection)
        {
            return (UdonIntList)(object)UdonList.New(collection);
        }

        public static UdonIntList New(int capacity)
        {
            return (UdonIntList)(object)UdonList.New(capacity);
        }
    }
}
