using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCamera : MonoBehaviour
{

    public CinemachineVirtualCamera[] cameras;

    public float blendTime = 0.5f;
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
        
        StartCoroutine(BlendCamera(cameras[3]));
    }

    public void Minijuegos()
    {
        cameras[0].gameObject.SetActive(false);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(true);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(false);

        StartCoroutine(BlendCamera(cameras[2]));
    }

    public void Gacha()
    {
        cameras[0].gameObject.SetActive(false);
        cameras[1].gameObject.SetActive(true);
        cameras[2].gameObject.SetActive(false);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(false);

        StartCoroutine(BlendCamera(cameras[1]));
    }

    public void Clothes()
    {
        cameras[0].gameObject.SetActive(false);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(false);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(true);

        StartCoroutine(BlendCamera(cameras[4]));
    }

    public void Inicio()
    {
        cameras[0].gameObject.SetActive(true);
        cameras[1].gameObject.SetActive(false);
        cameras[2].gameObject.SetActive(false);
        cameras[3].gameObject.SetActive(false);
        cameras[4].gameObject.SetActive(false);

        StartCoroutine(BlendCamera(cameras[0]));
    }

    private IEnumerator BlendCamera(CinemachineVirtualCamera targetCamera)
    {
        CinemachineBrain brain = FindObjectOfType<CinemachineBrain>();

        if (brain != null)
        {
            CinemachineVirtualCamera currentCamera = brain.ActiveVirtualCamera as CinemachineVirtualCamera;

            if (currentCamera != null && currentCamera != targetCamera)
            {
                currentCamera.Priority = 0;
                targetCamera.Priority = 1;

                float elapsedTime = 0;
                float currentBlendTime = blendTime;

                while (elapsedTime < currentBlendTime)
                {
                    elapsedTime += Time.deltaTime;
                    float t = Mathf.Clamp01(elapsedTime / currentBlendTime);

                    brain.m_DefaultBlend.m_Time = t;

                    yield return null;
                }

                currentCamera.gameObject.SetActive(false);
            }
        }

        yield return null;
    }

}
