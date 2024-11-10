using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem instance;

    [SerializeField]
    private AudioSource audio=null;

    [SerializeField]
    private List<AudioClip> sounds = new List<AudioClip>();
    // Start is called before the first frame update

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //サウンドを変数で指定。
    public void PlaySounds(int SoundNumber)
    {
        audio.PlayOneShot(sounds[SoundNumber]);
    }
}
