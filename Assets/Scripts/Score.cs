using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public int bscore;
    
    
    public Text ScoreText;
    
/// <summary>
/// This is the players main score and displays the text
/// </summary>
    
    void Update()
    {
        ScoreText.text = bscore.ToString();
        

    }
}
