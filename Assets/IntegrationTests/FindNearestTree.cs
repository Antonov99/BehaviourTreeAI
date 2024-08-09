using System.Collections;
using System.Collections.Generic;
using Atomic.AI;
using Atomic.Objects;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class FindNearestTree
{
    // A Test behaves as an ordinary method
    
    [Test]
    public void FindNearestTreeSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator FindNearestTreeWithEnumeratorPasses()
    {
        // Arrange
        // Blackboard blackboard = new Blackboard();
        EditorSceneManager.LoadSceneInPlayMode("Assets/IntegrationTests/SampleScene.unity", new LoadSceneParameters(LoadSceneMode.Additive));
        yield return null;
        var blackboard = GameObject.FindObjectOfType<SceneBlackboard>();
        var tree = GameObject.Find("Tree (8)");
        var treeObject =  tree.GetComponent<IAtomicObject>();
        // Act
        
        // Assert
        Assert.IsTrue(blackboard.GetObject(3) == treeObject);
        yield return null;
    }
}
