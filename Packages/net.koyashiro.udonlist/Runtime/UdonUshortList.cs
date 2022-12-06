using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonUshortList : UdonSharpBehaviour
    {
        public static UdonUshortList New()
        {
            return (UdonUshortList)(object)UdonList.New();
        }

        public static UdonUshortList New(ushort[] collection)
        {
            return (UdonUshortList)(object)UdonList.New(collection);
        }

        public static UdonUshortList New(int capacity)
        {
            return (UdonUshortList)(object)UdonList.New(capacity);
        }
    }
}