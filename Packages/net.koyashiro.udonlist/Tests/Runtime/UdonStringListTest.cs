using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonStringListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonStringList.New();
            list.Add("first");
            list.Add("second");
            list.Add("third");
            Assert.Equal("first", list.GetItem(0), this);
            Assert.Equal("second", list.GetItem(1), this);
            Assert.Equal("third", list.GetItem(2), this);
            Assert.Equal(new string[] { "first", "second", "third" }, list.ToArray(), this);
            Assert.True(list.Remove("second"), this);
            Assert.False(list.Remove("fourth"), this);
            Assert.Equal("first", list.GetItem(0), this);
            Assert.Equal("third", list.GetItem(1), this);
            Assert.Equal(new string[] { "first", "third" }, list.ToArray(), this);
            list.SetItem(1, "second");
            Assert.Equal(new string[] { "first", "second" }, list.ToArray(), this);

            list = UdonStringList.New(new string[] { "0", "1", "2", "3", "4" });
            list.Reverse();
            Assert.Equal(new string[] { "4", "3", "2", "1", "0" }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new string[] { "4", "1", "2", "3", "0" }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new string[] { "0", "1", "2", "3", "4" }, list.ToArray(), this);
        }
    }
}
