using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 ThirdPerson = new Vector3(0, 4, -6);
    private Vector3 FirstPerson = new Vector3(0.034f, 2.25f, 0.45f);
    private bool CamPos = true;
    private float HorizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.V))
        {
            if (CamPos == true)
            {
                CamPos = false;
            }
            else
            {
                CamPos = true;
            }
        }
    }
    // Update is called once per frame




    void LateUpdate()
    {
            if(CamPos == true)
            {
                transform.position = player.transform.position + ThirdPerson;
            }
            else
            {
                transform.position = player.transform.position + FirstPerson;
                transform.Rotate(Vector3.up * Time.deltaTime * HorizontalInput * 15);
            }
        
       
    }
}
