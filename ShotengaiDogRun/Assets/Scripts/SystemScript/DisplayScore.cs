using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�X�R�A��\������e�L�X�g")]
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

    // �X�R�A����ʂɕ\������
    private void TextScreen()
    {
        text.text = "Score " + ScoreSystem.instance.scoreGet();
    }
}
