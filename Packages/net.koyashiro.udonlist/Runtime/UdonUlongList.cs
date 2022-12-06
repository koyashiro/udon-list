using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonUlongList : UdonSharpBehaviour
    {
        public static UdonUlongList New()
        {
            return (UdonUlongList)(object)UdonList.New();
        }

        public static UdonUlongList New(ulong[] collection)
        {
            return (UdonUlongList)(object)UdonList.New(collection);
        }

        public static UdonUlongList New(int capacity)
        {
            return (UdonUlongList)(object)UdonList.New(capacity);
        }
    }
}