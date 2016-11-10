using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Light_Flicker : MonoBehaviour
{
    public GameObject Flashlight;
	// Use this for initialization
	void Start () {
        GetComponent<Light>().enabled = false;
    }
	
	// Update is called once per frame
	void FixedUpdate ()
	{
        
        float Number = Random.value;
	    if (Number <= 0.9)
	    {
	        GetComponent<Light>().enabled = true;
	        GetComponent<Light>().intensity = Number + 5.0f;
	    }
	    else
	    {
            GetComponent<Light>().enabled = false;
            GetComponent<Light>().intensity = Number + 1.0f;
        }  
	}
}
