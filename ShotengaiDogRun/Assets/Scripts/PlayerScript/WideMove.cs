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
    }

    private void OnCollisionEnter(Collision collision)
    {
    }
}
