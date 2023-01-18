using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanButton : MonoBehaviour
{
    public fan fn;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")|| other.CompareTag("Box"))
        {
            Switch();
        }
    }
    void Switch()
    {
        if (fn.fanOn == false)
        {
            fn.fanOn = true;
        }
        else if (fn.fanOn == true)
        {
            fn.fanOn = false;
        }
    }
    

}
