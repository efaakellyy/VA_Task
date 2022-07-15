using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{
    public float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
               
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += movement * Time.deltaTime * speed;
        }
    }

