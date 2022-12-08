using UnityEngine;
using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro.UdonList.Tests
{
    using Koyashiro.UdonList;

    [AddComponentMenu("")]
    public class UdonGenericListTest : UdonSharpBehaviour
    {
        [SerializeField]
        private GameObject[] gameObjects = { };

        public void Start()
        {
            var gameObjectList = UdonGenericList.New<GameObject>();
            gameObjectList.Add(gameObjects[0]);
            gameObjectList.Add(gameObjects[1]);
            gameObjectList.Add(gameObjects[2]);
            Assert.Equal(gameObjects[0], gameObjectList.GetItem<GameObject>(0), this);
            Assert.Equal(gameObjects[1], gameObjectList.GetItem<GameObject>(1), this);
            Assert.Equal(gameObjects[2], gameObjectList.GetItem<GameObject>(2), this);
            Assert.True(gameObjectList.Remove(gameObjects[1]), this);
            Assert.False(gameObjectList.Remove(gameObjects[3]), this);
            Assert.Equal(gameObjects[0], gameObjectList.GetItem<GameObject>(0), this);
            Assert.Equal(gameObjects[2], gameObjectList.GetItem<GameObject>(1), this);
            gameObjectList.SetItem(1, gameObjects[1]);
            Assert.Equal(gameObjects[1], gameObjectList.GetItem<GameObject>(1), this);

            gameObjectList = UdonGenericList.New(gameObjects);
            gameObjectList.Reverse();
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Assert.Equal(gameObjects[gameObjects.Length - 1 - i], gameObjectList.GetItem<GameObject>(i), this);
            }
        }
    }
}
