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
    [Tooltip("障害物接触のクラス")]
    private Hit_Damage hit_damage = null;

    [SerializeField]
    [Tooltip("接地判定のクラス")]
    private Hit_Ground hit_ground=null;

    [SerializeField]
    [Tooltip("クールタイム処理用のクラス。")]
    private CoolTimeBool cooltimebool = null;

    [SerializeField]
    [Tooltip("メインカメラ設定用のクラス。")]
    private GetMainCameraScript getmaincamerascript = null;

    private void Start()
    {
        //クールタイム処理を設定。
        hit_damage.SetAct(cooltimebool.SetCoolTime);
    }

    // Update is called once per frame
    void Update()
    {
        //クールタイムが解消されていれば、動くことができる。
        if (cooltimebool.Is_CoolTime_Clear())
        {
            Move();
        }
        else
        {
            cooltimebool.CountDown();
        }

        CameraSettings();
    }

    //移動関連の処理。
    private void Move()
    {
        widemove.MovingRight();
        jumpmove.PushToJump();
    }

    //カメラ設定用のクラス。
    public void CameraSettings()
    {
        getmaincamerascript.SetNowPos();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamageObject")
        {
            Debug.Log("Hit");
            cooltimebool.SetCoolTime();
        }
    }
}
