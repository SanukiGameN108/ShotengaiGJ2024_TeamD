using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MoveSystem_Base
{
    public Player_Controller() : base()
    {

    }

    [SerializeField]
    [Tooltip("ゲームが始まっているかどうかを判定。")]
    private StartStop startstop = null;

    // 移動関連のコンポーネントを参照
    // 左右移動
    [SerializeField]
    [Tooltip("左右移動のスクリプト")]
    private WideMove widemove = null;

    [SerializeField]
    [Tooltip("ジャンプのスクリプト")]
    private JumpMove jumpmove = null;

    [SerializeField]
    [Tooltip("ヒットダメージのスクリプト")]
    private Hit_Damage hit_damage = null;

    [SerializeField]
    [Tooltip("地面との接触のスクリプト")]
    private Hit_Ground hit_ground = null;

    [SerializeField]
    [Tooltip("クールタイムの管理のスクリプト")]
    private CoolTimeBool cooltimebool = null;

    [SerializeField]
    [Tooltip("メインカメラのスクリプト")]
    private GetMainCameraScript getmaincamerascript = null;

    private void Start()
    {
        Debug.Log("aaa");
        // ヒットダメージのスクリプトにクールタイムを設定
        hit_damage.SetAct(cooltimebool.SetCoolTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (startstop.IsNoStop())
        {
            bool isFallingGameOver = transform.position.y <= StageConstants.ABYSS_TOP_Y;
            if (isFallingGameOver)
            {
                SceanSystem.instance.LoadScene("GameOver");
            }
            Move();
            CameraSettings();
        }
        else
        {
            startstop.DcreStop();
            startstop.DisplayCnt(startstop.GetStop());
        }
    }

    // 左右移動、ジャンプ処理を行う
    private void Move()
    {
        widemove.MovingRight();
        jumpmove.PushToJump();
    }

    // メインカメラの位置を設定
    public void CameraSettings()
    {
        getmaincamerascript.SetNowPos();
    }
}
