using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 movement;
    public int xi, yi, zi;
    void Start()
    {
        movement = new Vector3(xi, yi, zi);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(movement * Time.deltaTime);
    }
}
