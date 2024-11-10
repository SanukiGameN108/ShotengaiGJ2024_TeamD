using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//制限時間管理用のシングルトンシステム。
public class TimeSystem : MonoBehaviour
{
    public static TimeSystem instance;

    [SerializeField]
    [Tooltip("制限時間のセット。")]
    private float TimeLimit_Set = 0;

    //制限時間
    private float TimeLimit = 0;

    //カウントする間隔をセット。
    private const float One_Second_set = 60;

    //実際に時間をカウントする変数。
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

    //制限時間のセット。
    public void SetTime()
    {
        TimeLimit = TimeLimit_Set;
    }

    //制限時間の減少
    public void CountDownTime()
    {
        if(TimeLimit>0)
        TimeLimit -= Time.deltaTime;

        Debug.Log("残り時間"+TimeLimit);
    }

    //１秒を数える。トゥルーなら数え終わった状態。
    public bool CountOneSecond()
    {
        if(One_Second>0)
        {
            One_Second--;
            return false;
        }
        else
        {
            One_Second = One_Second_set;
            return true;
        }
    }

    /// <summary>
    /// 残り時間を取得。
    /// </summary>
    /// <returns></returns>
    public float timeGetter()
    {
        return TimeLimit;
    }
}
