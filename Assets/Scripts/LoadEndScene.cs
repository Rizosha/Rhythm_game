using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndScene : MonoBehaviour
{
    [SerializeField]
    public float delayBeforeLoading = 235f;
    [SerializeField]
    public string sceneToLoad;
    private float timeElapsed;

    /// <summary>
    /// This adds a delay to load the main menu when the song finishes.
    /// </summary>
    /// 

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading) 
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
