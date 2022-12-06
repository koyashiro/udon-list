using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonUintListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonUintList.New();
            list.Add(100u);
            list.Add(101u);
            list.Add(102u);
            Assert.Equal(100u, list.GetItem(0));
            Assert.Equal(101u, list.GetItem(1));
            Assert.Equal(102u, list.GetItem(2));
            Assert.Equal(new uint[] { 100u, 101u, 102u }, list.ToArray());
            Assert.True(list.Remove(101u));
            Assert.False(list.Remove(103u));
            Assert.Equal(100u, list.GetItem(0));
            Assert.Equal(102u, list.GetItem(1));
            Assert.Equal(new uint[] { 100u, 102u }, list.ToArray());
            list.SetItem(1, 101u);
            Assert.Equal(new uint[] { 100u, 101u }, list.ToArray());

            list = UdonUintList.New(new uint[] { 0u, 1u, 2u, 3u, 4u });
            list.Reverse();
            Assert.Equal(new uint[] { 4u, 3u, 2u, 1u, 0u }, list.ToArray());
            list.Reverse(1, 3);
            Assert.Equal(new uint[] { 4u, 1u, 2u, 3u, 0u }, list.ToArray());

            list.Sort();
            Assert.Equal(new uint[] { 0u, 1u, 2u, 3u, 4u }, list.ToArray());
        }
    }
}
