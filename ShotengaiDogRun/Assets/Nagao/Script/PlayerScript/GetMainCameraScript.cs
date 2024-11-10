using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainCameraScript : MonoBehaviour
{
    [SerializeField]
    [Tooltip("カメラ用インスタンス")]
    private Camera maincamera = null;

    [SerializeField]
    [Tooltip("プレイヤーへの接近度")]
    private float Moveaway = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>a
    /// 現在地にカメラを移す。
    /// </summary>
    public void SetNowPos()
    {
        maincamera.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y, -Moveaway);
    }
}
