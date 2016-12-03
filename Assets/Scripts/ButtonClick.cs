using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button button;
    public GameObject Orbit1;
    public GameObject Orbit2;
    public GameObject Orbit3;
    public GameObject Orbit4;
    public GameObject Orbit5;
    public GameObject Orbit6;
    public GameObject Orbit7;
    public GameObject Orbit8;
    // Use this for initialization
    void Start () {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
	    if (Orbit1.activeSelf != true)
	    {
            Orbit1.SetActive(true);
            Orbit2.SetActive(true);
            Orbit3.SetActive(true);
            Orbit4.SetActive(true);
            Orbit5.SetActive(true);
            Orbit6.SetActive(true);
            Orbit7.SetActive(true);
            Orbit8.SetActive(true);
        }
        else
        {
            Orbit1.SetActive(false);
            Orbit2.SetActive(false);
            Orbit3.SetActive(false);
            Orbit4.SetActive(false);
            Orbit5.SetActive(false);
            Orbit6.SetActive(false);
            Orbit7.SetActive(false);
            Orbit8.SetActive(false);
        }

    }
}
