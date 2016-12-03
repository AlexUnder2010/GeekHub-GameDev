using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthClick : MonoBehaviour {

	public GameObject Earth;
    public GameObject EarthText;
    public GameObject EarthText1;
	public GameObject EarthText2;
	public GameObject Info1;
	public GameObject Info2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
    {
		if (Info1.activeSelf == false && Info2.activeSelf == false)
		{
			Info1.SetActive(true);
            Info2.SetActive(true);
		}
        if (EarthText.activeSelf && EarthText1.activeSelf)
        {
            EarthText.SetActive(false);
            EarthText1.SetActive(false);
			EarthText2.SetActive(false);
        }
        else
        {
            EarthText.SetActive(true);
            EarthText1.SetActive(true);
			EarthText2.SetActive(true);
        }
        
    }
}
