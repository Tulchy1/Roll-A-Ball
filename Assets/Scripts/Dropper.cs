using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 3f;
    MeshRenderer renderer;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeToWait)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
