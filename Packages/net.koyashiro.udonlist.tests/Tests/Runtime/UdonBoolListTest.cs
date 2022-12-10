using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonBoolListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<bool>.New();
            list.Add(true);
            list.Add(true);
            list.Add(false);
            Assert.Equal(true, list.GetItem(0), this);
            Assert.Equal(true, list.GetItem(1), this);
            Assert.Equal(false, list.GetItem(2), this);
            Assert.Equal(new bool[] { true, true, false, }, list.ToArray(), this);
            Assert.True(list.Remove(false), this);
            Assert.False(list.Remove(false), this);
            Assert.Equal(true, list.GetItem(0), this);
            Assert.Equal(true, list.GetItem(1), this);
            Assert.Equal(new bool[] { true, true }, list.ToArray(), this);
            list.SetItem(1, false);
            Assert.Equal(new bool[] { true, false }, list.ToArray(), this);

            list = UdonList<bool>.New(new bool[] { false, true, true, false, true });
            list.Reverse();
            Assert.Equal(new bool[] { true, false, true, true, false }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new bool[] { true, true, true, false, false }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new bool[] { false, false, true, true, true }, list.ToArray(), this);
        }
    }
}
