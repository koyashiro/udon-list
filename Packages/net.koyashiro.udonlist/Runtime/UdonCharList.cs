using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Static;

    [AddComponentMenu("")]
    public class UdonCharList : UdonSharpBehaviour
    {
        public static UdonCharList New()
        {
            return (UdonCharList)(object)UdonList.New();
        }

        public static UdonCharList New(char[] collection)
        {
            return (UdonCharList)(object)UdonList.New(collection);
        }

        public static UdonCharList New(int capacity)
        {
            return (UdonCharList)(object)UdonList.New(capacity);
        }
    }
}
