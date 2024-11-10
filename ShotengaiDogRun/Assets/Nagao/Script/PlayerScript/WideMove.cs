using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("�ړ��X�s�[�h")]
    private float MoveSpeed = 0;

    [SerializeField]
    [Tooltip("��Q���Ɍ��˂������̐�����΂���鋗��")]
    private float DamagePower = 1;

    public WideMove(): base()
    {

    }

    //�����I�ɉE�Ɉړ�����֐��B
    public void MovingRight()
    {
        if (gameObject.transform.position.y > -3)
        {
            gameObject.transform.Translate(0, 0, MoveSpeed);
        }
        else
        {
            MoveSpeed = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamageObject")
        {
            rb.AddForce(new Vector3(0,0,-MoveSpeed*DamagePower),ForceMode.Impulse);
        }
    }
}
