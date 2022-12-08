using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class NewTest : UdonSharpBehaviour
    {
        public void Start()
        {
            Debug.Log("NewTest");

            Assert.Equal(new object[] { new object[0], 0, typeof(object) }, UdonObjectList.New());
            Assert.Equal(new object[] { new object[1], 0, typeof(object) }, UdonObjectList.New(1));
            Assert.Equal(new object[] { new object[2], 0, typeof(object) }, UdonObjectList.New(2));
            Assert.Equal(new object[] { new object[3], 0, typeof(object) }, UdonObjectList.New(3));
            Assert.Equal(new object[] { new object[4], 0, typeof(object) }, UdonObjectList.New(4));
            Assert.Equal(new object[] { new object[] { 1, 2, 3 }, 3, typeof(object) }, UdonObjectList.New(new object[] { 1, 2, 3 }));
        }
    }
}
