using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������ԊǗ��p�̃V���O���g���V�X�e���B
public class TimeSystem : MonoBehaviour
{
    public static TimeSystem instance;

    [SerializeField]
    [Tooltip("�������Ԃ̃Z�b�g�B")]
    private float TimeLimit_Set = 0;

    //��������
    private float TimeLimit = 0;

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

    //�������Ԃ̃Z�b�g�B
    public void SetTime()
    {
        TimeLimit = TimeLimit_Set;
    }

    //�������Ԃ̌���
    public void CountDownTime()
    {
        if(TimeLimit>0)
        TimeLimit -= Time.deltaTime;

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

    /// <summary>
    /// �c�莞�Ԃ��擾�B
    /// </summary>
    /// <returns></returns>
    public float timeGetter()
    {
        return TimeLimit;
    }
}
