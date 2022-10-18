using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class characterDeathController : MonoBehaviour
{
    private Animator _playerAnimator;
    [SerializeField] private Joystick _joystick;
    public byte restart;
    private void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            _playerAnimator.SetBool("isDead", true);
            _playerAnimator.SetBool("isIdle", false);
            _joystick.DeadZone = 1000f;
            StartCoroutine(Restart());
        }
    }
    
    private IEnumerator Restart()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(restart);
    }
} 
 
