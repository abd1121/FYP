using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Vehicles.Car
{

    public class togglecam : MonoBehaviour
    {
        public Camera cam1;
        public Camera cam2;

        public void switchcam(int x)
        {
            deactivateall();
            if (x == 1)
            {
                cam1.enabled = true;
            }
            else
            {
                cam2.enabled = true;
            }
        }

        public void deactivateall()
        {
            cam1.enabled = false;
            cam2.enabled = false;
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
