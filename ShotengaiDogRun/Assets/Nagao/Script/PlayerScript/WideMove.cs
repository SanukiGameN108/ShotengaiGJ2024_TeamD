using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideMove : MoveSystem_Base
{
    [SerializeField]
    [Tooltip("移動スピード")]
    private readonly float MoveSpeed = 0;

    WideMove(): base()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //自動的に右に移動する関数。
    public void MovingRight()
    {
        gameObject.transform.Translate(MoveSpeed,0,0);
    }
}
