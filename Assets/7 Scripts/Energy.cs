using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{

    public float energy = 0.1f;
    public Image energyBar;

    private bool comidaCollider = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            comidaCollider = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            comidaCollider = false;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0) && comidaCollider)
        {
            energyBar.fillAmount += energy;
        }
    }
}
