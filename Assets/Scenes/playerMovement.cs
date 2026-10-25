using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public bool WASD; //Checked for player 1 and unchecked for player 2

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalMove = 0f;
        float VerticalMove = 0f;

        if (WASD)
        {
            if (Input.GetKey(KeyCode.W))
            {
                VerticalMove = 1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                VerticalMove = -1f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                HorizontalMove = -1f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                HorizontalMove = 1f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                VerticalMove = 1f;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                VerticalMove = -1f;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                HorizontalMove = -1f;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                HorizontalMove = 1f;
            }
        }
        // This makes it so one player uses WASD and the other uses arrow keys with the press of a button in the inspector
        
        Vector3 moveDirection = new Vector3(HorizontalMove, 0, VerticalMove);
        moveDirection.Normalize();
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);

        if (moveDirection != Vector3.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = toRotate;
            //Quaternion toRotate = Quaternion.LookRotation(moveDirection, Vector3.up);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotate, rotationSpeed * Time.deltaTime);
        }
        //Sources Used: https://www.youtube.com/watch?v=F7bdwOFofLk&list=PLkp23zg4CAMV8fcsUYX1EwihX7WXhFH6N&index=1
        // https://www.youtube.com/watch?v=v6Kh748AwJU&list=PLkp23zg4CAMV8fcsUYX1EwihX7WXhFH6N&index=2
    }
}
