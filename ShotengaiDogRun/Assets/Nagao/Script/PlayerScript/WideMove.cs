using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("�ړ��X�s�[�h")]
    private readonly float MoveSpeed = 0;

    WideMove(): base()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�����I�ɉE�Ɉړ�����֐��B
    public void MovingRight()
    {
        gameObject.transform.Translate(MoveSpeed,0,0);
    }
}
