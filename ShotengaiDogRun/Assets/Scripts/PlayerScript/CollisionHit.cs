using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�����蔻��S�ʂ̊Ǘ����s���N���X�B
public class CollisionHit : MoveSystem_Base
{

    protected CollisionHit() : base()
    {

    }

    //�Փ˂������̏����B
    public virtual void HitEnter(Collision collision)
    {

    }

    //�d�Ȃ��Ă��鎞�̏����B
    public virtual void HitStay(Collider other)
    {

    }
}
