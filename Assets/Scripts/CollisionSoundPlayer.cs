using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSoundPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip se;
    AudioSource audiosource1;
    void Start()
    {
        audiosource1 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OncollisionEnter(Collision col)
    {
        audiosource1.PlayOneShot(se);
    }
}