using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    
    public static bool cameraLoaded = false;

    private void Awake()
    {
        // PARA  A MÚSICA NÃO PARAR
        if (!cameraLoaded)
        {
            cameraLoaded = true;

            DontDestroyOnLoad(gameObject);
        }

        else
        {
            gameObject.SetActive(false);

            Destroy(gameObject);
        }
    }

}

