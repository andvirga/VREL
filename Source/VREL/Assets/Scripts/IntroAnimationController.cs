using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroAnimationController : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void IntroStart(){
        audioSource.Play();
    }

    public void IntroEnd(){
        SceneManager.LoadScene("VREL_MainMenuScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
