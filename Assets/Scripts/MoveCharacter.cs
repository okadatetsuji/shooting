using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    float speed = 3.0f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
            animator.SetBool("Walk", true);
        }
        if(Input.GetKey (KeyCode.DownArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            animator.SetBool("Walk", true);
            transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        }
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            animator.SetBool("Walk", true);
            transform.rotation = Quaternion.Euler(0.0f, 270.0f, 0.0f);
        }
        if (Input.GetKey (KeyCode.RightArrow))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
            animator.SetBool("Walk", true);
            transform.rotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow)||
            Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("Walk", false);
        }
    }
}
