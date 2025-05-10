using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform cameraPosition;
    
    private void Update()
    {

        transform.position = cameraPosition.position;
    }
}
