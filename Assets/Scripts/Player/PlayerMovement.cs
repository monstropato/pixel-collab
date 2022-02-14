using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //CACHED INTERNAL REFERENCES
    internal Player player;

    internal void CustomStart()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {

    }
}