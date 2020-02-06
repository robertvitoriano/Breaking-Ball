using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] public int pointsPerBlock =  2;
    [SerializeField]  public int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;
   GameStatus scoreLoaded = null;


    private void Awake()
    {
        if (scoreLoaded==null)
        {
            scoreLoaded = FindObjectOfType<GameStatus>();

            DontDestroyOnLoad(gameObject);
        }

        else
        {
            gameObject.SetActive(false);

            Destroy(gameObject);
        }

    }
    

 


    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
      

      
        

        
    }
   


     public void AddToScore()
    {
        currentScore += pointsPerBlock;
        scoreText.text = currentScore.ToString();
    }

    public void resetGame()
    {
        Destroy(gameObject);
        currentScore = 0;
    }
   
}
