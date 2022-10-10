using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovement : MonoBehaviour
{
    public float camaraSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(camaraSpeed * Time.deltaTime, 0, 0);
    }
}
