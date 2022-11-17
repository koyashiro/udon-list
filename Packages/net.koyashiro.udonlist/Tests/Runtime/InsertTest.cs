using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList.Tests
{
    public class InsertTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonList.New();

            list.Insert(0, 0);
            Assert.Equal(new object[] { new object[] { 0, null, null, null }, 1 }, list);

            list.Insert(1, 1);
            Assert.Equal(new object[] { new object[] { 0, 1, null, null }, 2 }, list);

            list.Insert(2, 2);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, null }, 3 }, list);

            list.Insert(3, 3);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, 3 }, 4 }, list);

            list.Insert(0, -1);
            Assert.Equal(new object[] { new object[] { -1, 0, 1, 2, 3, null, null, null }, 5 }, list);

            list.Insert(1, -0.5);
            Assert.Equal(new object[] { new object[] { -1, -0.5, 0, 1, 2, 3, null, null }, 6 }, list);
        }
    }
}
