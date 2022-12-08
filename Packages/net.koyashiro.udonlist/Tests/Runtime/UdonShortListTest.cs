using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonShortListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonShortList.New();
            list.Add((short)100);
            list.Add((short)101);
            list.Add((short)102);
            Assert.Equal((short)100, list.GetItem(0), this);
            Assert.Equal((short)101, list.GetItem(1), this);
            Assert.Equal((short)102, list.GetItem(2), this);
            Assert.Equal(new short[] { 100, 101, 102 }, list.ToArray(), this);
            Assert.True(list.Remove(101), this);
            Assert.False(list.Remove(103), this);
            Assert.Equal((short)100, list.GetItem(0), this);
            Assert.Equal((short)102, list.GetItem(1), this);
            Assert.Equal(new short[] { 100, 102 }, list.ToArray(), this);
            list.SetItem(1, (short)101);
            Assert.Equal(new short[] { 100, 101 }, list.ToArray(), this);

            list = UdonShortList.New(new short[] { 0, 1, 2, 3, 4 });
            list.Reverse();
            Assert.Equal(new short[] { 4, 3, 2, 1, 0 }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new short[] { 4, 1, 2, 3, 0 }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new short[] { 0, 1, 2, 3, 4 }, list.ToArray(), this);
        }
    }
}
