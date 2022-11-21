using UnityEngine;
using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    [AddComponentMenu("")]
    public class UdonObjectList : UdonSharpBehaviour
    {
        public static UdonObjectList New()
        {
            return (UdonObjectList)(object)UdonGenericList.New();
        }

        public static UdonObjectList New(object[] collection)
        {
            return (UdonObjectList)(object)UdonGenericList.New(collection);
        }

        public static UdonObjectList New(int capacity)
        {
            return (UdonObjectList)(object)UdonGenericList.New(capacity);
        }
    }
}
