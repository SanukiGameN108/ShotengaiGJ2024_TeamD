using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�N�[���^�C�����v�Z�E�ϑ�����B�N�[���^�C���ɂ���čs���𐧌���������ł���B
public class CoolTimeBool : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�N�[���^�C���̏����ݒ�B")]
    private float CoolTime_Set = 1000;

    //���ۂɌv������N�[���^�C���B�O�ɂȂ�����N�[���^�C������������Ă���A�Ƃ��������ɂȂ�B
    [SerializeField]
    private float CoolTime = 0;

    
    /// <summary>
    /// �N�[���^�C������������Ă��邩�ǂ����B
    /// </summary>
    /// <returns></returns>
    public bool Is_CoolTime_Clear()
    {
        if(CoolTime<=0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// �N�[���^�C��������������B
    /// </summary>
    public void CountDown()
    {
        //�N�[���^�C�������Z�B
        if (CoolTime > 0)
            CoolTime--;
        else
            Debug.Log("�N�[���^�C��������" + CoolTime);
    }

    /// <summary>
    /// �N�[���^�C���������l�ɃZ�b�g�B
    /// </summary>
    public void SetCoolTime()
    {
        CoolTime = CoolTime_Set;
    }
}