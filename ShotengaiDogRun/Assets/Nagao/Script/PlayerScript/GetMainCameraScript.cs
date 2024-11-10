using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainCameraScript : MonoBehaviour
{
    [SerializeField]
    [Tooltip("�J�����p�C���X�^���X")]
    private Camera maincamera = null;

    [SerializeField]
    [Tooltip("�v���C���[�ւ̐ڋߓx")]
    private float Moveaway;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>a
    /// ���ݒn�ɃJ�������ڂ��B
    /// </summary>
public void SetNowPos()
    {
        maincamera.transform.position = new Vector3(
            gameObject.transform.position.x,
            maincamera.transform.position.y,
            -Moveaway
        );
    }
}
