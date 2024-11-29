using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartStop : MonoBehaviour
{
    [SerializeField]
    private float StopTime = 0;

    [SerializeField]
    [Tooltip("開始までのカウントを表示するテキスト")]
    public TextMeshProUGUI cnttext;

    //ストップ時間を減少させる処理。
    public void DcreStop()
    {
        if(StopTime>0)
        StopTime -= Time.deltaTime;
    }

    public float GetStop()
    {
        return StopTime;
    }

    //クールタイムが０になったかどうかを判定。
    public bool IsNoStop()
    {
        if(StopTime<=0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //カウントを表示するようの関数
    public void DisplayCnt(float Cnt)
    {
        if (cnttext != null && Cnt > 0)
        {
            cnttext.text = "" + Cnt.ToString("F1");
        }
        else
        {
            cnttext.text = "";
        }
    }
}
