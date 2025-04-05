using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        Console.WriteLine("Play Game Button Clicked");
        Debug.Log("Play Game Button Clicked");
    }
    public void OptionsMenu() {
        Console.WriteLine("Options Menu Button Clicked");
        Debug.Log("Options Menu Button Clicked");
        //SceneManager.LoadScene("_SettingsMenu");
    }
    public void QuitGame() {
        Console.WriteLine("Quit Game Button Clicked");
        Debug.Log("Quit Game Button Clicked");
    }
    public void BackButton() {
        Console.WriteLine("Button Button Clicked");
        Debug.Log("Back Button Clicked");
        //SceneManager.LoadScene("_MainMenu");

    }
}
