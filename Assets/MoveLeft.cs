using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    public GameObject Ball;
    public float speed = 0.1f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseDown () {
        Ball.transform.position += Ball.transform.right * -speed * Time.deltaTime;
    }
}
