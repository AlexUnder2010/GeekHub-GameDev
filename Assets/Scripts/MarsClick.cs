using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsClick : MonoBehaviour {
	
    public GameObject Mars;
    public GameObject MarsText;
    public GameObject MarsText1;
	public GameObject MarsText2;
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
        if (MarsText.activeSelf && MarsText1.activeSelf)
        {
            MarsText.SetActive(false);
            MarsText1.SetActive(false);
			MarsText2.SetActive(false);
        }
        else
        {
            MarsText.SetActive(true);
            MarsText1.SetActive(true);
			MarsText2.SetActive(true);
        }
        
    }
}
