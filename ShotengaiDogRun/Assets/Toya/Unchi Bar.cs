using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnchiBar : MonoBehaviour
{
    public Slider unchiSlider;
    public int unchiHP = 0;
    //currenHPによってスライダーが変わる
    public int currenHP;
    public Image fillImage;

    // Start is called before the first frame update
    void Start()
    {
        currenHP = unchiHP;
        unchiSlider.maxValue = unchiHP;
        UpdateHP();
    }

    public void TakeUnchi(int unchi)
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

    private void Update()
    {
        UpdateHP();
    }
}