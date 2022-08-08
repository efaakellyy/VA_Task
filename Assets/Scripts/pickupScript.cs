using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupScript : MonoBehaviour
{
  Toggle rotateToggle;
  Toggle moveToggle;
  private bool isPickedUp = false;
  private GameObject pickedUpObject;
  private float startXPos;
  private float startYPos;
  public float speed = 10.0f;
 
   // Start is called before the first frame update
  void Start()
  {  
  
  }

  void Update()
  {
    if (isPickedUp)
    {
      Vector3 mousePos = Input.mousePosition;
      print("mousepos: " + mousePos);
      mousePos.z = 10;
      mousePos = Camera.main.ScreenToWorldPoint(mousePos);
      print("startpos: " + startXPos + " " + startYPos);
      pickedUpObject.transform.position = new Vector3(mousePos.x - startXPos, mousePos.y - startYPos, pickedUpObject.transform.position.z);
      print("setting position: " + (mousePos.x - startXPos) + " " + (mousePos.y - startYPos));
      float xDirection = Input.GetAxis("Horizontal"); // get the horizontal direction from the user
      float zDirection = Input.GetAxis("Vertical"); // get the vertical direction from the user

      Vector3 movement = new Vector3(xDirection, 0.0f, zDirection); 
      // create a vector3 with the x and z direction and set the y to 0.0f
      //move the picked up object in the direction of the vector3
      pickedUpObject.transform.position += movement * Time.deltaTime * speed;    
                
                   
    } else {
      GameObject currentObject = null;
      moveToggle = GameObject.Find("moveToggle").GetComponent<Toggle>();
      moveToggle = moveToggle.GetComponent<Toggle>();
      rotateToggle = GameObject.Find("rotateToggle").GetComponent<Toggle>();
      rotateToggle = rotateToggle.GetComponent<Toggle>();
      //if mouse is pressed
      if (Input.GetMouseButtonDown(0) && moveToggle.isOn)
      {
        RaycastHit hit; //create a raycast hit
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //create a ray from the mouse position
        if (Physics.Raycast(ray, out hit))
        {
          //if the hit object has spawnedItem tag
          if (hit.transform.tag == "spawneditem")
          {
            currentObject = hit.transform.gameObject; //get the hit object
            //if the object is not null
            if (currentObject != null)
            {
              //get the rigidbody component
              Rigidbody rb = currentObject.GetComponent<Rigidbody>();
              //if the rigidbody is not null
              if (rb != null && !rotateToggle.isOn)
              {
                //disable the gravity
                rb.useGravity = false;
                rb.isKinematic = true;
                pickedUpObject = currentObject; //set the picked up object to the current object
                Vector3 mousePos = Input.mousePosition; //get the mouse position
                mousePos.z = 10; //set the z position to 10
                mousePos = Camera.main.ScreenToWorldPoint(mousePos); //convert the mouse position to world position
                startXPos = mousePos.x - currentObject.transform.position.x; //set the start x position to the mouse position minus the current object's x position
                startYPos = mousePos.y - currentObject.transform.position.y; //get the y position of the mouse minus the y position of the object
                isPickedUp = true; //set the picked up boolean to true
                
               
              }else if (rb != null && rotateToggle.isOn) {
                //disable the gravity
                rb.useGravity = false;
                rb.isKinematic = true;
                pickedUpObject = currentObject; //set the picked up object to the current object
                Vector3 mousePos = Input.mousePosition; //get the mouse position
                mousePos.z = 10; //set the z position to 10
                mousePos = Camera.main.ScreenToWorldPoint(mousePos); //convert the mouse position to world position
                startXPos = mousePos.x - currentObject.transform.position.x; //set the start x position to the mouse position minus the current object's x position
                startYPos = mousePos.y - currentObject.transform.position.y; //get the y position of the mouse minus the y position of the object
                isPickedUp = true; //set the picked up boolean to true
                //rotate the object randomly around the x and y axis
                currentObject.transform.Rotate(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
                

              }
              {

              }
            }
          }
        }
      }
  }
  //if the mouse is released 
  if (Input.GetMouseButtonUp(0))
  {
    //if the object is not null
    if (isPickedUp)
    {
      isPickedUp = false; //set the picked up boolean to false
      //get the rigidbody component
      Rigidbody rb = pickedUpObject.GetComponent<Rigidbody>();
      //if the rigidbody is not null
      if (rb != null)
      {
        //enable the gravity
        rb.useGravity = true;
        rb.isKinematic = false;
      }
    }
  }

  }
}
  //   {
  //     // if not already holding an object
  //     if (currentObject == null)
  //     {
  //       // create a ray from the camera through the mouse position
  //       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
  //       RaycastHit hit;
  //       // if the ray hits something
  //       if (Physics.Raycast(ray, out hit))
  //       {
  //         // if the hit object has a rigidbody
  //         if (hit.rigidbody != null)
  //         {
  //           // set the current object to the hit object
  //           print("hit");
  //           currentObject = hit.rigidbody.gameObject;
  //           // disable the current object's rigidbody
  //           //disable to objects gravity
  //           currentObject.GetComponent<Rigidbody>().useGravity = false;
  //           currentObject.GetComponent<Rigidbody>().isKinematic = true;
  //         }
  //       }
  //     } else {
  //       // if already holding object
  //       // move object to mouse position
  //       currentObject.transform.position = Input.mousePosition;
  //     }
  //   }
  //   if (Input.GetMouseButtonUp(0))
  //   {
  //     // if holding an object
  //     if (currentObject != null)
  //     {
  //       // enable the current object's rigidbody
  //       currentObject.GetComponent<Rigidbody>().isKinematic = false;
  //       currentObject.GetComponent<Rigidbody>().useGravity = true;
  //       // set the object to null
  //       currentObject = null;
  //     }
  //   }
  // }

  // void onMouseUp()
  // {
  //   // use raycast to get the object that was clicked on
  //   Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
  //   RaycastHit hit;
  //   if (Physics.Raycast(ray, out hit))
  //   {
  //     // get the rigidbody of the object
  //     Rigidbody rb = hit.collider.gameObject.GetComponent<Rigidbody>();
  //     // if the rigidbody is not null
  //     if (rb != null)
  //     {
  //       // enable gravity on the rigidbody
  //       rb.useGravity = true;
  //     }
  //   }
  // }
  
// }
