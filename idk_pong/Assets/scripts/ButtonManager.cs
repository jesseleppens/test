using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    int n;
    public Text buttonText;

    public void OnButtonPress()
    {
        n+=2;
        buttonText.text = n.ToString();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //even een commentje xxxx
}
