using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//��Q���ɓ����������́A�v���C���[���~������N���X�B
public class Hit_Damage : CollisionHit
{
    // �f���Q�[�g�̐錾
    public delegate void SampleDelegate();
    Action CoolTimeSettings = null;

    public Hit_Damage():base()
    {

    }

    //�֐����Z�b�g�B
    public void SetAct(Action fc)
    {
        CoolTimeSettings = fc;
    }


    public override void HitEnter(Collision collision)
    {
        CoolTimeSettings();
    }
}
