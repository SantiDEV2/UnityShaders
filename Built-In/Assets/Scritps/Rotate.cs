using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1 * Time.deltaTime * speed, 1 * Time.deltaTime * speed, 0);
    }
}
