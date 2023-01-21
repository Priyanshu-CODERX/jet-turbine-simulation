using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 RotationVector;

    private void Update()
    {
        this.gameObject.transform.Rotate(RotationVector * Time.deltaTime);
    }

}
