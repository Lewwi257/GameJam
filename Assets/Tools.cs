using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Unity.VisualScripting;

public class Tools : MonoBehaviour
{
    public GameObject Weapon;
    public GameObject Flashlight;
    public GameObject FlashlightLight;
    private void Start()
    {
        Flashlight.SetActive(true);
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
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (FlashlightLight.activeSelf == false && Flashlight.activeSelf == true)
            {
                FlashlightLight.SetActive(true);
            }
        }
    }


}
