using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceane : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�ړ�����V�[���̖��O�B")]
    private string LoadingSceneName;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        PushToLoading(LoadingSceneName);
    }

    //�{�^���������ƃV�[����ǂݍ��ޏ���
    void PushToLoading(string SceneNames)
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceanSystem.instance.LoadScene(SceneNames);
        }
    }
}
