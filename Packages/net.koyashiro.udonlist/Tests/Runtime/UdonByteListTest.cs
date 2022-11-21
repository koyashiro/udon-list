using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonByteListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonByteList.New();
            list.Add((byte)100);
            list.Add((byte)101);
            list.Add((byte)102);
            Assert.Equal((byte)100, list.GetItem(0));
            Assert.Equal((byte)101, list.GetItem(1));
            Assert.Equal((byte)102, list.GetItem(2));
            Assert.Equal(new byte[] { 100, 101, 102 }, list.ToArray());
            Assert.True(list.Remove(101));
            Assert.False(list.Remove(103));
            Assert.Equal((byte)100, list.GetItem(0));
            Assert.Equal((byte)102, list.GetItem(1));
            Assert.Equal(new byte[] { 100, 102 }, list.ToArray());
            list.SetItem(1, (byte)101);
            Assert.Equal(new byte[] { 100, 101 }, list.ToArray());
        }
    }
}
