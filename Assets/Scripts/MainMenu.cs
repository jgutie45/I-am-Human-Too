using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayStory()
    {
        SceneManager.LoadScene("StoryScene");
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("CreditsScene");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
