using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAudio : MonoBehaviour
{
    /// <summary>
    /// https://docs.unity3d.com/ScriptReference/AudioSource-isPlaying.html?_ga=2.100460699.420587413.1635820398-654658616.1634691982
    /// Helped me for below methods
    /// </summary>


    public AudioClip audioClipInit;
    public AudioClip audioClipLoop;
    AudioSource audioInit;
    AudioSource audioLoop;
    //AudioSource audioSourceLoop;
    //[SerializeField] GameObject _gameState;
    // Start is called before the first frame update
    void Start()
    {
        audioInit = GetComponent<AudioSource>();
        audioLoop = GetComponent<AudioSource>();
        StartPlay();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (GameState.Instance.IsGameOverScore())
        {
            audioSource.Pause();
        }
        


        if (!audio.isPlaying)
        {
            audioSourceLoop = GetComponent<AudioSource>();


            //GameState.Instance.InitiateGameOver();
            //audioSource.clip = otherClip;
            //audioSource.Play();
        }*/
    }
    void StartPlay() {
        audioInit.clip = audioClipInit;
        audioInit.Play();

        audioLoop.clip = audioClipLoop;
        audioLoop.loop = true;
        audioLoop.Play();


    
    }
}
