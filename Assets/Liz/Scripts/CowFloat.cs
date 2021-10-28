using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CowState
{
    Graze,
    Run,
    Fly,
    Captured,
}

public class CowFloat : MonoBehaviour
{
    public Transform target;
    public float speed;

    public Vector3[] positions;
    
    private int index;

    public CowState currState = CowState.Graze;

    Rigidbody cowRb;

    // Start is called before the first frame update
    void Start()
    {
        cowRb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (currState)
        {
            case (CowState.Graze):
                Graze();
                break;
            case (CowState.Run):
                Run();
                break;
            case (CowState.Fly):
                Fly();
                break;
        }
                
    }


    public void HitByRay()
    {
        Debug.Log("moo");
        currState = CowState.Fly;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            Debug.Log("hit");
        }

    }

    void Graze()
    {
       // if (transform.position == positions[index])
      /*  {
            if (index == positions.Length - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }

        if (transform.position == positions[index])
        {
            if (index == positions.Length - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }*/
    }
    
    void Run()
    {

    }


    public void Fly()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, target.position.y, target.position.z), speed * Time.deltaTime);
    }
}
