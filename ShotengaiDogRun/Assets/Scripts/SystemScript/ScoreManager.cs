using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("テキストを設定")]
    private TextMeshProUGUI text;

    //デフォルトのスコアをセット。
    private void Start()
    {
        //デフォルトのスコアを設定。
        ScoreSystem.instance.SetDfaultScore();
    }

    private void Update()
    {
        TextScreen();
    }

    //現在のスコアをテキスト表示
    private void TextScreen()
    {
        text.text = "Score " + ScoreSystem.instance.scoreGet();
    }
}
