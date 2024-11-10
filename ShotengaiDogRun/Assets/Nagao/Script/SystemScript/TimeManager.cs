using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("テキストを設定")]
    private TextMeshProUGUI text;

    //デフォルトの制限時間をセット。
    private void Start()
    {
        TimeSystem.instance.SetDefaultTime();
    }
    // Update is called once per fram
    
    void Update()
    {
        TimeCounting();
        TextScreen();
    }

    //制限時間を計測。
    private void TimeCounting()
    {
        TimeSystem.instance.CountDownTime();
        TimeSystem.instance.CountOneSecond();
    }

    //残り時間をテキスト表示
    private void TextScreen()
    {
        text.text = "Time "+TimeSystem.instance.timeGetter().ToString("F1");
    }
}
