using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCamera : MonoBehaviour
{

    public CinemachineVirtualCamera[] cameras;
    private int index = 0;
    private void Start()
    {
        foreach (CinemachineVirtualCamera c in cameras)
        {
            c.Priority = 0;
        }
    }
    
}
