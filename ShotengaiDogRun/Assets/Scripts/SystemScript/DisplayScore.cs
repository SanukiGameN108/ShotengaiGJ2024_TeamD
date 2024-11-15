using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    [SerializeField]
    [Tooltip("スコアを表示するテキスト")]
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
