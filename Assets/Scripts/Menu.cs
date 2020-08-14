using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(1);
        Player.score = 0;
    }

    public void ReturnToStart()
    {
        SceneManager.LoadScene(0);
        Player.score = 0;
    }
}
