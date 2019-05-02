using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // STARTA SPELET
    public void PlayGame()
    {
        // Load scene "Ground" -- just change names later!
        SceneManager.LoadScene("Ground");
        
        // Just load NEXT scene in queue -- go into FILE -> BUILD SETTINGS -> DRAG SCENES INTO QUEUE
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit game!");
        Application.Quit();

    }
}
