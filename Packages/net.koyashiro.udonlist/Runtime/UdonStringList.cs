using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonStringList : UdonSharpBehaviour
    {
        public static UdonStringList New()
        {
            return (UdonStringList)(object)UdonList.New();
        }

        public static UdonStringList New(char[] collection)
        {
            return (UdonStringList)(object)UdonList.New(collection);
        }

        public static UdonStringList New(int capacity)
        {
            return (UdonStringList)(object)UdonList.New(capacity);
        }
    }
}
