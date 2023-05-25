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
       cameras[0].gameObject.SetActive(true);
       cameras[1].gameObject.SetActive(false);
       cameras[2].gameObject.SetActive(false);
       cameras[3].gameObject.SetActive(false);
       cameras[4].gameObject.SetActive(false);
    }

    public void Tienda()
    {
        cameras[0].gameObject.SetActive(false);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(false);
        cameras[3].gameObject.SetActive(true);
        cameras[4].gameObject.SetActive(false);
    }

    public void Minijuegos()
    {
        cameras[0].gameObject.SetActive(false);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(true);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(false);
    }

    public void Gacha()
    {
        cameras[0].gameObject.SetActive(false);
        cameras[1].gameObject.SetActive(true);
        cameras[2].gameObject.SetActive(false);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(false);
    }

    public void Clothes()
    {
        cameras[0].gameObject.SetActive(false);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(false);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(true);
    }

    public void Inicio()
    {
        cameras[0].gameObject.SetActive(true);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(false);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(false);
    }
    
}
