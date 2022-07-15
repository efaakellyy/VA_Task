using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSphere : MonoBehaviour
{

    public GameObject sphere;
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
        // spawn a sphere
        GameObject sphereClone = Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
        // set the sphere's position at the spawnPoint gameObject's position
        sphereClone.transform.position = spawnPoint.transform.position;
        // set the sphere parent to the scene
        sphereClone.transform.parent = this.transform;
    }
}
