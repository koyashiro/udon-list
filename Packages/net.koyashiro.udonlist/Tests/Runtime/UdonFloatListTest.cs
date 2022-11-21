using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonFloatListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonFloatList.New();
            list.Add(100f);
            list.Add(101f);
            list.Add(102f);
            Assert.Equal(100f, list.GetItem(0));
            Assert.Equal(101f, list.GetItem(1));
            Assert.Equal(102f, list.GetItem(2));
            Assert.Equal(new float[] { 100f, 101f, 102f }, list.ToArray());
            Assert.True(list.Remove(101f));
            Assert.False(list.Remove(103f));
            Assert.Equal(100f, list.GetItem(0));
            Assert.Equal(102f, list.GetItem(1));
            Assert.Equal(new float[] { 100f, 102f }, list.ToArray());
            list.SetItem(1, 101f);
            Assert.Equal(new float[] { 100f, 101f }, list.ToArray());
        }
    }
}
