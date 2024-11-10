using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("移動スピード")]
    private float MoveSpeed = 0;

    [SerializeField]
    [Tooltip("障害物に激突した時の吹っ飛ばされる距離")]
    private float DamagePower = 1;

    public WideMove(): base()
    {

    }

    //自動的に右に移動する関数。
    public void MovingRight()
    {
        gameObject.transform.Translate(0,0, MoveSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamageObject")
        {
            rb.AddForce(new Vector3(0,0,-MoveSpeed*DamagePower),ForceMode.Impulse);
        }
    }
}
