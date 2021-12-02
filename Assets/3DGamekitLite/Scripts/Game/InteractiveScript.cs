using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveScript : MonoBehaviour
{
    Quaternion stateOff;
    Quaternion stateOn;
    bool activated;
    bool movement;
    // Start is called before the first frame update
    void Start()
    {
        stateOff = transform.rotation;
        stateOn = Quaternion.Euler(-transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        activated = false;
        movement = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (movement)
        {
            //Quaternion target = activated? ;

           /* transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 8);
            if (transform.rotation.eulerAngles == rotations[position])
            {
                rotation = false;
            }*/
        }
    }

    public void activate()
    {
        movement = true;
    }
}
