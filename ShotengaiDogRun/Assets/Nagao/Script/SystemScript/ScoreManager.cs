using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�e�L�X�g��ݒ�")]
    private TextMeshProUGUI text;

    //�f�t�H���g�̃X�R�A���Z�b�g�B
    private void Start()
    {
        //�f�t�H���g�̃X�R�A��ݒ�B
        ScoreSystem.instance.SetDfaultScore();
    }

    private void Update()
    {
        TextScreen();
    }

    //���݂̃X�R�A���e�L�X�g�\��
    private void TextScreen()
    {
        text.text = "Score " + ScoreSystem.instance.scoreGet();
    }
}
