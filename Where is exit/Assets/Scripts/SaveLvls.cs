using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLvls : MonoBehaviour
{
    private int _nowScene;
    private int _oldScene;

    private void Update()
    {
        _nowScene = SceneManager.GetActiveScene().buildIndex;

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (PlayerPrefs.HasKey("IsNextScene"))
            {
                _oldScene = PlayerPrefs.GetInt("IsNextScene");
            }

            else
            {
                _oldScene = 1;
            }

        }

        else if (_oldScene != _nowScene)
        {
            PlayerPrefs.SetInt("IsNextScene", _nowScene);

            _oldScene = _nowScene;
        }

        Debug.Log("_oldScene" + _oldScene);
        Debug.Log("_nowScene" + _nowScene);
    }

    public void StartButton()
    {
        if (PlayerPrefs.HasKey("IsNextScene"))
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("IsNextScene"));
        }

        else
        {
            SceneManager.LoadScene(1);
        }

    }
}
