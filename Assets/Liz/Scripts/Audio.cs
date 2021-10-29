using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]

    public AudioClip moo;
    public AudioClip Abduction;

    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.PlayOneShot(Abduction);
        }
    }

    public void HitByRay()
    {
        source.PlayOneShot(moo);
    }

}
