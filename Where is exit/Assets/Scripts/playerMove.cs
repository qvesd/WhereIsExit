using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody _player;
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _speed;
    private Animator _playerAnimator;
    
    private void Start()
    {
        _playerAnimator = GetComponent<Animator>();
        _player = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _player.velocity = new Vector3(_joystick.Horizontal * _speed, _player.velocity.y, _joystick.Vertical * _speed); ;

        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_player.velocity);
            _playerAnimator.SetBool("isRun", true);
            _playerAnimator.SetBool("isIdle", false);
        }

        else
        {
            _playerAnimator.SetBool("isRun", false);
            _playerAnimator.SetBool("isIdle", true);
        }
    }
}
