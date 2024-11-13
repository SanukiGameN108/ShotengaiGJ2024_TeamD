using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_GoalLine : CollisionHit
{
    public override void HitEnter(Collision collision)
    {
        SceanSystem.instance.LoadScene("Resoult");
    }

    private void OnCollisionEnter(Collision collision)
    {
        //プレイヤーに触れたら、リザルトシーンに向かう処理。
        if(collision.gameObject.tag=="Player")
        {
            HitEnter(collision);
        }
    }
}
