using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pivotPoint = transform.position;
        transform.RotateAround(pivotPoint, Vector3.up, 45*Time.deltaTime);
    }
}
