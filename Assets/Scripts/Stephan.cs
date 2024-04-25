using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stephan : MonoBehaviour
{

    public GameObject canvas;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showText()
    {
        canvas.SetActive(true);

    }

    public void closeText()
    {
        canvas.SetActive(false);

    }

    public void changeText()
    {
        text.text = "changed";
    }
}
