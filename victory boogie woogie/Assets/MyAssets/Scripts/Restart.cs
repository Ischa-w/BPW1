using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void StartTheGame ()
    {
        SceneManager.LoadScene(1);
    }
}
