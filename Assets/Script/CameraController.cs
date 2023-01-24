using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    float offSet = -10f;
    
    // Update is called once per frame
    void Update()
    {
        //transform.position = player.transform.position + new Vector3(0, 7, -10);
        Vector3 cameraPos = transform.position;
        cameraPos.z = player.transform.position.z + offSet;
        transform.position = cameraPos;
    }
}
