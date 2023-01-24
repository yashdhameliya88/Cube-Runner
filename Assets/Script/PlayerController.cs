using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float moveSpeed = 10f;
    Vector3 sideMove;
    float sideMoveSpeed = 10f;
    float minX = -3f;
    float maxX = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        ForwardMove();
        SideMove();
    }
        
    //Player forward move
    void ForwardMove()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }

    //Player side movement
    void SideMove() 
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);
        transform.position = playerPos;

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * sideMoveSpeed * Time.deltaTime);
            //transform.position = transform.position + new Vector3(sideMoveSpeed * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right * sideMoveSpeed * Time.deltaTime);
            //transform.position = transform.position - new Vector3(sideMoveSpeed * Time.deltaTime, 0, 0);
        }
       
    }
}
