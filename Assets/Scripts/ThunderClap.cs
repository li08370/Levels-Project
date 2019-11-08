using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderClap : MonoBehaviour
{
    private bool canFlicker = true;
    Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        light.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Flicker()
    {
        if (canFlicker)
        {
            canFlicker = false;
            light.enabled = true;
            yield return new WaitForSeconds(10);
            light.enabled = false;
            yield return new WaitForSeconds(10);
            canFlicker = true;
        }
        
    }
}
