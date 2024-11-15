using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Toilet : CollisionHit
{
    [SerializeField]
    private UnchiGage Ug=null;

    private Hit_Toilet() : base()
    {

    }

    public override void HitEnter(Collision collision)
    {
        //���񂿃Q�[�W�̒l�����Z�b�g�B
        Ug.SetterUnchi(Ug.GetterUnchi_Limit());
    }

    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        //�v���C���[�ɐG�ꂽ��A���U���g�V�[���Ɍ����������B
        if (collision.gameObject.tag == "Toilet")
        {
            SoundSystem.instance.PlaySEs(3);
            HitEnter(collision);
            BoxCollider boxc=collision.gameObject.GetComponent<BoxCollider>();
            Destroy(boxc);
        }
    }
}
