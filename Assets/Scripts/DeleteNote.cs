using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteNote : MonoBehaviour
{
    public GameObject sc;
    public GameObject mu; 

    /// <summary>
    /// This code basically sets the beats inactive from the pool and takes away 5 points from player along
    /// with setting multiplier points to 0.
    /// </summary>

    void Start()
    {
  
        sc = GameObject.Find("Score");
        mu = GameObject.Find("Multiplier");

    }
    void OnCollisionEnter2D(Collision2D col)
    {
       // Debug.Log("works");
        if(col.gameObject.tag == "Beat")
        {
            // Destroy(col.gameObject);
            col.gameObject.SetActive(false);
            sc.GetComponent<Score>().bscore -= 5;
            mu.GetComponent<Multiplier>().pointsm = 0;
        }
    }
}
