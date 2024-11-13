using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceanSystem : MonoBehaviour
{
    public static SceanSystem instance;
    // Start is called before the first frame update

    void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //�w��̃V�[����ǂݍ��ށB
    public void LoadScene(string SceneName)
    {
        if(string.IsNullOrEmpty(SceneName))
        {
            Debug.Log("�V�[��������ł��B");
        }
        else
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
