using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resizeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    Toggle toggle;
    Vector3 scaleChange = new Vector3(0.1f, 0.1f, 0.1f);

    // Update is called once per frame
    void Update()
    {
        //find the resize toggle
        toggle = GameObject.Find("resizeToggle").GetComponent<Toggle>();
        toggle = toggle.GetComponent<Toggle>(); //get the toggle component
        //if the resize toggle is on
        if (Input.GetMouseButtonDown(0) && toggle.isOn) {
            RaycastHit hit; //create a raycast hit
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //create a ray from the mouse position
            if (Physics.Raycast(ray, out hit)){
                //if the hit object has spawnedItem tag
                if (hit.transform.tag == "spawneditem") {
                    //get the renderer component
                    Renderer rendSpawnedItem = hit.transform.GetComponent<Renderer>();
                    //change the scale of the object 
                    rendSpawnedItem.transform.localScale += scaleChange;
                    //when the object reaches 10, change the scale of the object by -0.1f
                    if (rendSpawnedItem.transform.localScale.x <= 1f || rendSpawnedItem.transform.localScale.y >= 5)
                       scaleChange = -scaleChange;
                    }
                   
                }
            }
            // transform.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f)); 
        }
    }

