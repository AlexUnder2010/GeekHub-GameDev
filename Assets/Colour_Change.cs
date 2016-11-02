using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Colour_Change : MonoBehaviour
{
    public GameObject Door;
    public float Distance;
    public float tmp;
    // Use this for initialization
    void Start ()
    {
        Door = (GameObject)gameObject; 
    }
	
	// Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("Player").gameObject;
        Distance = (float)(Door.transform.position - Player.transform.position).magnitude/10;
        tmp = 1/(Mathf.Exp(Distance)-1);
        gameObject.GetComponent<Renderer>().material.color = new Color(tmp,tmp,tmp);
    }
}