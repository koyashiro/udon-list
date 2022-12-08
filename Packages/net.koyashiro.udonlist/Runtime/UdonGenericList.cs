using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonGenericList : UdonSharpBehaviour
    {
        public static UdonGenericList New<T>()
        {
            return (UdonGenericList)(object)UdonList.New<T>();
        }

        public static UdonGenericList New<T>(T[] collection)
        {
            return (UdonGenericList)(object)UdonList.New(collection);
        }

        public static UdonGenericList New<T>(int capacity)
        {
            return (UdonGenericList)(object)UdonList.New<T>(capacity);
        }
    }
}
