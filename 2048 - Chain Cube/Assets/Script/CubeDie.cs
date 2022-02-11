using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDie : MonoBehaviour
{
    Score score;
    private void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Canvas");
        score = go.GetComponent<Score>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "edge" && this.GetComponent<DefinitionCube>().canToDie == true)
        {
            OpenGameOverMenu();
        }
    }
    void OpenGameOverMenu()
    {
        score.GameOver();
        Time.timeScale = 0;
    }
   
}
