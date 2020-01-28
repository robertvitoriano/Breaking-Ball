using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Paddle paddle1;
    [SerializeField] float XVelocity = 2f;
    [SerializeField] float YVelocity = 10f;
    [SerializeField] AudioClip[] BallSounds;


    Vector2 ballPaddleDistance = new Vector2();
    bool hasLaunched = false;
    bool hasStarted = false;

    //Cached component Reference

    AudioSource Player;



    void Start()
    {  // getting distance between Pivots points
        ballPaddleDistance = transform.position - paddle1.transform.position;

        //GET AUDIO SOURCE
        Player = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        LockBallToPaddle(); //hasStarted foi inicializado como false, então esse método é ativado

        LaunchOnMouseClick(); //Quando acontece o click, hasStarted fica true, então a bola não fica mais travada
    }

    private void LaunchOnMouseClick()
    {
       if(Input.GetMouseButtonDown(0))
        {
            if (!hasLaunched)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(XVelocity, YVelocity);
                hasLaunched = true;
            }
            hasStarted = true; //hasStarted fica true, então a bola não pode mais ser atirada
            
        }
        
    }
    

    private void LockBallToPaddle()
    {  
        Vector2 paddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePosition + ballPaddleDistance;
     

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            // Toca o som mas ele pode ser interrompido
            //  GetComponent<AudioSource>().Play();

            //Toca o som completo
            AudioClip Sound= BallSounds[UnityEngine.Random.Range(0, BallSounds.Length)];


            Player.PlayOneShot(Sound);
         
        }
    }

}
