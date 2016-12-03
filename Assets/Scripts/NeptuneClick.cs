using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptuneClick : MonoBehaviour {

    public GameObject Neptune;
    public GameObject NeptuneText;
    public GameObject NeptuneText1;
	public GameObject NeptuneText2;
	public GameObject Info1;
	public GameObject Info2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
    {
		if (Info1.activeSelf == false && Info2.activeSelf == false)
		{
			Info1.SetActive(true);
            Info2.SetActive(true);
		}
        if (NeptuneText.activeSelf && NeptuneText1.activeSelf)
        {
            NeptuneText.SetActive(false);
            NeptuneText1.SetActive(false);
			NeptuneText2.SetActive(false);
        }
        else
        {
            NeptuneText.SetActive(true);
            NeptuneText1.SetActive(true);
			NeptuneText2.SetActive(true);
        }
        
    }
}
