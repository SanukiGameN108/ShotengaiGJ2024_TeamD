using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("ジャンプ力")]
    float JumpPower = 0;

    //接地判定用インスタンス
    private Hit_Ground hit_ground=null;

    public JumpMove() : base()
    {

    }

    //接地判定を取得。Awakeとは分けて書く。
    private void Start()
    {
        hit_ground = this.gameObject.GetComponent<Hit_Ground>();
    }

    public void PushToJump()
    {
        //接地判定が空でなければ、ジャンプ処理は行わない。
        if (hit_ground != null)
        {
            if (hit_ground.Is_HittingGround() && Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("ジャンプ");
                rb.AddForce(new Vector3(0, JumpPower, 0),ForceMode.Impulse);
            }
        }
        else
        {
            Debug.Log("接地判定用のコリジョンがありません");
        }
    }
}
