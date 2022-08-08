using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColourScript : MonoBehaviour
{
    public Material[] materials; //array of materials
    //create a renderer for objects with the tag "spawneditem"
    public Renderer rendSpawnedItem;

    private int index = 1; //index of the material array

    Toggle toggle;
    //

    void Update(){
        toggle = GameObject.Find("colourToggle").GetComponent<Toggle>();
        toggle = toggle.GetComponent<Toggle>(); //get the toggle component
     //if the object is clicked, change the colour
        if(Input.GetMouseButtonDown(0) && toggle.isOn){
            RaycastHit hit; //create a raycast hit
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //create a ray from the mouse position
            if (Physics.Raycast(ray, out hit)){
                //if the hit object has spawnedItem tag
                if (hit.transform.tag == "spawneditem") {
                    rendSpawnedItem = hit.transform.GetComponent<Renderer>(); //get the renderer component
                    rendSpawnedItem.material = materials[index]; //change the material
                    index++; //increment the index
                    if (index == materials.Length) { //if the index is equal to the length of the array
                        index = 0; //set the index to 0
                    }
                }
            }
        }   
    }
    
}
