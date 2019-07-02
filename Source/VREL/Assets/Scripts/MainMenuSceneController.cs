using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSceneController : MonoBehaviour
{
    public AudioClip CardSound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayCardSound() {
        audioSource.PlayOneShot(CardSound);
    }
}
