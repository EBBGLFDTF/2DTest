using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour {

    public Vector2 position;
    public Transform spriteTransform;
    public Vector2 positionVelocity;

	// Use this for initialization
	void Start () {
        position.x = 0;
        position.y = 0;
	}
	
	// Update is called once per frame
	void Update () {
        spriteTransform.position = position;

        positionVelocity.x = positionVelocity.x + Input.GetAxisRaw("Horizontal");
        positionVelocity.y = positionVelocity.y + Input.GetAxisRaw("Vertical");

        position.x = position.x + ((positionVelocity.x * Time.deltaTime) / 10);
        position.y = position.y + ((positionVelocity.y * Time.deltaTime) / 10);

        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            if (positionVelocity.x < 0)
            {
                positionVelocity.x = positionVelocity.x + 1;
            }
            if (positionVelocity.x > 0)
            {
                positionVelocity.x = positionVelocity.x - 1;
            }
        }

        if (Input.GetAxisRaw("Veritcal") == 0)
        {
            if (positionVelocity.y < 0)
            {
                positionVelocity.y = positionVelocity.y + 1;
            }
            if (positionVelocity.y > 0)
            {
                positionVelocity.y = positionVelocity.y - 1;
            }
        }
    }
}
