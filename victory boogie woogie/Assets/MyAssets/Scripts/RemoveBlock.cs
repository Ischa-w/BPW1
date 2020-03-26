using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBlock : MonoBehaviour
{
    public float lifeTime = 10f;
  


    void Update()
    {
        

        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
            {
                Destruction();
            }
        }

        void Destruction()
        {
            Destroy(this.gameObject);
        }
    }
}