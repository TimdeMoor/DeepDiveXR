using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] private AudioClip DispenceSound;
    [SerializeField] private AudioClip PlaceSound;


    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    
    public void playDispence()
    {
        source.PlayOneShot(DispenceSound);
    }

    public void playPlace()
    {
        source.PlayOneShot(PlaceSound);
    }
}
