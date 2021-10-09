using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplier : MonoBehaviour
{
    public int multi;
    public int pointsm;
    public Text MultiText;
   
    /// <summary>
    /// series of if statements that determine the multiplier. If pointsm is equal to 4 or above then change multiplier to x2. 
    /// this happens every 4 beat hits
    /// </summary>
    void Update()
    {
        MultiText.text = "x" + multi.ToString();

       

        if (GetComponent<Multiplier>().pointsm >= 4)
        {
            GetComponent<Multiplier>().multi = 2;
        }

        if (GetComponent<Multiplier>().pointsm >= 8)
        {
            GetComponent<Multiplier>().multi = 3;
        }

        if (GetComponent<Multiplier>().pointsm >= 12)
        {
            GetComponent<Multiplier>().multi = 4;
        }
        if (GetComponent<Multiplier>().pointsm <= 3)
        {
            GetComponent<Multiplier>().multi = 1;
        }
    }
}
