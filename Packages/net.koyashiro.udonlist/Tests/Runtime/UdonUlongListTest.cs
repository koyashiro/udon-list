using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonUlongListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonUlongList.New();
            list.Add(100uL);
            list.Add(101uL);
            list.Add(102uL);
            Assert.Equal(100uL, list.GetItem(0), this);
            Assert.Equal(101uL, list.GetItem(1), this);
            Assert.Equal(102uL, list.GetItem(2), this);
            Assert.Equal(new ulong[] { 100uL, 101uL, 102uL }, list.ToArray(), this);
            Assert.True(list.Remove(101uL), this);
            Assert.False(list.Remove(103uL), this);
            Assert.Equal(100uL, list.GetItem(0), this);
            Assert.Equal(102uL, list.GetItem(1), this);
            Assert.Equal(new ulong[] { 100uL, 102uL }, list.ToArray(), this);
            list.SetItem(1, 101uL);
            Assert.Equal(new ulong[] { 100uL, 101uL }, list.ToArray(), this);

            list = UdonUlongList.New(new ulong[] { 0uL, 1uL, 2uL, 3uL, 4uL });
            list.Reverse();
            Assert.Equal(new ulong[] { 4uL, 3uL, 2uL, 1uL, 0uL }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new ulong[] { 4uL, 1uL, 2uL, 3uL, 0uL }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new ulong[] { 0uL, 1uL, 2uL, 3uL, 4uL }, list.ToArray(), this);
        }
    }
}
