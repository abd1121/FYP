using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class car_collision_detection : MonoBehaviour
{
    
    public GameObject failpanel;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AI_CAR")
        {
            failpanel.SetActive(true);
            Time.timeScale = 0f;
           
        }
    }
}
