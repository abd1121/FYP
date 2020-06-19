using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcamera : MonoBehaviour
{

    public Transform camTarget;
    public float sSpeed = 10.0f;
    public Vector3 dist;
    public Transform lookTarget;


    void FixedUpdate()
    {
        Vector3 dpos = camTarget.position + dist;
        Vector3 spos = Vector3.Lerp(transform.position, dpos, sSpeed * Time.deltaTime);
        transform.position = spos;
        transform.LookAt(lookTarget.position);

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
