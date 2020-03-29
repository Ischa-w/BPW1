using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    Vector3 tempPos;
    public float SpeedX = 0.1f;
    public float SpeedY = 0.1f;
    public float SpeedZ = 0.1f;

    private void Start()
    {
        tempPos = transform.position;
        tempPos.x += Time.deltaTime * SpeedX;
        tempPos.y += Time.deltaTime * SpeedY;
        tempPos.z += Time.deltaTime * SpeedZ;
    }

    void Update()
    {
        tempPos = transform.position;
        tempPos.x += Time.deltaTime * SpeedX;
        tempPos.y += Time.deltaTime * SpeedY;
        tempPos.z += Time.deltaTime * SpeedZ; 
        transform.position = tempPos;
    }
}
