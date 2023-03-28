using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCameraScript : MonoBehaviour
{
    public Transform PlayerTransform;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CameraPos = transform.position;
        CameraPos.z = PlayerTransform.position.z + offset;    //offset = -7
        transform.position = CameraPos;
    }
}
