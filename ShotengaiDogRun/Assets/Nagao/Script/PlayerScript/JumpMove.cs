using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("�W�����v��")]
    float JumpPower = 0;

    //�ڒn����p�C���X�^���X
    private Hit_Ground hit_ground=null;

    public JumpMove() : base()
    {

    }

    //�ڒn������擾�BAwake�Ƃ͕����ď����B
    private void Start()
    {
        hit_ground = this.gameObject.GetComponent<Hit_Ground>();
    }

    public void PushToJump()
    {
        //�ڒn���肪��łȂ���΁A�W�����v�����͍s��Ȃ��B
        if (hit_ground != null)
        {
            if (hit_ground.Is_HittingGround() && Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("�W�����v");
                rb.AddForce(new Vector3(0, JumpPower, 0),ForceMode.Impulse);
            }
        }
        else
        {
            Debug.Log("�ڒn����p�̃R���W����������܂���");
        }
    }
}
