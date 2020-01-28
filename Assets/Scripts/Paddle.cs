using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX=2.18f;
    [SerializeField] float maxX=14.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   float mousePosInUnits = Input.mousePosition.x/Screen.width *screenWidthInUnits;
  
        Vector2 paddlePosition = new Vector2(transform.position.x,transform.position.y);
        paddlePosition.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePosition;
    }
}
