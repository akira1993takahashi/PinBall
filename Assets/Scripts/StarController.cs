using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{
    // Start is called before the first frame update

    //‰ñ“]‘¬“x
    private float rotspeed = 0.5f;

    void Start()
    {
        //‰ñ“]‚ğŠJn‚·‚éŠp“x‚ğİ’è
        this.transform.Rotate(0, Random.Range(0, 360), 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        //‰ñ“]
        this.transform.Rotate(0, this.rotspeed, 0);
    }
}
