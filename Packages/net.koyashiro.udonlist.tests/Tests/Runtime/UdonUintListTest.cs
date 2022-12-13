using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonUintListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<uint>.New();
            list.Add(100u);
            list.Add(101u);
            list.Add(102u);
            Assert.Equal(100u, list.GetValue(0), this);
            Assert.Equal(101u, list.GetValue(1), this);
            Assert.Equal(102u, list.GetValue(2), this);
            Assert.Equal(new uint[] { 100u, 101u, 102u }, list.ToArray(), this);
            Assert.True(list.Remove(101u), this);
            Assert.False(list.Remove(103u), this);
            Assert.Equal(100u, list.GetValue(0), this);
            Assert.Equal(102u, list.GetValue(1), this);
            Assert.Equal(new uint[] { 100u, 102u }, list.ToArray(), this);
            list.SetValue(1, 101u);
            Assert.Equal(new uint[] { 100u, 101u }, list.ToArray(), this);

            list = UdonList<uint>.New(new uint[] { 0u, 1u, 2u, 3u, 4u });
            list.Reverse();
            Assert.Equal(new uint[] { 4u, 3u, 2u, 1u, 0u }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new uint[] { 4u, 1u, 2u, 3u, 0u }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new uint[] { 0u, 1u, 2u, 3u, 4u }, list.ToArray(), this);
        }
    }
}
