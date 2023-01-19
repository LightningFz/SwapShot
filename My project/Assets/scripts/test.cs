using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public test instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0)) // returns true when the mouse left button is pressed
      {
            Vector3 mousePos = Input.mousePosition;   
            mousePos.z=Camera.main.nearClipPlane;
            Vector3 Worldpos=Camera.main.ScreenToWorldPoint(mousePos);  
       }
    }
}
