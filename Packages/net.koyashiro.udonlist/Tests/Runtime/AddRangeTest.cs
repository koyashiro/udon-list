using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    [AddComponentMenu("")]
    public class AddRangeTest : UdonSharpBehaviour
    {
        public void Start()
        {
            var list = UdonObjectList.New(new object[] { 0 });
            list.AddRange(new object[] { 0, null, 1, "2", 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            Assert.Equal(new object[] { new object[] { 0, 0, null, 1, "2", 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 15, typeof(object) }, list);
        }
    }
}
