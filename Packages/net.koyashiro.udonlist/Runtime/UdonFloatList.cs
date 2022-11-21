using UnityEngine;
using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    [AddComponentMenu("")]
    public class UdonFloatList : UdonSharpBehaviour
    {
        public static UdonFloatList New()
        {
            return (UdonFloatList)(object)UdonGenericList.New();
        }

        public static UdonFloatList New(float[] collection)
        {
            return (UdonFloatList)(object)UdonGenericList.New(collection);
        }

        public static UdonFloatList New(int capacity)
        {
            return (UdonFloatList)(object)UdonGenericList.New(capacity);
        }
    }
}
