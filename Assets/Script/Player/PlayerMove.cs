using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 15f;
    public float leftRightSpeed = 4;
    public float jumpForce = 4;

    void Update()
    {
        if(moveSpeed >5f)
        {
            moveSpeed = moveSpeed - 0.00001f * Time.time;
        }
        
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
              transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * 1);
            }   
        }

        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                 transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
    
    }
}
