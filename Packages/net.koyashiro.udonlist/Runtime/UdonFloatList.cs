using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonFloatList : UdonSharpBehaviour
    {
        public static UdonFloatList New()
        {
            return (UdonFloatList)(object)UdonList.New();
        }

        public static UdonFloatList New(float[] collection)
        {
            return (UdonFloatList)(object)UdonList.New(collection);
        }

        public static UdonFloatList New(int capacity)
        {
            return (UdonFloatList)(object)UdonList.New(capacity);
        }
    }
}