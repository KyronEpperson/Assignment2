using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float menuSphereSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, menuSphereSpeed * Time.deltaTime, 0);
    }

    public void AdjustSpeed(float newSpeed)
    {
        menuSphereSpeed = newSpeed;
    }
}
