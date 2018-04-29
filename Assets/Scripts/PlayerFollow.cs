using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform PlayerTransform;
    public Vector3 offset;
    
    [Range(0.01f, 1.0f)]
    public float sFactor = 0.5f;

    public bool lookAtPlayer = false;

    // Use this for initialization
    void Start () {
        offset = transform.position - PlayerTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 neuePos = PlayerTransform.position + offset;

        transform.position = Vector3.Slerp(transform.position, neuePos, sFactor);

        if (lookAtPlayer)
            transform.LookAt(PlayerTransform);

	}
}
