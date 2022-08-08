using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deleteScript : MonoBehaviour
{
    Toggle toggle;

    //if the toggle is on, delete the cube
    public void Update() {
        toggle = GameObject.Find("deleteToggle").GetComponent<Toggle>(); //get the toggle
        toggle = GetComponent<Toggle>(); //get the toggle component
        // spawneditem = GameObject.Find("defaultCube"); //get the spawned cube
        //if an item has been clicked and the toggle is on, delete the item
        // if (toggle.isOn) {
        //     //if an item has been clicked
        //     if (spawneditem != null) {
        //         //delete the item
        //         Destroy(spawneditem);
        //     }
        // }

        if (Input.GetMouseButtonDown(0) && toggle.isOn) {
            print("delete");
            RaycastHit hit; //create a raycast hit 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //create a ray from the mouse position
            if (Physics.Raycast(ray, out hit)){
                //if the hit object has spawnedItem tag
                if (hit.transform.tag == "spawneditem") {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}

    
    
  
 
