using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int count = 0;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit")
        {
        count++;
        Debug.Log("You've bumped into a thing this many times: " + count);
        }
    }
}
