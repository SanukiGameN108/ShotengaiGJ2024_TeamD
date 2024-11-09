using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クールタイムを計算・観測する。クールタイムによって行動を制限したりもできる。
public class CoolTimeBool : MonoBehaviour
{
    [SerializeField]
    [Tooltip("クールタイムの上限を設定。")]
    private float CoolTime_Set = 0;

    //実際に計測するクールタイム。０になったらクールタイムが解消されている、という扱いになる。
    private float CoolTime = 0;

    
    /// <summary>
    /// クールタイムが解消されているかどうか。
    /// </summary>
    /// <returns></returns>
    public bool Is_CoolTime_Clear()
    {
        if(CoolTime<=0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// クールタイムを減少させる。
    /// </summary>
    public void CountDown()
    {
        //クールタイムを減算。
        if (CoolTime > 0)
            CoolTime--;
    }
}
