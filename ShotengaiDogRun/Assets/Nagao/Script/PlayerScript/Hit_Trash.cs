using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Trash : CollisionHit
{
    [SerializeField]
    [Tooltip("���Z����X�R�A�̑傫��")]
    private int AddScoreSize = 0;

    private Hit_Trash() : base()
    {

    }

    //�v���C���[�Ƀq�b�g�������̏����B
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
