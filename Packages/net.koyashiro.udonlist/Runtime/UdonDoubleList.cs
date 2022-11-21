using UnityEngine;
using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    [AddComponentMenu("")]
    public class UdonDoubleList : UdonSharpBehaviour
    {
        public static UdonDoubleList New()
        {
            return (UdonDoubleList)(object)UdonGenericList.New();
        }

        public static UdonDoubleList New(double[] collection)
        {
            return (UdonDoubleList)(object)UdonGenericList.New(collection);
        }

        public static UdonDoubleList New(int capacity)
        {
            return (UdonDoubleList)(object)UdonGenericList.New(capacity);
        }
    }
}
