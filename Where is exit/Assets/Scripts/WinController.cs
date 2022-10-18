using UnityEngine.SceneManagement;
using UnityEngine;

public class WinController : MonoBehaviour
{
    public byte SceneValue;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("win"))
        {
            SceneManager.LoadScene(SceneValue);
        }
    }
}
