using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonCharListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonCharList.New();
            list.Add('a');
            list.Add('b');
            list.Add('c');
            Assert.Equal('a', list.GetItem(0));
            Assert.Equal('b', list.GetItem(1));
            Assert.Equal('c', list.GetItem(2));
            Assert.Equal(new char[] { 'a', 'b', 'c' }, list.ToArray());
            Assert.True(list.Remove('b'));
            Assert.False(list.Remove('d'));
            Assert.Equal('a', list.GetItem(0));
            Assert.Equal('c', list.GetItem(1));
            Assert.Equal(new char[] { 'a', 'c' }, list.ToArray());
            list.SetItem(1, 'b');
            Assert.Equal(new char[] { 'a', 'b' }, list.ToArray());

            list = UdonCharList.New(new char[] { '0', '1', '2', '3', '4' });
            list.Reverse();
            Assert.Equal(new char[] { '4', '3', '2', '1', '0' }, list.ToArray());
            list.Reverse(1, 3);
            Assert.Equal(new char[] { '4', '1', '2', '3', '0' }, list.ToArray());

            list.Sort();
            Assert.Equal(new char[] { '0', '1', '2', '3', '4' }, list.ToArray());
        }
    }
}
