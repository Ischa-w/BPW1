using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreWarm : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 20.0f;

        StartCoroutine(SlowDown());
    }

    private IEnumerator SlowDown()
    {
        yield return new WaitForSecondsRealtime(1.0f);

       Time.timeScale = 1.0f;
    }
}
