using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    private GameObject button;
    private GameObject scrollView;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        button = GameObject.FindGameObjectWithTag("Button");
        scrollView = GameObject.FindGameObjectWithTag("ScrollView");
        if (button.activeSelf == false)
        {
            scrollView.GetComponent<Animator>().SetBool("Visible", false);
            scrollView.GetComponent<Animator>().SetBool("Invisible", true);

        }
        

        scrollView.GetComponent<Animator>().SetBool("Visible", true);
        scrollView.GetComponent<Animator>().SetBool("Invisible", false);
    }
}
