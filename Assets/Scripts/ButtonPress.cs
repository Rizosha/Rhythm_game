using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPress : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite defaultImage;
    public Sprite pressedImage;
   // public bool isColliding;
    public GameObject col;
    public GameObject sc;
    
    public GameObject mu;
    public int points = 10;
   
    public KeyCode keyToPress;


    /// <summary>
    /// This code basically had a few things wrong with it that i have commented out because i didnt know how to destroy a colliding object. 
    /// I tried creating a true/false statement for if the beat is colliding.
    /// In the end i got it to work with simple code in OnTriggerStay2D.
    /// </summary>

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sc = GameObject.Find("Score");
        mu = GameObject.Find("Multiplier");

    }

    /// <summary>
    /// here we have sprites loading in when you press a key. This gives the pushed button effect.
    /// </summary>
    /// 
    void Update()
    {
        
        if (Input.GetKeyDown(keyToPress))
        {
           
            sr.sprite = pressedImage;
          //if(isColliding == true
        }

        if (Input.GetKeyUp(keyToPress))
        {
            sr.sprite = defaultImage;
            //if(isColliding == true
        }


    }

    void OnTriggerStay2D(Collider2D col)
    {   
        if (Input.GetKeyDown(keyToPress))
        {
            // Destroy(col.gameObject);
            col.gameObject.SetActive(false);
            mu.GetComponent<Multiplier>().pointsm += 1;
            sc.GetComponent<Score>().bscore += (points *(mu.GetComponent<Multiplier>().multi));

            //Points();
        }
         
          //  Debug.Log("works");
    }

}
