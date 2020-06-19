using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace UnityStandardAssets.Vehicles.Car
{
    public class Backward : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
    {
        public static Backward instance = null;
        CarUserControl car;

        void Awake()
        {
            if (instance == null)
                instance = this;
        }
        public void SetPlayer(GameObject player)
        {
            car = player.GetComponent<CarUserControl>();
        }


        public void OnPointerDown(PointerEventData eventData)
        {
            car.backward();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            car.PointerUp();
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