using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Ground : CollisionHit
{
    //�ڒn���Ă��邩�ǂ���
    [SerializeField]
    private bool Is_Ground = false;

    private Hit_Ground() : base()
    {

    }

    public bool Is_HittingGround()
    {
        return Is_Ground;
    }

    //�Փ˔���
    public override void HitStay(Collider other)
    {
        Is_Ground = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag== "Ground")
        {
            HitStay(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Ground")
        {
            Is_Ground = false;
        }
    }
}
