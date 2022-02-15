using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyonReset : MonoBehaviour
{
    public static bool firstrun = true;
    AudioSource m_MyAudioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        m_MyAudioSource = GetComponent<AudioSource>();

        if (firstrun == false)
        {
           
            m_MyAudioSource.enabled = false;
        }
    }

    public void SetToFalse()
    {
        firstrun = false;
    }

    
}
