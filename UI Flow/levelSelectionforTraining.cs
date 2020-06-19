using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelSelectionforTraining : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void button1()
    {
        PlayerPrefs.SetInt("levelid", 0);
        SceneManager.LoadScene("Training");
    }
    public void button2()
    {
        PlayerPrefs.SetInt("levelid", 1);
        SceneManager.LoadScene("Training");
    }
    public void button3()
    {
        PlayerPrefs.SetInt("levelid", 2);
        SceneManager.LoadScene("Training");
    }

    public void st()
    {
        SceneManager.LoadScene("Structure Identification");
    }
}
