using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sizeChange : MonoBehaviour
{

    Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);

    private GameObject selectedObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Stationary)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);

            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
               if(hit.transform.tag == "DefaultCube")
               {
                     selectedObject = hit.collider.gameObject;
                     selectedObject.transform.localScale += scaleChange;

                     if(hit.transform.localScale.y < 1f || hit.transform.localScale.y > 3f)
                     {
                        scaleChange = -scaleChange;
                     }
                }
        }
    }
}
}
