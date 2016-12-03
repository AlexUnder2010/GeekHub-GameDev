using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalMovement : MonoBehaviour
{
    private int MercuryDistance = 3;
    private int VenusDistance = 6;
    private int EarthDistance = 9;
    private int MarsDistance = 12;
    private int JupiterDistance = 15;
    private int SaturnDistance = 18;
    private int UranusDistance = 21;
    private int NeptuneDistance = 24;

    public GameObject Sun;
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Mercury.transform.position = (Mercury.transform.position - Sun.transform.position).normalized * MercuryDistance + Sun.transform.position;
        Venus.transform.position   = (Venus.transform.position   - Sun.transform.position).normalized * VenusDistance   + Sun.transform.position;
        Earth.transform.position   = (Earth.transform.position   - Sun.transform.position).normalized * EarthDistance   + Sun.transform.position;
        Mars.transform.position    = (Mars.transform.position    - Sun.transform.position).normalized * MarsDistance    + Sun.transform.position;
        Jupiter.transform.position = (Jupiter.transform.position - Sun.transform.position).normalized * JupiterDistance + Sun.transform.position;
        Saturn.transform.position  = (Saturn.transform.position  - Sun.transform.position).normalized * SaturnDistance  + Sun.transform.position;
        Uranus.transform.position  = (Uranus.transform.position  - Sun.transform.position).normalized * UranusDistance  + Sun.transform.position;
        Neptune.transform.position = (Neptune.transform.position - Sun.transform.position).normalized * NeptuneDistance + Sun.transform.position;
    }
}
