using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image bar;
    public static float fill;
    public static float constEn = 0.1F;
    public static bool Con;
    // Start is called before the first frame update
    void Start()
    { 
        fill = 1f; 
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = fill;
        if (Con == true)
        {
            fill = fill - Time.deltaTime * constEn;
            if (fill<=0)
            {
                fill = 0;
            }
        }
        if (Con == false)
        {
            fill = fill + Time.deltaTime * constEn;
            if (fill >= 1)
            {
                fill = 1;
            }
        }
        ///fill = fill - Time.deltaTime * constEn;
    }
}
