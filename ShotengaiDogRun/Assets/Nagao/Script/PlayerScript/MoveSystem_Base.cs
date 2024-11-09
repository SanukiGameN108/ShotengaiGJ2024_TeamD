using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem_Base : MonoBehaviour
{
    [SerializeField]
    [Tooltip("���M�b�h�{�f�B")]
    protected Rigidbody rb= null;

    // Start is called before the first frame update

    protected void Awake()
    {
        GetRigid();
    }

    //���M�b�h�{�f�B���擾���邽�߂̊֐��B�R���X�g���N�^�Ŏg���B
    protected void GetRigid()
    {
        //���M�b�h�{�f�B������΁A������擾����B
        if (this.GetComponent<Rigidbody>() != null)
        {
            Debug.Log("���M�b�h�{�f�B���擾�I");
            rb =this.GetComponent<Rigidbody>();
        }
        else
        {
            Debug.Log("���M�b�h�{�f�B�̎擾�Ɏ��s���܂����B");
        }
    }
}
