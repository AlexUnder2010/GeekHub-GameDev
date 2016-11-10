using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kids_Mode : MonoBehaviour
{
    public GameObject horror_light;
    public GameObject BackLight;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void OnTriggerEnter()
    {
        BackLight.GetComponent<Light>().enabled = true;
        horror_light.GetComponent<Light_Flicker>().enabled = false;
        horror_light.GetComponent<Light>().enabled = true;
        horror_light.GetComponent<Light>().color = Color.white;
        horror_light.GetComponent<Light>().type = LightType.Point;

    }
}
