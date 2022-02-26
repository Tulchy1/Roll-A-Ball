using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] float Angle = 1f;
    void Update()
    {
        transform.Rotate(0,Angle,0);
    }
}
