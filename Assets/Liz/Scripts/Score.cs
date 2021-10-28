using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText = null;

    int score = 0;

    public GameObject player;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cow")
        {
            score++;

        }
    }
}
