using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject alvo;
    
    public float speed;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
       
        transform.position = Vector2.MoveTowards(transform.position, alvo.transform.position, speed * Time.deltaTime);
    
    }
}
