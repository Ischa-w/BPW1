using UnityEngine;
using UnityEngine.Playables;

public class CutSceneTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    // Update is called once per frame
    void OnTriggerEnter()
    {
        
            timeline.Play();
            Debug.Log("Triggered!");
        
    }
}
