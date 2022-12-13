using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonByteListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<byte>.New();
            list.Add((byte)100);
            list.Add((byte)101);
            list.Add((byte)102);
            Assert.Equal((byte)100, list.GetValue(0), this);
            Assert.Equal((byte)101, list.GetValue(1), this);
            Assert.Equal((byte)102, list.GetValue(2), this);
            Assert.Equal(new byte[] { 100, 101, 102 }, list.ToArray(), this);
            Assert.True(list.Remove((byte)101), this);
            Assert.False(list.Remove((byte)103), this);
            Assert.Equal((byte)100, list.GetValue(0), this);
            Assert.Equal((byte)102, list.GetValue(1), this);
            Assert.Equal(new byte[] { 100, 102 }, list.ToArray(), this);
            list.SetValue(1, (byte)101);
            Assert.Equal(new byte[] { 100, 101 }, list.ToArray(), this);

            list = UdonList<byte>.New(new byte[] { 0, 1, 2, 3, 4 });
            list.Reverse();
            Assert.Equal(new byte[] { 4, 3, 2, 1, 0 }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new byte[] { 4, 1, 2, 3, 0 }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new byte[] { 0, 1, 2, 3, 4 }, list.ToArray(), this);
        }
    }
}
