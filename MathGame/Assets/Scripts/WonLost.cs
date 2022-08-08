using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WonLost : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Restartb;
    public GameObject Quitb;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        SceneManager.LoadScene("Start");
        Time.timeScale = 1;
        print("qt");
    }
}
