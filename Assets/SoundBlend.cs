using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundBlend : MonoBehaviour
{
    public GameObject Player;
    public GameObject Speaker1;
    public GameObject Speaker2;



    private double distance1;
    private double distance2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distance1 = Vector3.Distance(Player.transform.position, Speaker1.transform.position);
        distance2 = Vector3.Distance(Player.transform.position, Speaker2.transform.position);
        Mixer();
    }

    void Mixer()
    {
        if (distance1 < 7.5 && distance2 < 7.5)
        {
            Speaker1.GetComponent<AudioSource>().minDistance = 8;
            Speaker1.GetComponent<AudioSource>().maxDistance = 8;
            Speaker2.GetComponent<AudioSource>().minDistance = 8;
            Speaker2.GetComponent<AudioSource>().maxDistance = 8;
        }
        else
        {
            Speaker1.GetComponent<AudioSource>().minDistance = 1;
            Speaker1.GetComponent<AudioSource>().maxDistance = 12;
            Speaker2.GetComponent<AudioSource>().minDistance = 1;
            Speaker2.GetComponent<AudioSource>().maxDistance = 12;
        }
    }
}
