using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonUintList : UdonSharpBehaviour
    {
        public static UdonUintList New()
        {
            return (UdonUintList)(object)UdonList.New();
        }

        public static UdonUintList New(uint[] collection)
        {
            return (UdonUintList)(object)UdonList.New(collection);
        }

        public static UdonUintList New(int capacity)
        {
            return (UdonUintList)(object)UdonList.New(capacity);
        }
    }
}