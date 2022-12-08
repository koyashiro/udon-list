using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonLongList : UdonSharpBehaviour
    {
        public static UdonLongList New()
        {
            return (UdonLongList)(object)UdonList.New<long>();
        }

        public static UdonLongList New(long[] collection)
        {
            return (UdonLongList)(object)UdonList.New(collection);
        }

        public static UdonLongList New(int capacity)
        {
            return (UdonLongList)(object)UdonList.New<long>(capacity);
        }
    }
}
