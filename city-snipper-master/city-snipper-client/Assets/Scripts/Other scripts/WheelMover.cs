using UnityEngine;
using System.Collections;

public class WheelMover : MonoBehaviour 
{
    public float turnSpeed = 10f;
    [Header("Select any of rotation axis")]
    public bool X;
    public bool Y;
    public bool Z;
    public float direction = 1f;

	void Start () 
    {
	
	}
	
	
	void Update () 
    {
        if (X)
            transform.Rotate(turnSpeed * direction, 0, 0);
        if (Y)
            transform.Rotate(0, turnSpeed * direction, 0);
        if (Z)
            transform.Rotate(0, 0, turnSpeed * direction);
	}
}
