using UnityEngine;
using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    [AddComponentMenu("")]
    public class UdonUintList : UdonSharpBehaviour
    {
        public static UdonUintList New()
        {
            return (UdonUintList)(object)UdonGenericList.New();
        }

        public static UdonUintList New(uint[] collection)
        {
            return (UdonUintList)(object)UdonGenericList.New(collection);
        }

        public static UdonUintList New(int capacity)
        {
            return (UdonUintList)(object)UdonGenericList.New(capacity);
        }
    }
}
