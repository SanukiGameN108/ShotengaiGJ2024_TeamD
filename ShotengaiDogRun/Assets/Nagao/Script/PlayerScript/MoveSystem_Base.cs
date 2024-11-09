using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem_Base : MonoBehaviour
{
    [SerializeField]
    [Tooltip("リギッドボディ")]
    protected Rigidbody rb= null;

    // Start is called before the first frame update

    protected void Awake()
    {
        GetRigid();
    }

    //リギッドボディを取得するための関数。コンストラクタで使う。
    protected void GetRigid()
    {
        //リギッドボディがあれば、それを取得する。
        if (this.GetComponent<Rigidbody>() != null)
        {
            Debug.Log("リギッドボディを取得！");
            rb =this.GetComponent<Rigidbody>();
        }
        else
        {
            Debug.Log("リギッドボディの取得に失敗しました。");
        }
    }
}
