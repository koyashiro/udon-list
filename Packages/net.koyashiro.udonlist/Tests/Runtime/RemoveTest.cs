using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class RemoveTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonList<object>.New(new object[] { 1, 2u, 3f, 4d, 'a', "aaa", 1 });

            Assert.False(list.Remove(-1), this);
            Assert.Equal(new object[] { new object[] { 1, 2u, 3f, 4d, 'a', "aaa", 1 }, 7, typeof(object) }, list, this);

            Assert.True(list.Remove(1), this);
            Assert.Equal(new object[] { new object[] { 2u, 3f, 4d, 'a', "aaa", 1, 1 }, 6, typeof(object) }, list, this);

            Assert.True(list.Remove("aaa"), this);
            Assert.Equal(new object[] { new object[] { 2u, 3f, 4d, 'a', 1, 1, 1 }, 5, typeof(object) }, list, this);

            Assert.True(list.Remove(3f), this);
            Assert.Equal(new object[] { new object[] { 2u, 4d, 'a', 1, 1, 1, 1 }, 4, typeof(object) }, list, this);

            Assert.True(list.Remove(4d), this);
            Assert.Equal(new object[] { new object[] { 2u, 'a', 1, 1, 1, 1, 1 }, 3, typeof(object) }, list, this);

            Assert.True(list.Remove('a'), this);
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 2, typeof(object) }, list, this);

            Assert.True(list.Remove(1), this);
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 1, typeof(object) }, list, this);

            Assert.True(list.Remove(2u), this);
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 0, typeof(object) }, list, this);
        }
    }
}
