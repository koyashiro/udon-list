using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonObjectListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonList<object>.New();
            list.Add(100);
            list.Add(101);
            list.Add(102);
            Assert.Equal(100, list.GetItem(0), this);
            Assert.Equal(101, list.GetItem(1), this);
            Assert.Equal(102, list.GetItem(2), this);
            Assert.Equal(new object[] { 100, 101, 102 }, list.ToArray(), this);
            Assert.True(list.Remove(101), this);
            Assert.False(list.Remove(103), this);
            Assert.Equal(100, list.GetItem(0), this);
            Assert.Equal(102, list.GetItem(1), this);
            Assert.Equal(new object[] { 100, 102 }, list.ToArray(), this);
            list.SetItem(1, 101);
            Assert.Equal(new object[] { 100, 101 }, list.ToArray(), this);

            list = UdonList<object>.New(new object[] { 0, 1, 2, 3, 4 });
            list.Reverse();
            Assert.Equal(new object[] { 4, 3, 2, 1, 0 }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new object[] { 4, 1, 2, 3, 0 }, list.ToArray(), this);

            // Not supported
            //list.Sort();
            //Assert.Equal(new object[] { 0, 1, 2, 3, 4 }, list.ToArray(), this);
        }
    }
}
