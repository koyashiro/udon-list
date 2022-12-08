using System;
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
            Assert.Equal(new GameObject[] { gameObjects[0], gameObjects[2] }, gameObjectList.ToArray<GameObject>(), this);
            gameObjectList.SetItem(1, gameObjects[1]);
            Assert.Equal(gameObjects[1], gameObjectList.GetItem<GameObject>(1), this);

            gameObjectList = UdonGenericList.New(gameObjects);
            gameObjectList.Reverse();
            Assert.Equal(new GameObject[] { gameObjects[3], gameObjects[2], gameObjects[1], gameObjects[0] },
                gameObjectList.ToArray<GameObject>(), this);

            var guidList = UdonGenericList.New<Guid>();
            for (var i = 0; i < 100; i++)
            {
                guidList.Add(Guid.NewGuid());
            }
            guidList.Sort<Guid>();
            var sortedGuidArray = guidList.ToArray<Guid>();
            System.Array.Reverse(sortedGuidArray, 0, sortedGuidArray.Length);
            guidList.Reverse();
            Assert.Equal(sortedGuidArray, guidList.ToArray<Guid>(), this);
        }
    }
}
