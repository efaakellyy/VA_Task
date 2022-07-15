using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deleteScript : MonoBehaviour
{
    Toggle toggle;

    //if the toggle is on, delete the cube
    public void Update() {
        toggle = GameObject.Find("deleteToggle").GetComponent<Toggle>();
        toggle = GetComponent<Toggle>();
        if (Input.GetMouseButtonDown(0) && toggle.isOn) {
            print("delete");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)){
              BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null){
                    Destroy(bc.gameObject);
                }
            }
        }
    }
}

    
    
  
 
