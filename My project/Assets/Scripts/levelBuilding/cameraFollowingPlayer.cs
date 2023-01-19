using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowingPlayer : MonoBehaviour
{

    public Transform player;
    public float offsetOnX = 0f;
    public float offsetOnY = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(player.position.x + offsetOnX, player.position.y + offsetOnY, this.transform.position.z);
    }
}
