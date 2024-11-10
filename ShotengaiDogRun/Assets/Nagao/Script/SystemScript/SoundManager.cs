using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�Đ�����BGM")]
    private int BNumber = 0;
    public void Start()
    {
        StartBGM(BNumber);
    }

    //BGM���Đ��B
    public void StartBGM(int BGMnumber)
    {
        SoundSystem.instance.PlaySounds(BGMnumber);
    }
}
