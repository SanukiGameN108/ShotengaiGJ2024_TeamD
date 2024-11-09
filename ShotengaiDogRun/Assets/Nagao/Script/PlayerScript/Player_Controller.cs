using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //動作に必要なインスタンスを取得。
    //移動関連
    [SerializeField]
    [Tooltip("横移動のクラス")]
    private WideMove widemove=null;

    [SerializeField]
    [Tooltip("横移動のクラス")]
    private JumpMove jumpmove=null;

    [SerializeField]
    [Tooltip("接地判定のクラス")]
    private Hit_Ground hit_ground=null;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //移動関連の処理。
    private void Move()
    {
        widemove.MovingRight();
        jumpmove.PushToJump();
    }
}
