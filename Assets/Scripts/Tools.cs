using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine.Experimental.GlobalIllumination;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine.UI;


public class Tools : MonoBehaviour
{
    public GameObject Weapon;
    public GameObject Flashlight;
    public GameObject FlashlightLight;
    public Light FL;
    public static float power = 1;
    private void Start()
    {
        Flashlight.SetActive(true);
        HealthBar.fill = 1f;
    }
    private void Update()
    {
        ///��������� ���������� �������� ��� �������
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Q");
            if (Flashlight.activeSelf==true)
            {
                Flashlight.SetActive(false);
                FL.enabled=false;
                HealthBar.Con = false;
                Debug.Log("false activated");
            }
            else
            {
                Flashlight.SetActive(true);
                Debug.Log("Active activated");
            }
            /// �������� ������ �� ��������� �������� �������� � ������ �� �������� ����!!!!!!!!!!!!!!!
        }
        ///��������� ���������� ����� ��������
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (Flashlight.activeSelf==true)
            {
                if (FL.enabled==false)
                {
                    FL.enabled = true;
                    Debug.Log("������� ����ר� � ������ ��� ���� ����ר� ");
                    Debug.Log("power--");
                    HealthBar.Con = true;
                }
                else
                {
                    FL.enabled = false;
                    Debug.Log("������� ����ר� � ������ ��� ���� �������� ");
                    Debug.Log("Power++");
                    HealthBar.Con = false;

                }
            }
            else
            {
                if (FL.enabled == false)
                {
                    FL.enabled = false;
                    Debug.Log("������� �������� � ���� ����");
                    Debug.Log("Power+");
                    HealthBar.Con = false;
                }
                else
                {
                    FL.enabled = false;
                    Debug.Log("������� �������� � ���� ����");
                    Debug.Log("Power+");
                    HealthBar.Con = false;
                }
            }
            
        }
        ///����� ������ ��������
        
    }
}
 