using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject sphere;
    public Transform spawnPoint;
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.RawButton.Y) || OVRInput.Get(OVRInput.RawButton.B))
        {
            sphere.transform.position = spawnPoint.position;

            if (ui.activeInHierarchy == true)
            {
                ui.SetActive(false);
            }
        }
    }
}
