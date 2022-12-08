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
            Assert.Equal('a', list.GetItem(0), this);
            Assert.Equal('b', list.GetItem(1), this);
            Assert.Equal('c', list.GetItem(2), this);
            Assert.Equal(new char[] { 'a', 'b', 'c' }, list.ToArray(), this);
            Assert.True(list.Remove('b'), this);
            Assert.False(list.Remove('d'), this);
            Assert.Equal('a', list.GetItem(0), this);
            Assert.Equal('c', list.GetItem(1), this);
            Assert.Equal(new char[] { 'a', 'c' }, list.ToArray(), this);
            list.SetItem(1, 'b');
            Assert.Equal(new char[] { 'a', 'b' }, list.ToArray(), this);

            list = UdonCharList.New(new char[] { '0', '1', '2', '3', '4' });
            list.Reverse();
            Assert.Equal(new char[] { '4', '3', '2', '1', '0' }, list.ToArray(), this);
            list.Reverse(1, 3);
            Assert.Equal(new char[] { '4', '1', '2', '3', '0' }, list.ToArray(), this);

            list.Sort();
            Assert.Equal(new char[] { '0', '1', '2', '3', '4' }, list.ToArray(), this);
        }
    }
}
