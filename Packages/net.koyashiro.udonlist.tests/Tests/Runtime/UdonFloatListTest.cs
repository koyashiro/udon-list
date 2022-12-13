using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonFloatListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<float>.New();
            list.Add(100f);
            list.Add(101f);
            list.Add(102f);
            Assert.Equal(100f, list.GetValue(0), this);
            Assert.Equal(101f, list.GetValue(1), this);
            Assert.Equal(102f, list.GetValue(2), this);
            Assert.Equal(new float[] { 100f, 101f, 102f }, list.ToArray(), this);
            Assert.True(list.Remove(101f), this);
            Assert.False(list.Remove(103f), this);
            Assert.Equal(100f, list.GetValue(0), this);
            Assert.Equal(102f, list.GetValue(1), this);
            Assert.Equal(new float[] { 100f, 102f }, list.ToArray(), this);
            list.SetValue(1, 101f);
            Assert.Equal(new float[] { 100f, 101f }, list.ToArray(), this);

            list = UdonList<float>.New(new float[] { 0f, 1f, 2f, 3f, 4f });
            list.Reverse();
            Assert.Equal(new float[] { 4f, 3f, 2f, 1f, 0f }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new float[] { 4f, 1f, 2f, 3f, 0f }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new float[] { 0f, 1f, 2f, 3f, 4f }, list.ToArray(), this);
        }
    }
}
