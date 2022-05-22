using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float forwardSpeed = 1000f, strafeSpeed = 7.5f, hoverSpeed = 5f;
    private float activeForwardSpeed, activeStrafeSpeed, activeHoverSpeed;
    private float forwardAcceleration = 2.5f, strafeAcceleration = 2f, hoverAcceleration = 2f;
    public float lookRateSpeed = 90f;
    private float rollInput, horizontalInput, verticalInput;
    public float rollSpeed = 90f, rollAcceleration = 3.5f;

    private float inputSpeed = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        keyListener();
       
        rollInput = Mathf.Lerp(rollInput, Input.GetAxisRaw("Roll"), rollAcceleration * Time.deltaTime);
        horizontalInput = Mathf.Lerp(horizontalInput, Input.GetAxisRaw("Horizontal"), 0.5f * Time.deltaTime);
        verticalInput = Mathf.Lerp(verticalInput, Input.GetAxisRaw("Vertical"), 0.5f * Time.deltaTime);

        activeForwardSpeed = Mathf.Lerp(activeForwardSpeed, inputSpeed, forwardAcceleration * Time.deltaTime);
        activeStrafeSpeed = Mathf.Lerp(activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed, strafeAcceleration * Time.deltaTime);
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, Input.GetAxisRaw("Hover") * hoverSpeed, hoverAcceleration * Time.deltaTime);

        transform.Rotate(-verticalInput * lookRateSpeed * Time.deltaTime, horizontalInput * lookRateSpeed * Time.deltaTime, rollInput * rollSpeed * Time.deltaTime, Space.Self);
        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;

        Debug.Log("time.deltatime: " + Time.deltaTime);
        Debug.Log("rollInput: " + rollInput);
    }

    void keyListener(){
         if (Input.GetKeyDown(KeyCode.Alpha1)) inputSpeed = 5f; //ir kāds labāks veids, kā šo checkot?
        else if (Input.GetKeyDown(KeyCode.Alpha2)) inputSpeed = 15f;
        else if (Input.GetKeyDown(KeyCode.Alpha3)) inputSpeed = 30f;
        else if (Input.GetKeyDown(KeyCode.Space)) inputSpeed = 0f;
    }
}