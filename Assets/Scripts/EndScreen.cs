using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public Text endScoreText;
    public GameObject p;

    void Start()
    {
        p = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        endScoreText.text = p.GetComponent<Score>().bscore.ToString();

    }
}
