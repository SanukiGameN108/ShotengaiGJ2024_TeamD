using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���񂿃Q�[�W�Ǘ��p�̃N���X
public class UnchiGage : MonoBehaviour
{
    [SerializeField]
    [Tooltip("���񂿃Q�[�W�̏���̑傫��")]
    private float Unchi_gagenumber_set = 0;

    [SerializeField]
    [Tooltip("���񂿃Q�[�W�̒l")]
    private float Unchi_gagenumber = 0;

    [SerializeField]
    [Tooltip("���񂿃Q�[�W�����炷�傫��")]
    private float DcreSet=0;

    private void Start()
    {
        Unchi_gagenumber = Unchi_gagenumber_set;
    }

    //���񂿃Q�[�W�̏����ݒ�B
    public float GetterUnchi_Limit()
    {
        return Unchi_gagenumber_set;
    }

    //���񂿃Q�[�W��ݒ肷��Z�b�^�[�B
    public void SetterUnchi(int SetUnchi)
    {
        Unchi_gagenumber = SetUnchi;
    }

    //���񂿃Q�[�W�̒l���擾�B
    public float GetterUnchi()
    {
        return Unchi_gagenumber;
    }

    //���񂿃Q�[�W�����̊֐��B
    public void DcreUnchi()
    {
        //���Z�p�Ȃ̂ŁA�}�C�i�X�̒l�͓���Ȃ��B
        if (DcreSet > 0)
            Unchi_gagenumber-=Time.deltaTime*DcreSet;
        else
            Debug.Log("���Z�̒l�ɂO�ȉ��̒l�������Ă��܂��B");
    }

    //���񂿃Q�[�W���}�b�N�X�ɂȂ�����A�X�R�A���[���ɂ��ăQ�[�W�����Z�b�g����B
    public void UnchiPenalty()
    {
        //�X�R�A�����Z�b�g
        if(Unchi_gagenumber<=0)
        {
            Unchi_gagenumber = Unchi_gagenumber_set;
            ScoreSystem.instance.SetterScore(0);
        }
    }
}
