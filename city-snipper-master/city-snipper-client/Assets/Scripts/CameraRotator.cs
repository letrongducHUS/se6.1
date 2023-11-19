using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{

    public float speedRotatorx;
    public float speedRotatory;
    public float speedRotatorz;


    public float speedTouch = 2f;

    private float yaw = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {           
        transform.Rotate(speedRotatorx * Time.deltaTime, speedRotatory * Time.deltaTime, speedRotatorz*Time.deltaTime);
    }
}
