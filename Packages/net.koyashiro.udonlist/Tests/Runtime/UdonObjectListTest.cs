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
            var list = UdonObjectList.New();
            list.Add(100);
            list.Add(101);
            list.Add(102);
            Assert.Equal(100, list.GetItem(0));
            Assert.Equal(101, list.GetItem(1));
            Assert.Equal(102, list.GetItem(2));
            Assert.Equal(new object[] { 100, 101, 102 }, list.ToArray());
            Assert.True(list.Remove(101));
            Assert.False(list.Remove(103));
            Assert.Equal(100, list.GetItem(0));
            Assert.Equal(102, list.GetItem(1));
            Assert.Equal(new object[] { 100, 102 }, list.ToArray());
            list.SetItem(1, 101);
            Assert.Equal(new object[] { 100, 101 }, list.ToArray());

            list = UdonObjectList.New(new object[] { 0, 1, 2, 3, 4 });
            list.Reverse();
            Assert.Equal(new object[] { 4, 3, 2, 1, 0 }, list.ToArray());
            list.Reverse(1, 3);
            Assert.Equal(new object[] { 4, 1, 2, 3, 0 }, list.ToArray());

            // Not supported
            //list.Sort();
            //Assert.Equal(new object[] { 0, 1, 2, 3, 4 }, list.ToArray());
        }
    }
}
