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
        }
    }
}
