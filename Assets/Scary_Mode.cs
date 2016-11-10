using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scary_Mode : MonoBehaviour
{
    public GameObject horror_light;
    public GameObject BackLight;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void OnTriggerEnter()
    {
        BackLight.GetComponent<Light>().enabled = false;
        horror_light.GetComponent<Light_Flicker>().enabled = true;
        horror_light.GetComponent<Light>().enabled = true;
        horror_light.GetComponent<Light>().color = Color.red;
        horror_light.GetComponent<Light>().type = LightType.Spot;

    }
}
