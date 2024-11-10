using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�e�L�X�g��ݒ�")]
    private TextMeshProUGUI text;
    

    //�������Ԃ��Z�b�g�B
    private void Awake()
    {
        TimeSystem.instance.SetTime();
    }
    // Update is called once per fram
    
    void Update()
    {
        TimeCounting();
        TextScreen();
    }

    //�������Ԃ��v���B
    private void TimeCounting()
    {
        TimeSystem.instance.CountDownTime();
        TimeSystem.instance.CountOneSecond();
    }

    //�c�莞�Ԃ��e�L�X�g�\��
    private void TextScreen()
    {
        text.text = "Time "+TimeSystem.instance.timeGetter().ToString("F1");
    }
}
