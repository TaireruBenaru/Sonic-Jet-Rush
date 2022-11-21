using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool inIntro = true;
    public float t;
    public float groundSpeed;
    public static float topSpeed = 10;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inIntro)
        {
            if(t < 50)
            {
                t += Time.deltaTime;
                Debug.Log(Time.deltaTime);
            }
            else
            {
                inIntro = false;
            }
        }

        DoAnimation();
    }

    void DoAnimation()
    {
        if(inIntro)
        {
            groundSpeed = Mathf.Lerp(0, 3, t);
        }
        float duration = Mathf.Floor(Mathf.Max(0, 8-Mathf.Abs(groundSpeed)));

        animator.SetFloat("Speed", duration);

        if(groundSpeed == 0)
        {

        }
        else if(groundSpeed >= 1 && groundSpeed < 3)
        {
            animator.Play("SonicWalk");
        }
        else if(groundSpeed >= 3 && groundSpeed < 6)
        {
            animator.Play("SonicJog");
        }
        else if(groundSpeed >= 6 && groundSpeed < 10)
        {
            animator.Play("SonicSprint");
        }
        if(groundSpeed >= 10)
        {
            animator.Play("SonicFullSpeed");
        }

        //Debug.Log(animator.speed);

    }
}
