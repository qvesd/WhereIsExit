using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField] private Rigidbody _player;
    public Vector3 dist;
    
    private void Update()
    {
        transform.position = _player.position + dist;
    }
}
