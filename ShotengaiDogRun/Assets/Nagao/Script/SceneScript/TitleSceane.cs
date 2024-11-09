using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceane : MonoBehaviour
{
    [SerializeField]
    [Tooltip("移動するシーンの名前。")]
    private string LoadingSceneName;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        PushToLoading(LoadingSceneName);
    }

    //ボタンを押すとシーンを読み込む処理
    void PushToLoading(string SceneNames)
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceanSystem.instance.LoadScene(SceneNames);
        }
    }
}
