using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList
{
    using Koyashiro.UdonList.Core;

    [AddComponentMenu("")]
    public class UdonBoolList : UdonSharpBehaviour
    {
        public static UdonBoolList New()
        {
            return (UdonBoolList)(object)UdonList.New<bool>();
        }

        public static UdonBoolList New(bool[] collection)
        {
            return (UdonBoolList)(object)UdonList.New(collection);
        }

        public static UdonBoolList New(int capacity)
        {
            return (UdonBoolList)(object)UdonList.New<bool>(capacity);
        }
    }
}
