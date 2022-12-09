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
            var list = UdonList<object>.New();

            list.Add(0);
            Assert.Equal(new object[] { new object[] { 0, null, null, null }, 1, typeof(object) }, list, this);

            list.Add(1);
            Assert.Equal(new object[] { new object[] { 0, 1, null, null }, 2, typeof(object) }, list, this);

            list.Add(2);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, null }, 3, typeof(object) }, list, this);

            list.Add(3);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, 3 }, 4, typeof(object) }, list, this);

            list.Add(4);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, 3, 4, null, null, null }, 5, typeof(object) }, list, this);
        }
    }
}
