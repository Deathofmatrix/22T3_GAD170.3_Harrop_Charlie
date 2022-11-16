using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheVoid : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("the collision has been triggered");
    }
}
