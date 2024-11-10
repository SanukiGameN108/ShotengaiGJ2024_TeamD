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
        //�v���C���[�ɐG�ꂽ��A���U���g�V�[���Ɍ����������B
        if(collision.gameObject.tag=="Player")
        {
            HitEnter(collision);
        }
    }
}
