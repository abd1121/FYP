using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace UnityStandardAssets.Vehicles.Car
{

    public class brake : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
    {
        public static brake instance = null;
        CarUserControl car;

        CarController carController;

        void Awake()
        {
            if (instance == null)
                instance = this;
        }
        public void SetPlayer(GameObject player)
        {
            car = player.GetComponent<CarUserControl>();
            carController = player.GetComponent<CarController>();
        }


        public void OnPointerDown(PointerEventData eventData)
        {
            car.brk();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            car.brkd();
            ForceStopWheelCol();
        }


        private void ForceStopWheelCol()
        {
            carController.SetWheelTroqueZero();
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