using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{

    public GameObject cube;
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

    public void spawn() { 
        // spawn a cube
        GameObject cubeClone = Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
        // set the cube's position at the spawnPoint gameObject's position
        cubeClone.transform.position = spawnPoint.transform.position;
        // set the cube's parent to the scene
        cubeClone.transform.parent = this.transform;
        //add gravity to the cube clone
        cubeClone.GetComponent<Rigidbody>().useGravity = true;


    }   
}
  



