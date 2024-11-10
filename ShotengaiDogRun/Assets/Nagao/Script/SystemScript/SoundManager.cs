using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Ä¶‚·‚éBGM")]
    private int BNumber = 0;
    public void Start()
    {
        StartBGM(BNumber);
    }

    //BGM‚ğÄ¶B
    public void StartBGM(int BGMnumber)
    {
        SoundSystem.instance.PlaySounds(BGMnumber);
    }
}
