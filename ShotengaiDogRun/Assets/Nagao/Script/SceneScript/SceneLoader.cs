using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�ǂݍ��ރV�[���̖��O")]
    private string LoadSceneName="";

    // Start is called before the first frame update
    void Start()
    {
        SceanSystem.instance.LoadScene(LoadSceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
