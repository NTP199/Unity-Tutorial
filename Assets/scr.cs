using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{

    public Animation BirdFlap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                BirdFlap["Bird_flap"].enabled = true;
                BirdFlap["Bird_flap"].weight = 1f;
            }
    }
}
