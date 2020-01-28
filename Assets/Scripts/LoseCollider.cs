
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{

    public void Start()
    {
    }

   public void OnTriggerEnter2D(Collider2D collision)
    {
       
        SceneManager.LoadScene(4);


        // TENTANDO ZERAR PLACAR
      


    }


}