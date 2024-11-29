using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("移動速度")]
    private float MoveSpeed = 0;

    [SerializeField]
    [Tooltip("ダメージオブジェクトが当たったときのダメージ力")]
    private float DamagePower = 1;

    //ダメージを受けた時の、次にダメージを受けるまでのクールタイム。
    [SerializeField]
    private float Damage_CoolTime = 0;

    public WideMove() : base()
    {

    }

    // 移動処理（右方向）
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

        DcreCoolTime();
    }

    private void DcreCoolTime()
    {
        if (Damage_CoolTime > 0)
        {
            Damage_CoolTime-=Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamageObject" && Damage_CoolTime<=0)
        {
            rb.AddForce(new Vector3(-DamagePower, 0, 0), ForceMode.Impulse);
            Damage_CoolTime = 1;
            Debug.Log("DamageHit");
        }
    }
}
