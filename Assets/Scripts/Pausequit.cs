using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausequit : MonoBehaviour
{
    /// <summary>
    /// This quits the game in the pause menu 
    /// </summary>

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
