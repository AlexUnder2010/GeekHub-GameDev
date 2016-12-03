using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationsCount : MonoBehaviour
{
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;
    
    private float tmpRotation;
    private float deltaRotation;
    private float currentRotation;

    public GameObject MercuryText;
    public GameObject VenusText;
    public GameObject EarthText;
    public GameObject MarsText;
    public GameObject JupiterText;
    public GameObject SaturnText;
    public GameObject UranusText;
    public GameObject NeptuneText;

    private int MercuryCountRot;
    private int VenusCountRot;
    private int EarthCountRot;
    private int MarsCountRot;
    private int JupiterCountRot;
    private int SaturnCountRot;
    private int UranusCountRot;
    private int NeptuneCountRot;

    private int MercuryOut;
    private int VenusOut;
    private int EarthOut;
    private int MarsOut;
    private int JupiterOut;
    private int SaturnOut;
    private int UranusOut;
    private int NeptuneOut;

    private bool MercuryFlag = true;
    private bool VenusFlag = true;
    private bool EarthFlag = true;
    private bool MarsFlag = true;
    private bool JupiterFlag = true;
    private bool SaturnFlag = true;
    private bool UranusFlag = true;
    private bool NeptuneFlag = true;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    MercuryCount();
	    VenusCount();
	    EarthCount();
	    MarsCount();
        JupiterCount();
        SaturnCount();
	    UranusCount();
        NeptuneCount();
	}

    void MercuryCount()
    {
        deltaRotation = (currentRotation - Mercury.transform.eulerAngles.y);
        currentRotation = Mercury.transform.eulerAngles.y;
        tmpRotation -= deltaRotation;
        MercuryCountRot = Convert.ToInt32(tmpRotation / 360);
        if (MercuryCountRot == 1 && MercuryFlag)
        {
            MercuryOut += 1;
            MercuryFlag = false;
        }
        if (MercuryCountRot == 0)
        {
            MercuryFlag = true;
        }
        MercuryText.GetComponent<Text>().text = MercuryOut.ToString();
    }

    void VenusCount()
    {
        deltaRotation = (currentRotation - Venus.transform.eulerAngles.y);
        currentRotation = Venus.transform.eulerAngles.y;
        tmpRotation -= deltaRotation;
        VenusCountRot = Convert.ToInt32(tmpRotation / 360);
        if (VenusCountRot == 1 && VenusFlag)
        {
            VenusOut += 1;
            VenusFlag = false;
        }
        if (VenusCountRot == 0)
        {
            VenusFlag = true;
        }
        VenusText.GetComponent<Text>().text = VenusOut.ToString();
    }
    void EarthCount()
    {
        deltaRotation = (currentRotation - Earth.transform.eulerAngles.y);
        currentRotation = Earth.transform.eulerAngles.y;
        tmpRotation -= deltaRotation;
        EarthCountRot = Convert.ToInt32(tmpRotation / 360);
        if (EarthCountRot == 1 && EarthFlag)
        {
            EarthOut += 1;
            EarthFlag = false;
        }
        if (EarthCountRot == 0)
        {
            EarthFlag = true;
        }
        EarthText.GetComponent<Text>().text = EarthOut.ToString();
    }
    void MarsCount()
    {
        deltaRotation = (currentRotation - Mars.transform.eulerAngles.y);
        currentRotation = Mars.transform.eulerAngles.y;
        tmpRotation -= deltaRotation;
        MarsCountRot = Convert.ToInt32(tmpRotation / 360);
        if (MarsCountRot == 1 && MarsFlag)
        {
            MarsOut += 1;
            MarsFlag = false;
        }
        if (MarsCountRot == 0)
        {
            MarsFlag = true;
        }
        MarsText.GetComponent<Text>().text = MarsOut.ToString();
    }
    void JupiterCount()
    {
        deltaRotation = (currentRotation - Jupiter.transform.eulerAngles.y);
        currentRotation = Jupiter.transform.eulerAngles.y;
        tmpRotation -= deltaRotation;
        JupiterCountRot = Convert.ToInt32(tmpRotation / 360);
        if (JupiterCountRot == 1 && JupiterFlag)
        {
            JupiterOut += 1;
            JupiterFlag = false;
        }
        if (JupiterCountRot == 0)
        {
            JupiterFlag = true;
        }
        JupiterText.GetComponent<Text>().text = JupiterOut.ToString();
    }
    void SaturnCount()
    {
        deltaRotation = (currentRotation - Saturn.transform.eulerAngles.y);
        currentRotation = Saturn.transform.eulerAngles.y;
        tmpRotation -= deltaRotation;
        SaturnCountRot = Convert.ToInt32(tmpRotation / 360);
        if (SaturnCountRot == 1 && SaturnFlag)
        {
            SaturnOut += 1;
            SaturnFlag = false;
        }
        if (SaturnCountRot == 0)
        {
            SaturnFlag = true;
        }
        SaturnText.GetComponent<Text>().text = SaturnOut.ToString();
    }
    void UranusCount()
    {
        deltaRotation = (currentRotation - Uranus.transform.eulerAngles.y);
        currentRotation = Uranus.transform.eulerAngles.y;
        tmpRotation -= deltaRotation;
        UranusCountRot = Convert.ToInt32(tmpRotation / 360);
        if (UranusCountRot == 1 && UranusFlag)
        {
            UranusOut += 1;
            UranusFlag = false;
        }
        if (UranusCountRot == 0)
        {
            UranusFlag = true;
        }
        UranusText.GetComponent<Text>().text = UranusOut.ToString();
    }

    void NeptuneCount()
    {
        deltaRotation = (currentRotation - Neptune.transform.eulerAngles.y);
        currentRotation = Neptune.transform.eulerAngles.y;
        tmpRotation -= deltaRotation;
        NeptuneCountRot = Convert.ToInt32(tmpRotation / 360);
        if (NeptuneCountRot == 1 && NeptuneFlag)
        {
            NeptuneOut += 1;
            NeptuneFlag = false;
        }
        if (NeptuneCountRot == 0)
        {
            NeptuneFlag = true;
        }
        NeptuneText.GetComponent<Text>().text = NeptuneOut.ToString();
    }

}
