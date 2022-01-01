using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    //Variables
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            animator.SetTrigger("highRightPunch");  //high right punch attack
        }
    }
}
