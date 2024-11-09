using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//当たり判定全般の管理を行うクラス。
public class CollisionHit : MoveSystem_Base
{
    //ヒットしたオブジェクトを表現する変数。
    private int HitObject = 0;

    //接触するオブジェクトの種類。
    protected enum HitObjects
    {
        eGround,//地面
        eObstacle,//障害物
        eTrash,//ごみ
    }

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

    //ヒットしたオブジェクトの種類を返す関数。
    public int HitObjectCinds()
    {
        return HitObject;
    }
}
