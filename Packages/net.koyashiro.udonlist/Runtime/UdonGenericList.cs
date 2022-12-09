using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonGenericList<T> : UdonSharpBehaviour
    {
        public static UdonGenericList<T> New()
        {
            return (UdonGenericList<T>)(object)UdonList.New<T>();
        }

        public static UdonGenericList<T> New(T[] collection)
        {
            return (UdonGenericList<T>)(object)UdonList.New(collection);
        }

        public static UdonGenericList<T> New(int capacity)
        {
            return (UdonGenericList<T>)(object)UdonList.New<T>(capacity);
        }
    }
}
