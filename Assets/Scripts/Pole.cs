using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    private float speed = 50f;

    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 1f, 0),1f * speed * Time.deltaTime);
    }
}
