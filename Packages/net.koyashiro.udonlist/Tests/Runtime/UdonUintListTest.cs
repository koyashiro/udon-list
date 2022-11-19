using UdonSharp;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    public class UdonUintListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonUintList.New();
            list.Add(100);
            list.Add(101);
            list.Add(102);
            Assert.Equal(100u, list.GetItem(0));
            Assert.Equal(101u, list.GetItem(1));
            Assert.Equal(102u, list.GetItem(2));
            list.ToArray();
            Assert.Equal(new uint[] { 100, 101, 102 }, list.ToArray());
            Assert.True(list.Remove(101));
            Assert.False(list.Remove(103));
            Assert.Equal(100u, list.GetItem(0));
            Assert.Equal(102u, list.GetItem(1));
            Assert.Equal(new uint[] { 100, 102 }, list.ToArray());
            list.SetItem(1, 101);
            Assert.Equal(new uint[] { 100, 102 }, list.ToArray());
        }
    }
}
