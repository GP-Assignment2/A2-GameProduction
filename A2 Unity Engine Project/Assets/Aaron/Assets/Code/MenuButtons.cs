using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
  //Load Scene
  public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Quit Game
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Said I quit");
    }
}
