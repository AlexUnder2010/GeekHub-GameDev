using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusClick : MonoBehaviour {
	
    public GameObject Venus;
    public GameObject VenusText;
    public GameObject VenusText1;
	public GameObject VenusText2;
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
        if (VenusText.activeSelf && VenusText1.activeSelf)
        {
            VenusText.SetActive(false);
            VenusText1.SetActive(false);
			VenusText2.SetActive(false);
        }
        else
        {
            VenusText.SetActive(true);
            VenusText1.SetActive(true);
			VenusText2.SetActive(true);
        }
        
    }
}
