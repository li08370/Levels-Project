using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder_Clap : MonoBehaviour
{
    private const float VolumeScale = 0.07f;
    private bool canFlicker = true;
    new Light light;
    public AudioClip clip;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        light = GetComponent<Light>();
        light.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Flicker());
    }

    IEnumerator Flicker()
    {
        if (canFlicker)
        {
            canFlicker = false;
            audioSource.PlayOneShot(clip, VolumeScale);
            light.enabled = true;
            yield return new WaitForSeconds(Random.Range(.1f,.4f));
            light.enabled = false;
            yield return new WaitForSeconds(Random.Range(.1f,5f));
            canFlicker = true;
        }

    }
}

