using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("�ړ��X�s�[�h")]
    private float MoveSpeed = 0;

    public WideMove(): base()
    {

    }

    //�����I�ɉE�Ɉړ�����֐��B
    public void MovingRight()
    {
        gameObject.transform.Translate(MoveSpeed,0,0);
    }

     
}
