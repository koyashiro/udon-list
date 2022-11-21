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
            Assert.Equal(new object[] { new object[0], 0 }, UdonList.New());
            Assert.Equal(new object[] { new object[1], 0 }, UdonList.New(1));
            Assert.Equal(new object[] { new object[2], 0 }, UdonList.New(2));
            Assert.Equal(new object[] { new object[3], 0 }, UdonList.New(3));
            Assert.Equal(new object[] { new object[4], 0 }, UdonList.New(4));
            Assert.Equal(new object[] { new object[] { 1, 2, 3 }, 3 }, UdonList.New(new object[] { 1, 2, 3 }));
        }
    }
}
