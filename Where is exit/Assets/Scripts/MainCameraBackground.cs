using UnityEngine;

public class MainCameraBackground : MonoBehaviour
{
    private Camera _camera;
    
    private void Start()
    {
        _camera = GetComponent<Camera>();

       _camera.clearFlags = CameraClearFlags.SolidColor;

        OnClassicColor();
    }
    

    public void OnClassicColor()
    {
        _camera.backgroundColor = new Color32(227, 143, 231, 1);
    }

    public void OnOrangeColor()
    {
        _camera.backgroundColor = new Color(227f, 143f, 121f);
    }
}
