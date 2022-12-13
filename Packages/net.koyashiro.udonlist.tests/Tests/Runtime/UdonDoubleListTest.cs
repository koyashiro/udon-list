using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonDoubleListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<double>.New();
            list.Add(100d);
            list.Add(101d);
            list.Add(102d);
            Assert.Equal(100d, list.Get(0), this);
            Assert.Equal(101d, list.Get(1), this);
            Assert.Equal(102d, list.Get(2), this);
            Assert.Equal(new double[] { 100d, 101d, 102d }, list.ToArray(), this);
            Assert.True(list.Remove(101d), this);
            Assert.False(list.Remove(103d), this);
            Assert.Equal(100d, list.Get(0), this);
            Assert.Equal(102d, list.Get(1), this);
            Assert.Equal(new double[] { 100d, 102d }, list.ToArray(), this);
            list.Set(1, 101d);
            Assert.Equal(new double[] { 100d, 101d }, list.ToArray(), this);

            list = UdonList<double>.New(new double[] { 0d, 1d, 2d, 3d, 4d });
            list.Reverse();
            Assert.Equal(new double[] { 4d, 3d, 2d, 1d, 0d }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new double[] { 4d, 1d, 2d, 3d, 0d }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new double[] { 0d, 1d, 2d, 3d, 4d }, list.ToArray(), this);
        }
    }
}
