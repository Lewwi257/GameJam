using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine.Experimental.GlobalIllumination;

public class Tools : MonoBehaviour
{
    public GameObject Weapon;
    public GameObject Flashlight;
    public GameObject FlashlightLight;
    public Light FL;
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
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (Flashlight.activeSelf==true)
            {
                if (FL.enabled==false)
                {
                    FL.enabled = true;
                    Debug.Log("ÔÎÍÀĞÈÊ ÂÊËŞ×¨Í È ÒÎËÜÊÎ ×ÒÎ ÑÂÅÒ ÂÊËŞ×¨Í ");
                }
                else
                {
                    FL.enabled = false;
                    Debug.Log("ÔÎÍÀĞÈÊ ÂÊËŞ×¨Í È ÒÎËÜÊÎ ×ÒÎ ÑÂÅÒ ÂÛÊËŞ×ÅÍ ");
                }
            }
            else
            {
                FL.enabled=false;
                Debug.Log("ÔÎÍÀĞÈÊ ÂÛÊËŞ×ÅÍ È ÑÂÅÒ ÒÎÆÅ");
            }
            
        }
    }


}
