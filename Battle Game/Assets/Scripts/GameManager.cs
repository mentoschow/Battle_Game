using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    public enum STATE
    {
        IDLE,
        START,
        OVER
    }

    [Header("== Actor Controller Settings ==")]
    public ActorController ac1;
    public ActorController ac2;

    [Header("== Game State ==")]
    public STATE state;

    // Start is called before the first frame update
    void Start()
    {
        state = STATE.START;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
