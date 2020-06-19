using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CamType {None, RearView, MiniMap }
public class minimap : MonoBehaviour
{
    public Transform Player;

    public CamType camType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (CamType.MiniMap == camType)
        {
            Vector3 newPosiiion = Player.position;
            newPosiiion.y = transform.position.y;
            transform.position = newPosiiion;
            transform.rotation = Quaternion.Euler(90f, Player.eulerAngles.y, 0f);
        }
        else if (CamType.RearView == camType)
        {
            Vector3 newPosiiion = Player.position;
            newPosiiion.y = transform.position.y;
            transform.position = newPosiiion;
          //  transform.rotation = Quaternion.Euler(90f, Player.eulerAngles.y, 0f);

        }

    }
}
