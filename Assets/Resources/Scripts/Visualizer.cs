using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.WasapiAudio.Scripts.Unity;

public class Visualizer : MonoBehaviour
{
    public GameObject[] equalizer;  // Visual Equalizer GameObject
    public int spectrumIntensity;   // Sample Spectrum Intensity
    public int colorIntensity;      // Color Intensity

    WasapiAudioSource wasapiAudioSource;
    Color defaultEqualizerColor;
    void Awake()
    {
        wasapiAudioSource = this.GetComponent<WasapiAudioSource>();
        defaultEqualizerColor = equalizer[0].GetComponent<Renderer>().material.GetColor("_Color");
    }

    void Update()
    {
        VisScaleController(equalizer, 10, 4, spectrumIntensity, colorIntensity);
    }

    ///<summary>
    /// Sampling된 Spectrum에 따라, Equalizer Scale을 조절하는 Visualization.
    ///</summary>
    ///<param name="equalizer">Visual Equalizer GameObject 배열</param>
    ///<param name="spectrumPivot">Spectrum으로부터 Sampling할 위치</param>
    ///<param name="pivotScale">Sampling할 단위 크기</param>
    ///<param name="spectrumIntensity">추출한 Spectrum Data를 증폭시키는 상수</param>
    ///<param name="colorIntensity">색상 증폭시키는 상수</param>
    void VisScaleController(GameObject[] equalizer, int spectrumPivot, int pivotScale, int spectrumIntensity, int colorIntensity)
    {
        int idx = spectrumPivot;
        foreach(GameObject gameObject in equalizer)
        {
            gameObject.transform.localScale = new Vector3 (9.75f, wasapiAudioSource.GetSpectrumData()[idx] * spectrumIntensity, 2f);
            
            Material currentMaterial = gameObject.GetComponent<Renderer>().material;
            currentMaterial.SetColor("_Color", Color.Lerp(defaultEqualizerColor, Color.magenta, wasapiAudioSource.GetSpectrumData()[idx] * colorIntensity));

            idx = idx + pivotScale;
        }
    }
}
