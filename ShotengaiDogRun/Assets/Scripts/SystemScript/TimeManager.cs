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

    //�f�t�H���g�̐������Ԃ��Z�b�g�B
    private void Start()
    {
        TimeSystem.instance.SetDefaultTime();
    }
    // Update is called once per fram
    
    void Update()
    {
        TimeCounting();
        TextScreen();
        CenserGameOver();
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

    /// <summary>
    /// �^�C�����O�ɂȂ����̂𔻒肷��B
    /// </summary>
    private void CenserGameOver()
    {
        if (TimeSystem.instance.timeGetter() <= 0)
            SceanSystem.instance.LoadScene("GameOver");
    }
}
