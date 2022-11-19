using UdonSharp;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    public class UdonByteListTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonByteList.New();
            list.Add(100);
            list.Add(101);
            list.Add(102);
            Assert.Equal((byte)100, list.GetItem(0));
            Assert.Equal((byte)101, list.GetItem(1));
            Assert.Equal((byte)102, list.GetItem(2));
            list.ToArray();
            Assert.Equal(new byte[] { 100, 101, 102 }, list.ToArray());
            Assert.True(list.Remove(101));
            Assert.False(list.Remove(103));
            Assert.Equal((byte)100, list.GetItem(0));
            Assert.Equal((byte)102, list.GetItem(1));
            Assert.Equal(new byte[] { 100, 102 }, list.ToArray());
            list.SetItem(1, 101);
            Assert.Equal(new byte[] { 100, 101 }, list.ToArray());
        }
    }
}
