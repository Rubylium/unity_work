using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame() => SceneManager.LoadScene("Scenes/SampleScene");

    public void ReturnToMainMenu() => SceneManager.LoadScene("Scenes/main_menu");

    public void QuitGame()
    {
        Application.Quit();
        
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #endif
    }
}
