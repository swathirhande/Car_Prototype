using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //obstracles or cars are gameObjects and if we check in MainCamera and Follow Player(Script) it has Player
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset the camera behind the player by adding the players position
        transform.position = player.transform.position + offset ;
    }
}
