using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.WasapiAudio.Scripts.Unity;

public class Visualizer : MonoBehaviour
{
    public GameObject[] equalizer;
    public int intensity;
    public int colorIntensity;

    WasapiAudioSource wasapiAudioSource;
    Color defaultEqualizerColor;
    void Awake()
    {
        wasapiAudioSource = this.GetComponent<WasapiAudioSource>();
        defaultEqualizerColor = equalizer[0].GetComponent<Renderer>().material.GetColor("_Color");
    }

    void Update()
    {
        int idx = 10;
        foreach(GameObject gameObject in equalizer)
        {
            gameObject.transform.localScale = new Vector3 (9.75f, wasapiAudioSource.GetSpectrumData()[idx] * intensity, 2f);
            
            Material currentMaterial = gameObject.GetComponent<Renderer>().material;
            currentMaterial.SetColor("_Color", Color.Lerp(defaultEqualizerColor, Color.magenta, wasapiAudioSource.GetSpectrumData()[idx] * colorIntensity));

            idx = idx + 4;
        }
    }
}
