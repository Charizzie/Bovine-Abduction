using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abduction : MonoBehaviour
{
    public GameObject player;
    public LayerMask mask;

    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hit;
            Ray beam = new Ray(transform.position, Vector3.down);
            
            Debug.DrawRay(player.transform.position, -transform.up * 20, Color.green, 2f);

            //Instantiate(particle, player.transform.position, Quaternion.identity);
                       
            //spherecast 
            if (Physics.SphereCast(beam, 5, out hit, 100, mask))
            {
                hit.transform.SendMessage("HitByRay");
                //hit.collider.gameObject.GetComponent<CowFloat>().Fly();
                Debug.Log(hit.collider.gameObject.name);
            }
        }

        //Collider[] = Physics.OverlapSphere(player.transform.position, 5);
        

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(player.transform.position, 5);
    }
}
