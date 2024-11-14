using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnchiBar : MonoBehaviour
{
    public Slider unchiSlider;
    public float unchiHP = 0;
    //currenHPによってスライダーが変わる
    public float currenHP;
    public Image fillImage;

    //うんちの値受け取り用
    public UnchiGage Ug = null;

    // Start is called before the first frame update
    void Start()
    {
        unchiHP = Ug.GetterUnchi_Limit();
        currenHP = Ug.GetterUnchi_Limit();
        unchiSlider.maxValue = unchiHP;
        UpdateHP();
    }

    public void TakeUnchi(float unchi)
    {
        currenHP-=unchi;
        UpdateHP();
    }
    // Update is called once per frame
    void UpdateHP()
    {
        unchiSlider.value = currenHP;
        fillImage.color = Color.white;
        //fillImage.color = new Color(0.65f, 0.32f, 0.17f);
    }

    //うんちゲージの値をCurrentHPに同期させる。
    void SynchronousUnchi()
    {
        currenHP = Ug.GetterUnchi();
    }

    private void Update()
    {
        UpdateHP();
        SynchronousUnchi();
        Ug.DcreUnchi();
        Ug.UnchiPenalty();
    }
}