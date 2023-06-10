using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int currentLevel = 1;
    // Start is called before the first frame update
    public void PlayGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(currentLevel);

    }

    public void QuitGame()
    {
        Application.Quit();
    }


    public void SelectionnerLevel1()
    {
        this.currentLevel = 1;
    }

    public void SelectionnerLevel2()
    {
        this.currentLevel = 2;
    }

    public void SelectionnerLevel3()
    {
        this.currentLevel = 3;
    }

    public void SelectionnerLevel4()
    {
        this.currentLevel = 4;
    }

}
