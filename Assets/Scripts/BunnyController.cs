using UnityEngine;
using System.Collections;

public class BunnyController : MonoBehaviour {

    private Rigidbody2D myRigigBody;
    public float bunnyJumpForce = 500f;

	// Use this for initialization
	void Start () {
        myRigigBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetButtonUp("Jump"))
            {
            myRigigBody.AddForce(transform.up * bunnyJumpForce);
            }
	
	}
}
