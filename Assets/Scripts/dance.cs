using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dance : MonoBehaviour
{
    public Sprite defaultimage;
    public Sprite asprite;
    public Sprite ssprite;
    public Sprite dsprite;
    public Sprite fsprite;
    private SpriteRenderer srend;


    void Start()
    {
        srend = GetComponent<SpriteRenderer>();
  
    }

    void Update()
    {

        if (Input.GetKeyDown("a"))
        {
            srend.sprite = asprite;
        }

        if (Input.GetKeyUp("a"))
        {
            srend.sprite = defaultimage;
        }

        if (Input.GetKeyDown("s"))
        {
            srend.sprite = ssprite;
        }

        if (Input.GetKeyUp("s"))
        {
            srend.sprite = defaultimage;
        }

        if (Input.GetKeyDown("d"))
        {
            srend.sprite = dsprite;
        }

        if (Input.GetKeyUp("d"))
        {
            srend.sprite = defaultimage;
        }

        if (Input.GetKeyDown("f"))
        {
            srend.sprite = fsprite;
        }

        if (Input.GetKeyUp("f"))
        {
            srend.sprite = defaultimage;
        }








    }
}
