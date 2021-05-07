using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject levelOne;
    public GameObject levelTwo;
    public GameObject levelThree;
    public GameObject currentLevel;

    public GameObject wall;
    public OVRGrabbable sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sphere.isGrabbed)
        {
            //enable the wall.
            wall.SetActive(true);
        }
        else
        {
            wall.SetActive(false);
        }
    }

    public void ChangeLevel()
    {
        //if the current level is 1 then spawn level 2, if level 2, spawn level 3.
        Debug.Log("CHANGING LEVEL");

        switch (currentLevel.transform.name)
        {
            case "Tutorial":
                //enable level 1
                levelOne.SetActive(true);
                currentLevel.SetActive(false);
                currentLevel = levelOne;
                break;
            case "Level One":
                //enable level 2
                currentLevel = levelTwo;
                break;
            case "Level Two":
                //enable level 3
                currentLevel = levelThree;
                break;
        }

    }
}
