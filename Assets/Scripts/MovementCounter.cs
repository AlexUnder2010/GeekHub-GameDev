using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementCounter : MonoBehaviour {

    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;

    public GameObject MercuryText;
    public GameObject VenusText;
    public GameObject EarthText;
    public GameObject MarsText;
    public GameObject JupiterText;
    public GameObject SaturnText;
    public GameObject UranusText;
    public GameObject NeptuneText;

    private int cMercury;
    private int cVenus;
    private int cEarth;
    private int cMars;
    private int cJupiter;
    private int cSaturn;
    private int cUranus;
    private int cNeptune;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == Mercury.tag)
        {
            cMercury += 1;
            MercuryText.GetComponent<Text>().text = cMercury.ToString();
        }
        if (other.tag == Venus.tag)
        {
            cVenus += 1;
            VenusText.GetComponent<Text>().text = cVenus.ToString();
        }
        if (other.tag == Earth.tag)
        {
            cEarth += 1;
            EarthText.GetComponent<Text>().text = cEarth.ToString();
        }
        if (other.tag == Mars.tag)
        {
            cMars += 1;
            MarsText.GetComponent<Text>().text = cMars.ToString();
        }
        if (other.tag == Jupiter.tag)
        {
            cJupiter += 1;
            JupiterText.GetComponent<Text>().text = cJupiter.ToString();
        }
        if (other.tag == Saturn.tag)
        {
            cSaturn += 1;
            SaturnText.GetComponent<Text>().text = cSaturn.ToString();
        }
        if (other.tag == Uranus.tag)
        {
            cUranus += 1;
            UranusText.GetComponent<Text>().text = cUranus.ToString();

        }
        if (other.tag == Neptune.tag)
        {
            cNeptune += 1;
            NeptuneText.GetComponent<Text>().text = cNeptune.ToString();
        }
    }
}
