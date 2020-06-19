using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Vehicles.Car
{

    public class Pause : MonoBehaviour
    {
        bool IsPaused = false;
        // Start is called before the first frame update
        public void PausedGame()
        {
            if (IsPaused)
            {
                Time.timeScale = 1;
                IsPaused = false;
            }
            else
            {
                Time.timeScale = 0;
                IsPaused = true;
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
