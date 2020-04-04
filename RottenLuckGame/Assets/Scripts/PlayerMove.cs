using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Rigidbody2D playerBody;
    private Vector3 change;
    // Start is cal led before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //reset our change variable to zero
        change = Vector3.zero;
        //get our x and y inputs from player if they're moving
        //if we get axis raw instead the we get a more Nintendo feel

        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        //change.x = Input.GetAxis("Horizontal");
        //change.y = Input.GetAxis("Vertical");

        //if method to check if there is a change to our movement
        if (change != Vector3.zero) {
            CharacterMove();
        }

        //log our change so we know it's moving and help trace errors
       // Debug.Log(change);
    }

    void CharacterMove() {
        playerBody.MovePosition(
            transform.position + change * speed * Time.deltaTime
            );
    }

}
