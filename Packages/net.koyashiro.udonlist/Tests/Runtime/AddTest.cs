using UnityEngine;
using UdonSharp;

namespace Koyashiro.UdonList.Tests
{
    public class AddTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonList.New();

            UdonList.Add(list, 0);
            Assert.Equal(new object[] { new object[] { 0, null, null, null }, 1 }, list);

            UdonList.Add(list, 1);
            Assert.Equal(new object[] { new object[] { 0, 1, null, null }, 2 }, list);

            UdonList.Add(list, 2);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, null }, 3 }, list);

            UdonList.Add(list, 3);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, 3 }, 4 }, list);

            UdonList.Add(list, 4);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, 3, 4, null, null, null }, 5 }, list);
        }
    }
}
