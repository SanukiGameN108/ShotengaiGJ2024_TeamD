using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Abyss : CollisionHit
{
    public override void HitEnter(Collision collision)
    {
        SceanSystem.instance.LoadScene("GameOver");
    }

    private void OnCollisionEnter(Collision collision)
    {
        HitEnter(collision);
    }
}
