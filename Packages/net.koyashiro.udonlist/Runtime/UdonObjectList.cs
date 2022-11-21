using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Internal;

    [AddComponentMenu("")]
    public class UdonObjectList : UdonSharpBehaviour
    {
        public static UdonObjectList New()
        {
            return (UdonObjectList)(object)UdonList.New();
        }

        public static UdonObjectList New(object[] collection)
        {
            return (UdonObjectList)(object)UdonList.New(collection);
        }

        public static UdonObjectList New(int capacity)
        {
            return (UdonObjectList)(object)UdonList.New(capacity);
        }
    }
}
