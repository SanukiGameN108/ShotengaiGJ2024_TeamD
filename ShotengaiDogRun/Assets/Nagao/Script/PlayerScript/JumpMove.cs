using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("ジャンプ力")]
    float JumpPower = 0;

    [SerializeField]
    [Tooltip("重力スケール")]
    float GravityScale = 0;

    // 地面との接触判定用スクリプト
    private Hit_Ground hit_ground = null;

    public JumpMove() : base()
    {

    }

    // 地面との接触判定を取得する
    private void Start()
    {
        hit_ground = this.gameObject.GetComponent<Hit_Ground>();
    }

    public void PushToJump()
    {
        // 地面に接触している場合、ジャンプ力で力を加える
        if (hit_ground != null)
        {
            if (hit_ground.Is_HittingGround() && Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("ジャンプ");
                rb.AddForce(new Vector3(0, JumpPower, 0), ForceMode.Impulse);
                SoundSystem.instance.PlaySEs(0);
            }
        }
        else
        {
            Debug.Log("地面判定が取得できませんでした");
        }

        // 重力を適用
        rb.AddForce(Physics.gravity * GravityScale + Physics.gravity);
    }
}
