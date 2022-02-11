using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefinitionCube : MonoBehaviour
{
    public Material[] mat;
    public TextMeshPro[] numberOfCube;
    public bool canToDie = true;
    void Start()
    {

        mat = Resources.LoadAll<Material>("CubesColors");
  
        switch (this.tag)
        {
            case "2": this.GetComponent<MeshRenderer>().material = mat[0]; break;
            case "4": this.GetComponent<MeshRenderer>().material = mat[1]; break;
            case "8": this.GetComponent<MeshRenderer>().material = mat[2]; break;
            case "16": this.GetComponent<MeshRenderer>().material = mat[3]; break;
            case "32": this.GetComponent<MeshRenderer>().material = mat[4]; break;
            case "64": this.GetComponent<MeshRenderer>().material = mat[5]; break;
            case "128": this.GetComponent<MeshRenderer>().material = mat[6]; break;
            case "256": this.GetComponent<MeshRenderer>().material = mat[7]; break;
            case "512": this.GetComponent<MeshRenderer>().material = mat[8]; break;
            case "1024": this.GetComponent<MeshRenderer>().material = mat[9]; break;
            case "2048": this.GetComponent<MeshRenderer>().material = mat[10]; break;
            case "4096": this.GetComponent<MeshRenderer>().material = mat[11]; break;
            case "8192": this.GetComponent<MeshRenderer>().material = mat[12]; break;
        }
        for (int i = 0; i < numberOfCube.Length; i++)
        {
            numberOfCube[i].text = this.tag;
        }
    }

}
