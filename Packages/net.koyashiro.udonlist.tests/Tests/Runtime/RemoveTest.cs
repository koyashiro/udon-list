using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class RemoveTest : UdonSharpBehaviour
    {
        private void Start()
        {
            var list = UdonList<object>.New(new object[] { 1, 2u, 3f, 4d, 'a', "aaa", 1 });

            Assert.False(list.Remove(-1), this);
            Assert.Equal(new object[] { new object[] { 1, 2u, 3f, 4d, 'a', "aaa", 1 }, 7, null }, list, this);

            Assert.True(list.Remove(1), this);
            Assert.Equal(new object[] { new object[] { 2u, 3f, 4d, 'a', "aaa", 1, 1 }, 6, null }, list, this);

            Assert.True(list.Remove("aaa"), this);
            Assert.Equal(new object[] { new object[] { 2u, 3f, 4d, 'a', 1, 1, 1 }, 5, null }, list, this);

            Assert.True(list.Remove(3f), this);
            Assert.Equal(new object[] { new object[] { 2u, 4d, 'a', 1, 1, 1, 1 }, 4, null }, list, this);

            Assert.True(list.Remove(4d), this);
            Assert.Equal(new object[] { new object[] { 2u, 'a', 1, 1, 1, 1, 1 }, 3, null }, list, this);

            Assert.True(list.Remove('a'), this);
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 2, null }, list, this);

            Assert.True(list.Remove(1), this);
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 1, null }, list, this);

            Assert.True(list.Remove(2u), this);
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 0, null }, list, this);
        }
    }
}
