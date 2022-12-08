using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonIntList : UdonSharpBehaviour
    {
        public static UdonIntList New()
        {
            return (UdonIntList)(object)UdonList.New<int>();
        }

        public static UdonIntList New(int[] collection)
        {
            return (UdonIntList)(object)UdonList.New(collection);
        }

        public static UdonIntList New(int capacity)
        {
            return (UdonIntList)(object)UdonList.New<int>(capacity);
        }
    }
}
