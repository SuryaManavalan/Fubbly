using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicBot : MonoBehaviour
{
    AudioSource music;

    void Awake()
    {
        music = this.gameObject.GetComponent<AudioSource>();

        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("Mute", 0) == 0)
        {
            music.mute = false;
        }else if (PlayerPrefs.GetInt("Mute", 0) == 1)
        {
            music.mute = true;
        }
    }
}