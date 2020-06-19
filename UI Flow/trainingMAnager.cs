using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class trainingMAnager : MonoBehaviour
{
    public GameObject failpanel;
    public GameObject winpanel;
    public GameObject UI;
    public Text timerText;
    public Text timertxt;
    public Text collisionText;
    public float targetTime = 10.0f;
    public GameObject[] SpawnPoints;
    private int Levelid;
    public GameObject[] levels;
    public GameObject car;
    private float gametime = 0f;
    void Awake()
    {
        Levelid = PlayerPrefs.GetInt("levelid");
        levels[Levelid].SetActive(true);
        car.SetActive(true);
        car.transform.position = SpawnPoints[Levelid].transform.position;
        car.transform.rotation = SpawnPoints[Levelid].transform.rotation;
        PlayerPrefs.SetInt("collisions", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         gametime += Time.deltaTime;
            int seconds = (int)(gametime % 60);
            int minutes = (int)(gametime / 60) % 60;
            int hours = (int)(gametime / 3600) % 24;
            string timerstring = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);
            timerText.text = timerstring;
            PlayerPrefs.SetString("PersuitTime", timerstring);
        if (collision_control.win == 1)
        {

            winpanel.SetActive(true);
            collisionText.text = PlayerPrefs.GetInt("collisions").ToString();
            timertxt.text = PlayerPrefs.GetString("PersuitTime");
            AudioListener.pause = true;
            Time.timeScale = 0f;
            UI.SetActive(false);
        }

    }
}
