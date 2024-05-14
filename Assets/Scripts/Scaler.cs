using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;


public class Scaler : MonoBehaviour
{
    [Header("Scale Settings")]
    [SerializeField] private Vector3 minScale = new Vector3(1f, 1f, 1f);   // Minimum scale
    [SerializeField] private Vector3 maxScale = new Vector3(10f, 10f, 10f);         // Maximum scale
    [SerializeField] public float duration = 10f;// Duration of scaling animation
    [SerializeField] private GameObject target;
    [SerializeField] [Range(0f, 1f)] private float scaleFactor;
    public bool isBig = true;

    [Header("Fade Settings")]
    [SerializeField] public bool fade = true;
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private Image fadeImage;
    [SerializeField] public float fadeDuration = 2f;
    [SerializeField] [Range(0f, 1f)] private float fadeFactor = 0f;
    private void Update()
    {
        Scale();
        Fade();
    }

    public Vector3 Interpolate(Vector3 from, Vector3 to, float t)
    {
        t = Mathf.Clamp01(t);
        
        float newX = Mathf.Lerp(from.x, to.x, t);
        float newY = Mathf.Lerp(from.y, to.y, t);
        float newZ = Mathf.Lerp(from.z, to.z, t);
        
        return new Vector3(newX, newY, newZ);
    }

    private void Scale()
    {
        if (isBig)
        {
            scaleFactor += Time.deltaTime / duration;
        }
        else
        {
            scaleFactor -= Time.deltaTime / duration;
        }
        scaleFactor = Mathf.Clamp(scaleFactor, 0f, 1f);
        
        Vector3 targetScale = Interpolate(minScale, maxScale, scaleFactor);
        Vector3 startScale = transform.localScale;

        float time = 0f;
        while (time < duration)
        {
            target.transform.localScale = Vector3.Lerp(startScale, targetScale, time / duration);
            time += Time.deltaTime;
        }
        
        target.transform.localScale = targetScale;
    }

    public void Fade()
    {
        if (fade)
        {
            fadeFactor += Time.deltaTime / fadeDuration;
        }
        else
        {
            fadeFactor -= Time.deltaTime / fadeDuration;
        }
        
        float targetfade = Mathf.Lerp(0f, 1f, fadeFactor);
        float startFade = 0f;

        float time = 0f;
        while (time < duration)
        {
            Color c = fadeColor;
            c.a = Mathf.Lerp(startFade, targetfade, time/duration);
            fadeImage.color = c;
            time += Time.deltaTime;
        }
        fadeFactor = Mathf.Clamp01(fadeFactor);
    }
}
