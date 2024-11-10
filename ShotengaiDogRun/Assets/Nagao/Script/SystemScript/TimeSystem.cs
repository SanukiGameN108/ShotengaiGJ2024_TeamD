using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������ԊǗ��p�̃V���O���g���V�X�e���B
public class TimeSystem : MonoBehaviour
{
    public static TimeSystem instance;

    //��������
    private float TimeLimit = 100;

    //�J�E���g����Ԋu���Z�b�g�B
    private const float One_Second_set = 60;

    //���ۂɎ��Ԃ��J�E���g����ϐ��B
    private float One_Second = 60;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //�������Ԃ̌���
    public void CountDownTime()
    {
        if(TimeLimit>0 && CountOneSecond())
        TimeLimit-=Time.deltaTime;

        Debug.Log("�c�莞��"+TimeLimit);
    }

    //�P�b�𐔂���B�g�D���[�Ȃ琔���I�������ԁB
    public bool CountOneSecond()
    {
        if(One_Second>0)
        {
            One_Second--;
            return false;
        }
        else
        {
            One_Second = One_Second_set;
            return true;
        }
    }
}
