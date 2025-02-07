using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("再生するBGM")]
    private int BNumber = 0;
    public void Start()
    {
        StartBGM(BNumber);
    }

    //BGMを再生。
    public void StartBGM(int BGMnumber)
    {
        SoundSystem.instance.PlaySounds(BGMnumber);
    }

    private void OnDestroy()
    {
        SoundSystem.instance.StopSounds();
    }
}
