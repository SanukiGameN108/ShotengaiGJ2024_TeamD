using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem_Base : MonoBehaviour
{
    [SerializeField]
    [Tooltip("���M�b�h�{�f�B")]
    protected Rigidbody2D rb=null;

    // Start is called before the first frame update
    protected MoveSystem_Base()
    {
        this.GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //���M�b�h�{�f�B���擾�B
}
