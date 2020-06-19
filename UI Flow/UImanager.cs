using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
   // public GameObject panel;
    public GameObject Gamepause;
    public GameObject gameFail;
    public GameObject gameWin;
    public GameObject UI;
    public static int clicked = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gamePaused()
    {
        Gamepause.SetActive(true);
        UI.SetActive(false);
        Time.timeScale = 0f;
        AudioListener.pause = true;
    }
    public void restart()
    {
        SceneManager.LoadScene("Training");
        Time.timeScale = 1f;
        Gamepause.SetActive(false);
        AudioListener.pause = false;
        collision_control.collision = 0;
        UI.SetActive(true);

    }
    public void quit1()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        gameFail.SetActive(false);
        UI.SetActive(true);
        Gamepause.SetActive(false);
        collision_control.win = 0;
        gameWin.SetActive(false);
    }
    public void resume()
    {
        Time.timeScale = 1f;
        UI.SetActive(true);
        AudioListener.pause = false;
        Gamepause.SetActive(false);
    }
    public void restart1()
    {
        SceneManager.LoadScene("Training");
        Time.timeScale = 1f;
        gameFail.SetActive(false);
        gameWin.SetActive(false);
        AudioListener.pause = false;
        collision_control.collision = 0;
        UI.SetActive(true);


    }
    public void restart2()
    {
        SceneManager.LoadScene("Training");
        Time.timeScale = 1f;
        gameWin.SetActive(false);
        gameFail.SetActive(false);
        collision_control.collision = 0;
        AudioListener.pause = false;
        collision_control.win = 0;
        UI.SetActive(true);


    }
}
