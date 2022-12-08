using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonUshortListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonUshortList.New();
            list.Add((ushort)100);
            list.Add((ushort)101);
            list.Add((ushort)102);
            Assert.Equal((ushort)100, list.GetItem(0), this);
            Assert.Equal((ushort)101, list.GetItem(1), this);
            Assert.Equal((ushort)102, list.GetItem(2), this);
            Assert.Equal(new ushort[] { 100, 101, 102 }, list.ToArray(), this);
            Assert.True(list.Remove((ushort)101), this);
            Assert.False(list.Remove((ushort)103), this);
            Assert.Equal((ushort)100, list.GetItem(0), this);
            Assert.Equal((ushort)102, list.GetItem(1), this);
            Assert.Equal(new ushort[] { 100, 102 }, list.ToArray(), this);
            list.SetItem(1, (ushort)101);
            Assert.Equal(new ushort[] { 100, 101 }, list.ToArray(), this);

            list = UdonUshortList.New(new ushort[] { 0, 1, 2, 3, 4 });
            list.Reverse();
            Assert.Equal(new ushort[] { 4, 3, 2, 1, 0 }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new ushort[] { 4, 1, 2, 3, 0 }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new ushort[] { 0, 1, 2, 3, 4 }, list.ToArray(), this);
        }
    }
}
