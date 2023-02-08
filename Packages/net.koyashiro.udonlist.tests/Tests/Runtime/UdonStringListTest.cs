using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonStringListTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<string>.New();
            list.Add("first");
            list.Add("second");
            list.Add("third");
            Assert.Equal("first", list.GetValue(0), this);
            Assert.Equal("second", list.GetValue(1), this);
            Assert.Equal("third", list.GetValue(2), this);
            Assert.Equal(new string[] { "first", "second", "third" }, list.ToArray(), this);
            Assert.True(list.Remove("second"), this);
            Assert.False(list.Remove("fourth"), this);
            Assert.Equal("first", list.GetValue(0), this);
            Assert.Equal("third", list.GetValue(1), this);
            Assert.Equal(new string[] { "first", "third" }, list.ToArray(), this);
            list.SetValue(1, "second");
            Assert.Equal(new string[] { "first", "second" }, list.ToArray(), this);

            list = UdonList<string>.New(new string[] { "0", "1", "2", "3", "4" });
            list.Reverse();
            Assert.Equal(new string[] { "4", "3", "2", "1", "0" }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new string[] { "4", "1", "2", "3", "0" }, list.ToArray(), this);

            list.SetValue(1, null);
            list.SetValue(2, "");
            list.SetValue(3, null);
            list.Sort();
            Assert.Equal(new string[] { null, null, "", "0", "4" }, list.ToArray(), this);
        }
    }
}
