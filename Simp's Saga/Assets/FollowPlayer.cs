using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
   
{
    public float turnSpeed = 4.0f;
    public Transform player;
    private Vector3 offset;

  
    void Start()
    {
        offset = new Vector3(player.position.x -65.0f, player.position.y + 6.0f, player.position.z + -10.0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        transform.position = player.transform.position + offset;
        transform.LookAt(player.position);
    }
}
