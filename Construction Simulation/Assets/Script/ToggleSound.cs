using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace cakeslice
{
    public class ToggleSound : MonoBehaviour
    {
        public bool playNow = false;
        public bool playingNow = false;
        public bool soundFinished = false;      //if the sound file has finished playing

        AudioSource audioSource;
        // Use this for initialization
        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            if (playNow == true)
            {
                if (!audioSource.isPlaying)
                {
                    if (playingNow == false)
                    {
                        audioSource.Play();
                        playingNow = true;
                    }
                    else
                    {
                        soundFinished = true;
                    }
                }
            }
            else
            {
                if (audioSource.isPlaying)
                {
                    audioSource.Stop();
                }
                playingNow = false;
                soundFinished = false;
            }
        }
    }
}