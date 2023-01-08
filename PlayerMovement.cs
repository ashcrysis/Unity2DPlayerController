using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	Animator anim;

	public float speed;

private void Start()
{
		anim = GetComponent<Animator>();
}	

private void Update()
{

	Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
	transform.position = transform.position + playerInput.normalized * speed * Time.deltaTime;


}

}
