using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class AddTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonObjectList.New();

            list.Add(0);
            Assert.Equal(new object[] { new object[] { 0, null, null, null }, 1 }, list);

            list.Add(1);
            Assert.Equal(new object[] { new object[] { 0, 1, null, null }, 2 }, list);

            list.Add(2);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, null }, 3 }, list);

            list.Add(3);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, 3 }, 4 }, list);

            list.Add(4);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, 3, 4, null, null, null }, 5 }, list);
        }
    }
}
