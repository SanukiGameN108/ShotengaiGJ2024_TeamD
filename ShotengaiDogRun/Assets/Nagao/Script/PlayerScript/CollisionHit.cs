using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�����蔻��S�ʂ̊Ǘ����s���N���X�B
public class CollisionHit : MoveSystem_Base
{
    //�q�b�g�����I�u�W�F�N�g��\������ϐ��B
    private int HitObject = 0;

    //�ڐG����I�u�W�F�N�g�̎�ށB
    protected enum HitObjects
    {
        eGround,//�n��
        eObstacle,//��Q��
        eTrash,//����
    }

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

    //�q�b�g�����I�u�W�F�N�g�̎�ނ�Ԃ��֐��B
    public int HitObjectCinds()
    {
        return HitObject;
    }
}
