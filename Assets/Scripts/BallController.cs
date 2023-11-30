using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    bool mouse;
    bool changeball;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mouse = true;
            print("true");
        }
        change();
        ball();
    }

   
    void ball ()
    {
       if (changeball == false && mouse == true)
        {
            _rb.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Impulse);
           
        }
       else if (changeball == true && mouse == true)
        {
            _rb.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);
           
        }
        

    }

    void change()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (mouse == true && changeball == false)
            {
                changeball = true;
                print("true 1");
            }
            else if (mouse == true && changeball == true)
            {
                changeball = false;
                print("true 2");
            }
        }

         void destroy()
        {
            
        }
    }
        

}
