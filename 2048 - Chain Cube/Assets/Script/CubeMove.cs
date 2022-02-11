using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    private Vector3 screenSpace;
    private Vector3 offset;
    public Rigidbody thisRigidbody;
    bool mouseIsUp = false;
    int impulse = 0; //время импульса
    public SpawnCube spawn;
    void Start()
    {//Определение обьекта со скриптом
        GameObject go = GameObject.FindGameObjectWithTag("MainCamera");
        spawn = go.GetComponent<SpawnCube>();
        thisRigidbody = GetComponent<Rigidbody>();

        this.GetComponent<DefinitionCube>().canToDie = false;
    }

    void OnMouseDown()
    {
        screenSpace = Camera.main.WorldToScreenPoint(this.transform.position);
        offset = this.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));

    }
    public void OnMouseDrag()
    {
        mouseIsUp = false;
        var curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
        var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
        this.transform.position = new Vector3(curPosition.x, 3f, -8f);
    }

    //__________________________________________________________________________________________________________________________

    private void Update()
    {
        if (mouseIsUp == true && impulse < 4)
        {
            thisRigidbody.constraints = RigidbodyConstraints.None;
            CubeShot();
        }
        if (impulse == 4)
        { 
            this.GetComponent<CubeDie>().enabled = true;
           
            this.GetComponent<CubeMove>().enabled = false;
        }
        Debug.Log(Time.timeScale);
       
    }
    public void OnMouseUp()
    {
        mouseIsUp = true;
        spawn.isSpawn = true;
    }
    void CubeShot() //выстрел куба после отпускания кнопки
    {
        thisRigidbody.AddForce(transform.forward * 500f);
        impulse++;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Start")
        {
            this.GetComponent<DefinitionCube>().canToDie = true;
        }
        
    }

}
