using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColourScript : MonoBehaviour
{
    public Material[] materials; //array of materials
    public Renderer rendCube; //renderer
    public Renderer rendSphere; //renderer
    public Renderer rendCylinder; //renderer

    private int index = 1;

    public void buttonPressed(){
        if (materials.Length == 0)
        return;

        index += 1;  //increment the index

        if (index == materials.Length + 1)
        index = 1; //reset the index

        print(index); //print the index

        rendCube.sharedMaterial = materials[index-1]; //set the renderer's material to the material at the index
        rendSphere.sharedMaterial = materials[index-1]; //set the renderer's material to the material at the index
        rendCylinder.sharedMaterial = materials[index-1]; //set the renderer's material to the material at the index
    }

    
    
}
