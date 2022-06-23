using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(3);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void RetourMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void SceneRoll()
    {
        SceneManager.LoadScene(1);
    }
   public void SceneExplication()
    {
        SceneManager.LoadScene(2);
    }
}
