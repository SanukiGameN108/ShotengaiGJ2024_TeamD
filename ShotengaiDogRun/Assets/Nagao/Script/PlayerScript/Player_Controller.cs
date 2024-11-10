using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MoveSystem_Base
{
    public Player_Controller() : base()
    {

    }

    //����ɕK�v�ȃC���X�^���X���擾�B
    //�ړ��֘A
    [SerializeField]
    [Tooltip("���ړ��̃N���X")]
    private WideMove widemove=null;

    [SerializeField]
    [Tooltip("���ړ��̃N���X")]
    private JumpMove jumpmove=null;

    [SerializeField]
    [Tooltip("��Q���ڐG�̃N���X")]
    private Hit_Damage hit_damage = null;

    [SerializeField]
    [Tooltip("�ڒn����̃N���X")]
    private Hit_Ground hit_ground=null;

    [SerializeField]
    [Tooltip("�N�[���^�C�������p�̃N���X�B")]
    private CoolTimeBool cooltimebool = null;

    [SerializeField]
    [Tooltip("���C���J�����ݒ�p�̃N���X�B")]
    private GetMainCameraScript getmaincamerascript = null;

    private void Start()
    {
        //�N�[���^�C��������ݒ�B
        hit_damage.SetAct(cooltimebool.SetCoolTime);
    }

    // Update is called once per frame
    void Update()
    {
        //�N�[���^�C������������Ă���΁A�������Ƃ��ł���B�i���͈ꎞ�I�ɃN�[���^�C�������b�B�ǉ�����Ȃ疳�G���Ԃ�t�^����K�v�A���B�j
        /*if (cooltimebool.Is_CoolTime_Clear())
        {
            Move();
        }
        else
        {
            cooltimebool.CountDown();
        }*/

        Move();
        CameraSettings();
    }

    //�ړ��֘A�̏����B
    private void Move()
    {
        widemove.MovingRight();
        jumpmove.PushToJump();
    }

    //�J�����ݒ�p�̃N���X�B
    public void CameraSettings()
    {
        getmaincamerascript.SetNowPos();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "DamageObject")
        {
            gameObject.transform.Translate(0, 0, -1);
            SoundSystem.instance.PlaySEs(2);
        }
    }
}
