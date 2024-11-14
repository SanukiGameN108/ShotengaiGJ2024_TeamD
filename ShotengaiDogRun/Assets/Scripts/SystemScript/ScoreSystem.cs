using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;

    //���݂̃X�R�A�B
    private int Score=0;

    //�f�t�H���g�̃X�R�A�B
    [SerializeField]
    private int DefaultScore = 0;

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

    /// <summary>
    /// �X�R�A���擾����B
    /// </summary>
    /// <returns></returns>
    public int scoreGet()
    {
        return Score;
    }

    /// <summary>
    /// �f�t�H���g�̃X�R�A��ݒ�B
    /// </summary>
    public void SetDfaultScore()
    {
        Score = DefaultScore;
    }

    /// <summary>
    /// �w��̃X�R�A�����Z�B
    /// </summary>
    /// <param name="AddScores"></param>
    public void AddScore(int AddScores)
    {
        Score += AddScores;
    }

    //���݂̃X�R�A�̒l��ݒ�B
    public void SetterScore(int SetScore)
    {
        Score = SetScore;
    }
}
