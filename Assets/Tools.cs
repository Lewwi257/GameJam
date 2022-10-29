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
        ///ÂÊËŞ×ÅÍÈÅ ÂÛÊËŞ×ÅÍÈÅ ÔÎÍÀĞÈÊÀ ÊÀÊ ÎÁÜÅÊÒÀ
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
            /// ÂÛÊËŞ×Àß ÎÁÜÅÊÒ ÎÍ ÏÅĞÅÑÒÀ¨Ò ĞÀÁÎÒÀÒÜ ÏÎËÍÎÑÒÜ È ÑÊĞÈÏÒ ÍÅ ĞÀÁÎÒÀÅÒ ÒÎÆÅ!!!!!!!!!!!!!!!
        }
        ///ÂÊËŞ×ÅÍÈÅ ÂÛÊËŞ×ÅÍÈÅ ÑÂÅÒÀ ÔÎÍÀĞÈÊÀ
        if (Input.GetKey(KeyCode.Mouse1))
        {
            if (FlashlightLight.activeSelf == false && Flashlight.activeSelf == true)
            {
                FlashlightLight.SetActive(true);
            }
        }
    }


}
