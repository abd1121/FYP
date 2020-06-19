using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace UnityStandardAssets.Vehicles.Car
{
    public class restart : MonoBehaviour
    {
        // Start is called before the first frame update
        public void RestartGame()
        {
            SceneManager.LoadScene("Training");
        }

        // Update is called once per frame

    }
}
