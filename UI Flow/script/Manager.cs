using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    public GameObject Starting;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        initiliaser();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void initiliaser()
    {
        StartCoroutine(Example());

        Starting.SetActive(true);
    }

     IEnumerator Example()
    {
       // print(Time.time);
        yield return new WaitForSeconds(30);
        //print(Time.time);
    }
    public void Skip()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
