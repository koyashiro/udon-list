using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonShortListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<short>.New();
            list.Add((short)100);
            list.Add((short)101);
            list.Add((short)102);
            Assert.Equal((short)100, list.Get(0), this);
            Assert.Equal((short)101, list.Get(1), this);
            Assert.Equal((short)102, list.Get(2), this);
            Assert.Equal(new short[] { 100, 101, 102 }, list.ToArray(), this);
            Assert.True(list.Remove((short)101), this);
            Assert.False(list.Remove((short)103), this);
            Assert.Equal((short)100, list.Get(0), this);
            Assert.Equal((short)102, list.Get(1), this);
            Assert.Equal(new short[] { 100, 102 }, list.ToArray(), this);
            list.Set(1, (short)101);
            Assert.Equal(new short[] { 100, 101 }, list.ToArray(), this);

            list = UdonList<short>.New(new short[] { 0, 1, 2, 3, 4 });
            list.Reverse();
            Assert.Equal(new short[] { 4, 3, 2, 1, 0 }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new short[] { 4, 1, 2, 3, 0 }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new short[] { 0, 1, 2, 3, 4 }, list.ToArray(), this);
        }
    }
}
