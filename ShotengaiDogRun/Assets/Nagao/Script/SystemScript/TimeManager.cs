using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        TimeCounting();
    }

    //�������Ԃ��v���B
    void TimeCounting()
    {
        TimeSystem.instance.CountDownTime();
        TimeSystem.instance.CountOneSecond();
    }
}
