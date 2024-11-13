using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("スコアを表示するテキスト")]
    private TextMeshProUGUI text;

    // スコアシステムの初期化
    private void Start()
    {
        // スコアシステムのデフォルトスコアを設定
        ScoreSystem.instance.SetDfaultScore();
    }

    private void Update()
    {
        TextScreen();
    }

    // スコアを画面に表示する
    private void TextScreen()
    {
        text.text = "Score " + ScoreSystem.instance.scoreGet();
    }
}
