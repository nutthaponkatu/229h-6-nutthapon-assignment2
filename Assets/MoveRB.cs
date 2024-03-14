using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    [SerializeField] float walk = 2;
    [SerializeField] float run = 4;
    Vector3 movement = Vector3.zero;
    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) walk = (walk + run);
        if (Input.GetKeyUp(KeyCode.LeftShift)) walk = (walk - run);
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        movement = new Vector3(Horizontal, 0f, Vertical);
    }
    private void FixedUpdate()
    {

        rig.MovePosition(rig.position + movement * walk * Time.fixedDeltaTime);

    }
}
