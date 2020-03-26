using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBlock : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    float timer = 0f;
    public int timeVar = 1000;

    // Update is called once per frame
    void Update()
    {
        timer = timer + timeVar * Time.deltaTime;
        Debug.Log(timer);
        if (timer > 1000)
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
            timer = 0;
        }
    }
}
