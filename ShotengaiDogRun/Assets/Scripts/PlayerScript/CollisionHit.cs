using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//当たり判定全般の管理を行うクラス。
public class CollisionHit : MoveSystem_Base
{

    protected CollisionHit() : base()
    {

    }

    //衝突した時の処理。
    public virtual void HitEnter(Collision collision)
    {

    }

    //重なっている時の処理。
    public virtual void HitStay(Collider other)
    {

    }
}
