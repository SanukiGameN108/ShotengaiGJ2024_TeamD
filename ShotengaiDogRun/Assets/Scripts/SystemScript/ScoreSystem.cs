using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;

    //現在のスコア。
    private int Score=0;

    //デフォルトのスコア。
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
    /// スコアを取得する。
    /// </summary>
    /// <returns></returns>
    public int scoreGet()
    {
        return Score;
    }

    /// <summary>
    /// デフォルトのスコアを設定。
    /// </summary>
    public void SetDfaultScore()
    {
        Score = DefaultScore;
    }

    /// <summary>
    /// 指定のスコアを加算。
    /// </summary>
    /// <param name="AddScores"></param>
    public void AddScore(int AddScores)
    {
        Score += AddScores;
    }

    //現在のスコアの値を設定。
    public void SetterScore(int SetScore)
    {
        Score = SetScore;
    }
}
