using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList.Tests
{
    public class RemoveTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonList.New(new object[] { 1, 2u, 3f, 4d, 'a', "aaa", 1 });

            Assert.False(list.Remove(-1));
            Assert.Equal(new object[] { new object[] { 1, 2u, 3f, 4d, 'a', "aaa", 1 }, 7 }, list);

            Assert.True(list.Remove(1));
            Assert.Equal(new object[] { new object[] { 2u, 3f, 4d, 'a', "aaa", 1, 1 }, 6 }, list);

            Assert.True(list.Remove("aaa"));
            Assert.Equal(new object[] { new object[] { 2u, 3f, 4d, 'a', 1, 1, 1 }, 5 }, list);

            Assert.True(list.Remove(3f));
            Assert.Equal(new object[] { new object[] { 2u, 4d, 'a', 1, 1, 1, 1 }, 4 }, list);

            Assert.True(list.Remove(4d));
            Assert.Equal(new object[] { new object[] { 2u, 'a', 1, 1, 1, 1, 1 }, 3 }, list);

            Assert.True(list.Remove('a'));
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 2 }, list);

            Assert.True(list.Remove(1));
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 1 }, list);

            Assert.True(list.Remove(2u));
            Assert.Equal(new object[] { new object[] { 2u, 1, 1, 1, 1, 1, 1 }, 0 }, list);
        }
    }
}
