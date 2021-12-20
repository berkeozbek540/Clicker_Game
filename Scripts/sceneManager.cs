using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    public void mainMenu()
    {
        PlayerPrefs.SetInt("currento2", (int)Data.o2);
        SceneManager.LoadScene(0);
    }
    public void upgradeMenu()
    {
        PlayerPrefs.SetInt("currento2", (int)Data.o2);
        SceneManager.LoadScene(1);
    }
    public void skillMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void shopMenu()
    {
        SceneManager.LoadScene(3);
    }

   
}


    
