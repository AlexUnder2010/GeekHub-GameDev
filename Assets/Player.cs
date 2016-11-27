using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    float deltaTime = 0.0f;

    public GameObject Content;
    public GameObject Scrollview;

    public float ButtonDistance = 4.5f;
    public float RealDistance = 0;
    public Transform image1;
    public Transform image2;
    public Transform image3;
    public Transform image4;

    public GameObject Bottom_Left_Text;
    public GameObject Button;

    private float dist1;
    private float dist2;
    private float dist3;
    private float dist4;

    private float min;
    private float curr;


    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = new Color(0.0f, 0.0f, 0.5f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        GUI.Label(rect, text, style);
    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        min = Vector3.Distance(image1.position, transform.position);
        curr = Vector3.Distance(image2.position, transform.position);

        dist1 = Vector3.Distance(image1.position, transform.position);
        dist2 = Vector3.Distance(image2.position, transform.position);
        dist3 = Vector3.Distance(image3.position, transform.position);
        dist4 = Vector3.Distance(image4.position, transform.position);

        Scrollview_Check();
        Painting_Name();
        Button_Trigger();
    }

    void Painting_Name()
    {
        string text = "Leonardo Da Vinci - Mona Lisa";
        if (min > curr)
        {
            text = "Unknown - Ship";
            min = curr;
        }
        curr = Vector3.Distance(image3.position, transform.position);


        if (min > curr)
        {
            text = "Victor Vasnetsov - Three Heroes";
            min = curr;
        }
        curr = Vector3.Distance(image4.position, transform.position);

        if (min > curr)
        {
            text = "Edvard Munch - Skrik";
        }
        Bottom_Left_Text.GetComponent<Text>().text = text;

    }

    void Button_Trigger()
    {
        if ((dist1 < ButtonDistance) || (dist2 < ButtonDistance) || (dist3 < ButtonDistance) || (dist4 < ButtonDistance))
            Button.SetActive(true);
        else
        {
            Scrollview.GetComponent<Animator>().SetBool("Visible", false);
            Scrollview.GetComponent<Animator>().SetBool("Invisible", true);
            Button.SetActive(false);
        }
}

    void Scrollview_Check()
    {
        if (Bottom_Left_Text.GetComponent<Text>().text == "Leonardo Da Vinci - Mona Lisa" && Button.activeSelf)
        {
            Content.GetComponent<Text>().text = "The painting, thought to be a portrait of Lisa Gherardini, the wife of Francesco del Giocondo, is in oil on a white Lombardy poplar panel, and is believed to have been painted between 1503 and 1506. Leonardo may have continued working on it as late as 1517. It was acquired by King Francis I of France and is now the property of the French Republic, on permanent display at the Louvre Museum in Paris since 1797.";
        }
        else if (Bottom_Left_Text.GetComponent<Text>().text == "Unknown - Ship" && Button.activeSelf)
        {
            Content.GetComponent<Text>().text = "Just a picture from Google";
        }
        else if (Bottom_Left_Text.GetComponent<Text>().text == "Victor Vasnetsov - Three Heroes" && Button.activeSelf)
        {
            Content.GetComponent<Text>().text = "Three of the most famous bogatyrs, Dobrynya Nikitich, Ilya Muromets and Alyosha Popovich, are represented together in Victor Vasnetsov's 1898 painting Bogatyrs.";
        }
        else if (Bottom_Left_Text.GetComponent<Text>().text == "Edvard Munch - Skrik" && Button.activeSelf)
        {
            Content.GetComponent<Text>().text = "The Scream (Norwegian: Skrik) is the popular name given to each of four versions of a composition, created as both paintings and pastels, by the Expressionist artist Edvard Munch between 1893 and 1910. The German title Munch gave these works is Der Schrei der Natur (The Scream of Nature). The works show a figure with an agonized expression against a landscape with a tumultuous orange sky. Arthur Lubow has described The Scream as an icon of modern art, a Mona Lisa for our time.";
        }
    }
}
