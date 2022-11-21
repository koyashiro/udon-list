using UnityEngine;
using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    [AddComponentMenu("")]
    public class UdonList : UdonSharpBehaviour
    {
        public static UdonList New()
        {
            return (UdonList)(object)UdonGenericList.New();
        }

        public static UdonList New(object[] collection)
        {
            return (UdonList)(object)UdonGenericList.New(collection);
        }

        public static UdonList New(int capacity)
        {
            return (UdonList)(object)UdonGenericList.New(capacity);
        }
    }
}
