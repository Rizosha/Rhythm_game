using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beat_Move : MonoBehaviour
{
    // controlls speed
    public float speed;
    public Rigidbody2D rb;

    /// <summary>
    /// //moves beat via Vector2 and time
    /// </summary>

    void Update()
    {
        {
            rb.MovePosition(rb.position + Vector2.down * speed * UnityEngine.Time.deltaTime);
        }
    }

    // old way of colliding that didn't work

  //  void OnTriggerEnter2D(Collision2D col)
  //  {
       // Debug.Log("hit" + col.gameObject.tag);
  //      if (col.gameObject.tag == "BeatEnd")
  //      {
  //          Destroy(col.gameObject);
  //      }

       
    
}

