using UnityEngine;
using UdonSharp;
using Koyashiro.UdonList.Generic;

namespace Koyashiro.UdonList
{
    [AddComponentMenu("")]
    public class UdonByteList : UdonSharpBehaviour
    {
        public static UdonByteList New()
        {
            return (UdonByteList)(object)UdonGenericList.New();
        }

        public static UdonByteList New(byte[] collection)
        {
            return (UdonByteList)(object)UdonGenericList.New(collection);
        }

        public static UdonByteList New(int capacity)
        {
            return (UdonByteList)(object)UdonGenericList.New(capacity);
        }
    }
}
