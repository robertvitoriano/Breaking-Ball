using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

   [SerializeField]  int breakableBlocks; //SerializeField for debugging purposes
    SceneLoader loader;
 
  
    public void Start()
    {
        loader = FindObjectOfType<SceneLoader>();
    }
    public void CountBreakableBlocks()
    {
        breakableBlocks++;

    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
      

        if(breakableBlocks ==0)
        {
            loader.LoadNextScene(); 

        }
    }
}
