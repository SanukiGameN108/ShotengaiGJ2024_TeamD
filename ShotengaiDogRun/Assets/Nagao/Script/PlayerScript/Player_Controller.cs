using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    //����ɕK�v�ȃC���X�^���X���擾�B
    //�ړ��֘A
    [SerializeField]
    [Tooltip("���ړ��̃N���X")]
    private WideMove widemove=null;

    [SerializeField]
    [Tooltip("���ړ��̃N���X")]
    private JumpMove jumpmove=null;

    [SerializeField]
    [Tooltip("�ڒn����̃N���X")]
    private Hit_Ground hit_ground=null;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    //�ړ��֘A�̏����B
    private void Move()
    {
        widemove.MovingRight();
        jumpmove.PushToJump();
    }
}
