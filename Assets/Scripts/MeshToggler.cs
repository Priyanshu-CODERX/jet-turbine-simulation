using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshToggler : MonoBehaviour
{
    public GameObject _Object;
    private bool IsActive = true;

    public void ToggleMesh()
    {
        if (IsActive)
        {
            _Object.SetActive(false);
            IsActive = false;
        }
        else
        {
            _Object.SetActive(true);
            IsActive = true;
        }
    }

}
