using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Trash : CollisionHit
{
    [SerializeField]
    [Tooltip("加算するスコアの大きさ")]
    private int AddScoreSize = 0;

    private Hit_Trash() : base()
    {

    }

    //プレイヤーにヒットした時の処理。
    public override void HitEnter(Collision collision)
    {
        ScoreSystem.instance.AddScore(AddScoreSize);
        Destroy(gameObject,0.01f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            HitEnter(collision);
        }
    }
}
