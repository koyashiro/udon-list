using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class InsertTest : UdonSharpBehaviour
    {
        public void Start()
        {
            Debug.Log("InsertTest");

            var list = UdonObjectList.New();

            list.Insert(0, 0);
            Assert.Equal(new object[] { new object[] { 0, null, null, null }, 1, typeof(object) }, list);

            list.Insert(1, 1);
            Assert.Equal(new object[] { new object[] { 0, 1, null, null }, 2, typeof(object) }, list);

            list.Insert(2, 2);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, null }, 3, typeof(object) }, list);

            list.Insert(3, 3);
            Assert.Equal(new object[] { new object[] { 0, 1, 2, 3 }, 4, typeof(object) }, list);

            list.Insert(0, -1);
            Assert.Equal(new object[] { new object[] { -1, 0, 1, 2, 3, null, null, null }, 5, typeof(object) }, list);

            list.Insert(1, -0.5);
            Assert.Equal(new object[] { new object[] { -1, -0.5, 0, 1, 2, 3, null, null }, 6, typeof(object) }, list);
        }
    }
}
