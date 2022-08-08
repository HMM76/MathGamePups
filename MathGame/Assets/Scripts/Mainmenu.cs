using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    public GameObject startb;
    public GameObject quitb;

    public void Easy()
    {
        SceneManager.LoadScene("Easy");
        Time.timeScale = 1;
    }

    public void Medium()
    {
        SceneManager.LoadScene("Medium");
        Time.timeScale = 1;
    }

    public void Hard()
    {
        SceneManager.LoadScene("Hard");
        Time.timeScale = 1;
    }

    public void Quitm()
    {
        Application.Quit();
        print("qtt");
    }
}
