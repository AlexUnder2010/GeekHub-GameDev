using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercuryClick : MonoBehaviour
{
    public GameObject Mercury;
    public GameObject MercuryText;
    public GameObject MercuryText1;
	public GameObject MercuryText2;
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
        if (MercuryText.activeSelf && MercuryText1.activeSelf)
        {
            MercuryText.SetActive(false);
            MercuryText1.SetActive(false);
			MercuryText2.SetActive(false);
        }
        else
        {
            MercuryText.SetActive(true);
            MercuryText1.SetActive(true);
			MercuryText2.SetActive(true);
        }
        
    }
    
}
