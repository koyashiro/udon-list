using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonDecimalList : UdonSharpBehaviour
    {
        public static UdonDecimalList New()
        {
            return (UdonDecimalList)(object)UdonList.New();
        }

        public static UdonDecimalList New(decimal[] collection)
        {
            return (UdonDecimalList)(object)UdonList.New(collection);
        }

        public static UdonDecimalList New(int capacity)
        {
            return (UdonDecimalList)(object)UdonList.New(capacity);
        }
    }
}
