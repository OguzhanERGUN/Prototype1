using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnspeed;
    [SerializeField] private float HorizontalInput;
    [SerializeField] private float VerticalInput;
    [SerializeField] private string InputNameHorizontal;
    [SerializeField] private string InputNameVertical;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis(InputNameHorizontal);
        VerticalInput = Input.GetAxis(InputNameVertical);


        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * HorizontalInput);
    }
}
