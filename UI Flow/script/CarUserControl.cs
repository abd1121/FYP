using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private int input;
        private float braker;
        NewBehaviourScript forward;
        brake bbrake;
        Backward back;


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }
        private void Start()
        {
            
            forward = GameObject.Find("Forward").GetComponent<NewBehaviourScript>();
            back = GameObject.Find("Backward").GetComponent<Backward>();
            bbrake = GameObject.Find("Brake").GetComponent<brake>();
            NewBehaviourScript.instance.SetPlayer(this.gameObject);
            brake.instance.SetPlayer(this.gameObject);
            Backward.instance.SetPlayer(this.gameObject);





        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = SimpleInput.GetAxis("Horizontal");
            float v = SimpleInput.GetAxis("Vertical");
#if !MOBILE_INPUT
            // float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            float handbrake;
            if (Input.GetKey(KeyCode.Space))
            {
                handbrake = 1;
            }
            else
                handbrake = 0;
            m_Car.Move(h, input, input, braker);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
        public void Forward()
        {
            print("Forward.....");
            input = 1; 
        }
        public void brk()
        {
            braker = 1.0f;
        }

        public void brkd()
        {
            braker = 0.0f;
        }

        public void PointerUp()
        {
            input = 0;
        }
        public void backward()
        {
            print("Backward.....");
            input = -1;
        }
    }
}
