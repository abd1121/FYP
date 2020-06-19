using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameManager : MonoBehaviour
{
    public GameObject failpanel;
    public GameObject winpanel;
    public GameObject UI;
    public Text timerText;
    public float targetTime = 10.0f;
    public GameObject[] SpawnPoints;
    private int Levelid;
    public GameObject[] levels;
    public GameObject car;
    // Start is called before the first frame update
    void Awake()
    {
        Levelid = PlayerPrefs.GetInt("levelid");
        levels[Levelid].SetActive(true);
        car.SetActive(true);
        car.transform.position = SpawnPoints[Levelid].transform.position;
        car.transform.rotation = SpawnPoints[Levelid].transform.rotation;
    }
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
            targetTime -= Time.deltaTime;
            int time = (int)targetTime;
            timerText.text = time.ToString() + "s";
            if(collision_control.collision==3 || targetTime<=0.0f)
        {
            failpanel.SetActive(true);
            UI.SetActive(false);
            Time.timeScale = 0f;
            AudioListener.pause = true;
        }
            if(collision_control.win ==1)
            {

                winpanel.SetActive(true);
                AudioListener.pause = true;
                Time.timeScale = 0f;
                UI.SetActive(false);
            }
        
        
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
    public void Initilizer()
    {

    }
}