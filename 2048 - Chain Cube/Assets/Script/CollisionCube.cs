using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionCube : MonoBehaviour
{
    public static int once;
    public GameObject cubePref;
    Score score;

    void Start()
    {
        once = 1;
        GameObject go = GameObject.FindGameObjectWithTag("Canvas");
        score = go.GetComponent<Score>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (this.tag == collision.gameObject.tag && once == 1)
        {
            GameObject cube = Instantiate(cubePref, this.transform.position, Quaternion.identity);
            cube.tag = (int.Parse(this.tag) * 2).ToString();
            once = 0;
            score.scoreCounter += int.Parse(this.tag) * 2;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
