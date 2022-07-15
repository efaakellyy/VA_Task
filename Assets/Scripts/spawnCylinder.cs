using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCylinder : MonoBehaviour
{
    public GameObject cylinder;
    public GameObject spawnPoint;
    public float spawnOffset = 0.5f; // distance between each cube
    public float multiply = 1; // how many cubes to spawn
    public bool clearOnChange = false; // clear the list when changing the mode

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        // spawn a cylinder
        GameObject cylinderClone = Instantiate(cylinder, new Vector3(0, 0, 0), Quaternion.identity);
        // set the cylinders's position at the spawnPoint gameObject's position
        cylinderClone.transform.position = spawnPoint.transform.position;

        // set the cylinder parent to the scene
        cylinderClone.transform.parent = this.transform;
    }
}
