using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.WasapiAudio.Scripts.Unity;

public class Visualizer : MonoBehaviour
{
    public GameObject[] equalizer;
    public int intensity;

    WasapiAudioSource wasapiAudioSource;
    
    void Awake()
    {
        wasapiAudioSource = this.GetComponent<WasapiAudioSource>();
    }

    void Update()
    {
        int idx = 10;
        foreach(GameObject gameObject in equalizer)
        {
            gameObject.transform.localScale = new Vector3 (9.75f, wasapiAudioSource.GetSpectrumData()[idx] * 100 * intensity, 2f);

            idx = idx + 4;
        }
    }
}
