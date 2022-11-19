using UdonSharp;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

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
            list.ToArray();
            Assert.Equal(new char[] { 'a', 'b', 'c' }, list.ToArray());
            Assert.True(list.Remove('b'));
            Assert.False(list.Remove('d'));
            Assert.Equal('a', list.GetItem(0));
            Assert.Equal('c', list.GetItem(1));
            Assert.Equal(new char[] { 'a', 'c' }, list.ToArray());
            list.SetItem(1, 'b');
            Assert.Equal(new char[] { 'a', 'b' }, list.ToArray());
        }
    }
}
