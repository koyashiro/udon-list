using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class NewTest : UdonSharpBehaviour
    {
        private void Start()
        {
            Assert.Equal(new object[] { new object[0], 0, null }, UdonList<object>.New(), this);
            Assert.Equal(new object[] { new object[1], 0, null }, UdonList<object>.New(1), this);
            Assert.Equal(new object[] { new object[2], 0, null }, UdonList<object>.New(2), this);
            Assert.Equal(new object[] { new object[3], 0, null }, UdonList<object>.New(3), this);
            Assert.Equal(new object[] { new object[4], 0, null }, UdonList<object>.New(4), this);
            Assert.Equal(new object[] { new object[] { 1, 2, 3 }, 3, null }, UdonList<object>.New(new object[] { 1, 2, 3 }), this);
        }
    }
}
