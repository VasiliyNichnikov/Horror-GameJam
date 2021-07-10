using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestPlayerWalk
    {
        private PlayerWalk _walk;

        [SetUp]
        public void SetUp()
        {
            _walk = new GameObject("Player", typeof(PlayerWalk)).GetComponent<PlayerWalk>();
        }

        [TearDown]
        public void TearDown()
        {
            MonoBehaviour.Destroy(_walk);
        }
        
        [UnityTest]
        public IEnumerator TestWalking()
        {
            _walk.Speed = 0.5f;
            Vector3 positionSave = _walk.GetComponent<Transform>().position;
            Vector3 movement = Vector3.forward; // 0 0 1
            _walk.Walking(movement);
            yield return new WaitForSeconds(0.5f);
            Vector3 positionNow = _walk.GetComponent<Transform>().position;
            Assert.AreNotEqual(positionSave, positionNow);
        }
    }
}
