using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public static SoundEffects Instance;
    public AudioClip explosion_sound;
    public AudioClip player_shot_sound;
    //public AudioClip enem
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log("Multiplas instancias do script SoundEffects");

        }
        //instancia esse próprio script
        Instance = this;
    }
    public void MakeExplosionSound()
    {
        MakeExplosionSound(explosion_sound);
    }
    public void MakeShotSound()
    {
        MakeExplosionSound(player_shot_sound);
    }

    private void MakeExplosionSound(AudioClip original_clip)
    {
        AudioSource.PlayClipAtPoint(original_clip, transform.position);
    }
}
