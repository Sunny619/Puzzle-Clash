using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class Movement : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody2D rb;
    public TMP_Text fps;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 joystickLeft = playerInput.actions["Move"].ReadValue<Vector2>();
        rb.velocity = joystickLeft * 3;
        //Debug.Log(joystickLeft.x);
        fps.SetText((1.0f / Time.smoothDeltaTime).ToString());
    }
}
