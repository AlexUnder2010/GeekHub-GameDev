using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnClick : MonoBehaviour {

    public GameObject Saturn;
    public GameObject SaturnText;
    public GameObject SaturnText1;
	public GameObject SaturnText2;
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
        if (SaturnText.activeSelf && SaturnText1.activeSelf)
        {
            SaturnText.SetActive(false);
            SaturnText1.SetActive(false);
			SaturnText2.SetActive(false);
        }
        else
        {
            SaturnText.SetActive(true);
            SaturnText1.SetActive(true);
			SaturnText2.SetActive(true);
        }
        
    }
}
