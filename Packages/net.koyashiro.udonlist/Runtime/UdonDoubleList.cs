using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonDoubleList : UdonSharpBehaviour
    {
        public static UdonDoubleList New()
        {
            return (UdonDoubleList)(object)UdonList.New<double>();
        }

        public static UdonDoubleList New(double[] collection)
        {
            return (UdonDoubleList)(object)UdonList.New(collection);
        }

        public static UdonDoubleList New(int capacity)
        {
            return (UdonDoubleList)(object)UdonList.New<double>(capacity);
        }
    }
}
