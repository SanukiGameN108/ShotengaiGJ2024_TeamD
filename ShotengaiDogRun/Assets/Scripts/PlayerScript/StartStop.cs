using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartStop : MonoBehaviour
{
    [SerializeField]
    private float StopTime = 0;

    [SerializeField]
    [Tooltip("�J�n�܂ł̃J�E���g��\������e�L�X�g")]
    public TextMeshProUGUI cnttext;

    //�X�g�b�v���Ԃ����������鏈���B
    public void DcreStop()
    {
        if(StopTime>0)
        StopTime -= Time.deltaTime;
    }

    public float GetStop()
    {
        return StopTime;
    }

    //�N�[���^�C�����O�ɂȂ������ǂ����𔻒�B
    public bool IsNoStop()
    {
        if(StopTime<=0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //�J�E���g��\������悤�̊֐�
    public void DisplayCnt(float Cnt)
    {
        if (cnttext != null && Cnt > 0)
        {
            cnttext.text = "" + Cnt.ToString("F1");
        }
        else
        {
            cnttext.text = "";
        }
    }
}
