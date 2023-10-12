using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //Create a public refrence to the player - we will assign this using the Unity editor
    public GameObject player;
    // Start is called before the first frame update
          

    // Update is called once per frame
    void Update()
    {
        //Change our position relative to the player position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }
}
