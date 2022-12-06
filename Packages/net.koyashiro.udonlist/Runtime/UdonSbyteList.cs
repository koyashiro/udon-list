using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonSbyteList : UdonSharpBehaviour
    {
        public static UdonSbyteList New()
        {
            return (UdonSbyteList)(object)UdonList.New();
        }

        public static UdonSbyteList New(sbyte[] collection)
        {
            return (UdonSbyteList)(object)UdonList.New(collection);
        }

        public static UdonSbyteList New(int capacity)
        {
            return (UdonSbyteList)(object)UdonList.New(capacity);
        }
    }
}