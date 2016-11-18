using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardRails : MonoBehaviour
{
    public GameObject LeftGuard;
    public GameObject RightGuard;

    void OnMouseDown()
    {
        if (LeftGuard.activeSelf)
        {
            LeftGuard.SetActive(false);
            RightGuard.SetActive(false);
        }
        else
        {
            LeftGuard.SetActive(true);
            RightGuard.SetActive(true);
        }
        
    }
}
