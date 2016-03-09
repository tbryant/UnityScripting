using UnityEngine;
using System.Collections;

public class FactoryCamera : MonoBehaviour {

    public GameObject cameraObject; //The camera that is in front of the ship.
    public float distanceThreshold = 5.0f;

    void Start ()
    {

        cameraObject.SetActive(false);

    }
    void Update () { 

        // I would like to have in IF-statement where the ("Raycast")
        // player is a certain distance from that TAG, then following this if statement.

        float distanceToPlayer = (GameObject.FindGameObjectWithTag("Player").transform.position - transform.position).magnitude;

        if (distanceToPlayer < distanceThreshold) {
            cameraObject.SetActive (true);
        }
        else{
            cameraObject.SetActive (false);
        }

    } 

}
