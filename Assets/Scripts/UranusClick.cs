using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusClick : MonoBehaviour {

    public GameObject Uranus;
    public GameObject UranusText;
    public GameObject UranusText1;
	public GameObject UranusText2;
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
        if (UranusText.activeSelf && UranusText1.activeSelf)
        {
            UranusText.SetActive(false);
            UranusText1.SetActive(false);
			UranusText2.SetActive(false);
        }
        else
        {
            UranusText.SetActive(true);
            UranusText1.SetActive(true);
			UranusText2.SetActive(true);
        }
        
    }
}
