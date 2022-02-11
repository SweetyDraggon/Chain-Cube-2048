using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject cubePref;
    int[] randomCube = { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192 };
    public static int weightIncrease =0;
    public bool isSpawn = false;
    int timeToRestart = 0;
   
    void Start()
    {
        SpawnedCube();
    }

    private void Update()
    {
        if (isSpawn == true)
        {
            WaitToSpawn();
        }
    }
    void WaitToSpawn()
    {
        timeToRestart++;
        if (timeToRestart == 30)
        {
            SpawnedCube();
        }
    }
    public void SpawnedCube()
    {
        int rand = 0;
        if (weightIncrease <= 10)
        {
            rand = Random.Range(0, 2);
        }
        else
            if (weightIncrease > 10 && weightIncrease <= 30)
        {
            rand = Random.Range(0, 4);
        }
        else
            if (weightIncrease > 30)
        {
            rand = Random.Range(0, 6);
        }
        Debug.Log(rand);

        GameObject spawnedCube = Instantiate(cubePref, new Vector3(0f, 2.2f, -8f), Quaternion.identity);
        isSpawn = false;
        timeToRestart = 0;
        spawnedCube.tag = randomCube[rand].ToString();
        spawnedCube.GetComponent<CubeMove>().enabled = true;
        weightIncrease++;        
    }
}
