using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 時間制御用のシングルトンクラス
/// </summary>
public class TimeSystem : MonoBehaviour
{
    public static TimeSystem instance;

    [SerializeField]
    [Tooltip("制限時間の設定")]
    private float TimeLimit_Set = 0;

    // 現在の制限時間
    private float TimeLimit = 0;

    // カウント用の1秒間設定
    private const float One_Second_Set = 60;

    // 1秒をカウントする変数
    private float One_Second = 60;

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

    // 制限時間の設定
    public void SetDefaultTime()
    {
        TimeLimit = TimeLimit_Set;
    }

    // 制限時間のカウントダウン
    public void CountDownTime()
    {
        if (TimeLimit > 0)
            TimeLimit -= Time.deltaTime;

        Debug.Log("残り時間: " + TimeLimit);
    }

    // 1秒をカウントする。タイマーが1秒に達したらtrueを返す
    public bool CountOneSecond()
    {
        if (One_Second > 0)
        {
            One_Second--;
            return false;
        }
        else
        {
            One_Second = One_Second_Set;
            return true;
        }
    }

    /// <summary>
    /// 残り時間を取得
    /// </summary>
    /// <returns></returns>
    public float timeGetter()
    {
        return TimeLimit;
    }
}
