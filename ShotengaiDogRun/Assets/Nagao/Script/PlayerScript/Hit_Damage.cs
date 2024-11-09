using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//障害物に当たった時の、プレイヤーを停止させるクラス。
public class Hit_Damage : CollisionHit
{
    // デリゲートの宣言
    public delegate void SampleDelegate();
    Action CoolTimeSettings = null;

    public Hit_Damage():base()
    {

    }

    //関数をセット。
    public void SetAct(Action fc)
    {
        CoolTimeSettings = fc;
    }


    public override void HitEnter(Collision collision)
    {
        CoolTimeSettings();
    }
}
