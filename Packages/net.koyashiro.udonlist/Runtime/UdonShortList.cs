using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonShortList : UdonSharpBehaviour
    {
        public static UdonShortList New()
        {
            return (UdonShortList)(object)UdonList.New<short>();
        }

        public static UdonShortList New(short[] collection)
        {
            return (UdonShortList)(object)UdonList.New(collection);
        }

        public static UdonShortList New(int capacity)
        {
            return (UdonShortList)(object)UdonList.New<short>(capacity);
        }
    }
}
