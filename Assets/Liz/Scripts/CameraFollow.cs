using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraOffsest;
    //public float CameraSpeed;
    public float smooth = 0.5f;

    public bool lookAtTarget = false;
    
    // Start is called before the first frame update
    void Start()
    {
        cameraOffsest = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, player.position.z);
        //transform.position = new Vector3(0, 0, transform.position.z);
    }

    void LateUpdate()
    {
        Vector3 newPosition = player.transform.position + cameraOffsest;
        transform.position = Vector3.Slerp(transform.position, newPosition, smooth);

        if (lookAtTarget)
        {
            transform.LookAt(player);
        }

    }

}
