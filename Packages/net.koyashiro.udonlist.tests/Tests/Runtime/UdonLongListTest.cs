using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonLongListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<long>.New();
            list.Add(100L);
            list.Add(101L);
            list.Add(102L);
            Assert.Equal(100L, list.GetValue(0), this);
            Assert.Equal(101L, list.GetValue(1), this);
            Assert.Equal(102L, list.GetValue(2), this);
            Assert.Equal(new long[] { 100L, 101L, 102L }, list.ToArray(), this);
            Assert.True(list.Remove(101L), this);
            Assert.False(list.Remove(103L), this);
            Assert.Equal(100L, list.GetValue(0), this);
            Assert.Equal(102L, list.GetValue(1), this);
            Assert.Equal(new long[] { 100L, 102L }, list.ToArray(), this);
            list.SetValue(1, 101L);
            Assert.Equal(new long[] { 100L, 101L }, list.ToArray(), this);

            list = UdonList<long>.New(new long[] { 0L, 1L, 2L, 3L, 4L });
            list.Reverse();
            Assert.Equal(new long[] { 4L, 3L, 2L, 1L, 0L }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new long[] { 4L, 1L, 2L, 3L, 0L }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new long[] { 0L, 1L, 2L, 3L, 4L }, list.ToArray(), this);
        }
    }
}
