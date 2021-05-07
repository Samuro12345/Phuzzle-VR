using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonCollision : MonoBehaviour
{
    public Animator animator;
    public UnityEvent buttonPressed;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.tag == "Sphered")
        {
            animator.SetTrigger("ButtonPress");
            Debug.Log("WE HAVE COLLIDED.");

            buttonPressed?.Invoke();

            //respawn/move the sphere back to the spawn point.
            collision.transform.position = spawnPoint.position;
        }
    }
}
