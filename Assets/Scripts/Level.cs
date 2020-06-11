using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int breakableBlocks = 0;

    //cached references
    SceneLoader sceneLoader;

    public void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }

}
