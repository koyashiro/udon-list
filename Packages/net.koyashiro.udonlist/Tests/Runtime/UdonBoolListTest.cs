using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonBoolListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonBoolList.New();
            list.Add(true);
            list.Add(true);
            list.Add(false);
            Assert.Equal(true, list.GetItem(0));
            Assert.Equal(true, list.GetItem(1));
            Assert.Equal(false, list.GetItem(2));
            Assert.Equal(new bool[] { true, true, false, }, list.ToArray());
            Assert.True(list.Remove(false));
            Assert.False(list.Remove(false));
            Assert.Equal(true, list.GetItem(0));
            Assert.Equal(true, list.GetItem(1));
            Assert.Equal(new bool[] { true, true }, list.ToArray());
            list.SetItem(1, false);
            Assert.Equal(new bool[] { true, false }, list.ToArray());

            list = UdonBoolList.New(new bool[] { false, true, true, false, true });
            list.Reverse();
            Assert.Equal(new bool[] { true, false, true, true, false }, list.ToArray());
            list.Reverse(1, 3);
            Assert.Equal(new bool[] { true, true, true, false, false }, list.ToArray());

            list.Sort();
            Assert.Equal(new bool[] { false, false, true, true, true }, list.ToArray());
        }
    }
}
