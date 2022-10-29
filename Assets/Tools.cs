using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using Unity.VisualScripting;

public class Tools : MonoBehaviour
{
    public GameObject Weapon;
    public GameObject Flashlight;
    bool condition = true;
    private void Start()
    {
        Flashlight.SetActive(true);
    }
    private void Update()
    {
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
            /// ¬€ Àﬁ◊¿ﬂ Œ¡‹≈ “ ŒÕ œ≈–≈—“¿®“ –¿¡Œ“¿“‹ œŒÀÕŒ—“‹ » — –»œ“ Õ≈ –¿¡Œ“¿≈“ “Œ∆≈!!!!!!!!!!!!!!!
        }
    }


}
