using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointPosition : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        // move to in front of the camera
        transform.position = cam.transform.position + cam.transform.forward * 20;
        //move the spawn point higher
        transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
