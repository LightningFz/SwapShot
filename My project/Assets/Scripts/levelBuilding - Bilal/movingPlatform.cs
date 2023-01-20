using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    public Transform posA, posB;
    public int Speed;
    public float timer;
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos=posB.position;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Vector2.Distance(transform.position, posA.position) < .1f) Invoke("Action1", timer);
        if (Vector2.Distance(transform.position, posB.position) < .1f) Invoke("Action2", timer);

        transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
    }
    public void Action1()
    {
        targetPos = posB.position;
    }
    public void Action2()
    {
        targetPos = posA.position;
    }
}
