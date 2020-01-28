

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Block : MonoBehaviour
{
    [SerializeField] AudioClip BreakingSound;
   

    // Fazendo referencia ao GameObject

    Level level;
    GameStatus gameStatus;
    


 
    

    public void Start()
    {

        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
        gameStatus = FindObjectOfType<GameStatus>();


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();


    }

    private void DestroyBlock()
    {

        gameStatus.AddToScore();
        Vector3 posicao = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        AudioSource.PlayClipAtPoint(BreakingSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();

    }

}