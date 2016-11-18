using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go_Button : MonoBehaviour
{
    public GameObject Ball;
    private float time;
    private float tmp;
	// Use this for initialization
    void OnMouseDown()
    {
        tmp = Time.time;  
    }

    void OnMouseUp()
    {
        time = Time.time - tmp;
        Ball.GetComponent<Rigidbody>().AddForce((transform.right + transform.forward) * (time*100));
    }
}
