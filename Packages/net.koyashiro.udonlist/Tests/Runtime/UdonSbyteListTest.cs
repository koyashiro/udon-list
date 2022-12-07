using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonSbyteListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonSbyteList.New();
            list.Add((sbyte)100);
            list.Add((sbyte)101);
            list.Add((sbyte)102);
            Assert.Equal((sbyte)100, list.GetItem(0));
            Assert.Equal((sbyte)101, list.GetItem(1));
            Assert.Equal((sbyte)102, list.GetItem(2));
            Assert.Equal(new sbyte[] { 100, 101, 102 }, list.ToArray());
            Assert.True(list.Remove(101));
            Assert.False(list.Remove(103));
            Assert.Equal((sbyte)100, list.GetItem(0));
            Assert.Equal((sbyte)102, list.GetItem(1));
            Assert.Equal(new sbyte[] { 100, 102 }, list.ToArray());
            list.SetItem(1, (sbyte)101);
            Assert.Equal(new sbyte[] { 100, 101 }, list.ToArray());

            list = UdonSbyteList.New(new sbyte[] { 0, 1, 2, 3, 4 });
            list.Reverse();
            Assert.Equal(new sbyte[] { 4, 3, 2, 1, 0 }, list.ToArray());
            list.Reverse(1, 3);
            Assert.Equal(new sbyte[] { 4, 1, 2, 3, 0 }, list.ToArray());

            list.Sort();
            Assert.Equal(new sbyte[] { 0, 1, 2, 3, 4 }, list.ToArray());
        }
    }
}
