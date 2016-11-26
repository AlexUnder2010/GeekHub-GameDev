using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {
    public GameObject button;
    public GameObject scrollView;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    button.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        scrollView.GetComponent<Animator>().SetBool("Visible", true);
        scrollView.GetComponent<Animator>().SetBool("Invisible", false);
    }
}
