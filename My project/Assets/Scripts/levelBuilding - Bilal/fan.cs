using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour
{
    public bool fanOn = false;
    public bool fanDirection = false;
    public int direction = 1;
    public int fanPower = 5;

    
    void OnTriggerStay2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            if (fanOn == true)
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * fanPower * direction);
            }
        }
        if (other.CompareTag("box"))
        {
            if (fanOn == true)
            {
                other.GetComponent<Rigidbody2D>().AddForce(Vector2.right * fanPower * direction, ForceMode2D.Impulse);
            }
        }
    }
}


    
