using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Internal;

    [AddComponentMenu("")]
    public class UdonByteList : UdonSharpBehaviour
    {
        public static UdonByteList New()
        {
            return (UdonByteList)(object)UdonList.New();
        }

        public static UdonByteList New(byte[] collection)
        {
            return (UdonByteList)(object)UdonList.New(collection);
        }

        public static UdonByteList New(int capacity)
        {
            return (UdonByteList)(object)UdonList.New(capacity);
        }
    }
}
