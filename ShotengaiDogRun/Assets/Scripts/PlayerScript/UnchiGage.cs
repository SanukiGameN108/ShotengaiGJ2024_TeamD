using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//うんちゲージ管理用のクラス
public class UnchiGage : MonoBehaviour
{
    [SerializeField]
    [Tooltip("うんちゲージの上限の大きさ")]
    private float Unchi_gagenumber_set = 0;

    [SerializeField]
    [Tooltip("うんちゲージの値")]
    private float Unchi_gagenumber = 0;

    [SerializeField]
    [Tooltip("うんちゲージを減らす大きさ")]
    private float DcreSet=0;

    private void Start()
    {
        Unchi_gagenumber = Unchi_gagenumber_set;
    }

    //うんちゲージの上限を設定。
    public float GetterUnchi_Limit()
    {
        return Unchi_gagenumber_set;
    }

    //うんちゲージを設定するセッター。
    public void SetterUnchi(int SetUnchi)
    {
        Unchi_gagenumber = SetUnchi;
    }

    //うんちゲージの値を取得。
    public float GetterUnchi()
    {
        return Unchi_gagenumber;
    }

    //うんちゲージ減少の関数。
    public void DcreUnchi()
    {
        //減算用なので、マイナスの値は入らない。
        if (DcreSet > 0)
            Unchi_gagenumber-=Time.deltaTime*DcreSet;
        else
            Debug.Log("減算の値に０以下の値が入っています。");
    }

    //うんちゲージがマックスになったら、スコアをゼロにしてゲージをリセットする。
    public void UnchiPenalty()
    {
        //スコアをリセット
        if(Unchi_gagenumber<=0)
        {
            Unchi_gagenumber = Unchi_gagenumber_set;
            ScoreSystem.instance.SetterScore(0);
        }
    }
}
