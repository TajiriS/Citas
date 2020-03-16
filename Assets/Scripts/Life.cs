using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public float Interest;
    public float Expectation;

    public Slider interslide;
    public Slider expectslide;

    public Text intertxt;
    public Text expecttxt;
    
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        interslide.value = Interest;
        intertxt.text = "Interest: " + Interest.ToString()+ "/100";
        expectslide.value = Expectation;
        expecttxt.text = "Expectation: " + Expectation.ToString() + "/100";
    }

    public void Expectate(float evalue, float ivalue)
    {
        Expectation -= evalue;
        Interest += ivalue;
    }

   
}
