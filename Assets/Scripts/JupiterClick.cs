using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterClick : MonoBehaviour {

	public GameObject Jupiter;
    public GameObject JupiterText;
    public GameObject JupiterText1;
	public GameObject JupiterText2;
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
        if (JupiterText.activeSelf && JupiterText1.activeSelf)
        {
            JupiterText.SetActive(false);
            JupiterText1.SetActive(false);
			JupiterText2.SetActive(false);
        }
        else
        {
            JupiterText.SetActive(true);
            JupiterText1.SetActive(true);
			JupiterText2.SetActive(true);
        }
        
    }
}
