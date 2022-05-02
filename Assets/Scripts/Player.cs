using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=90;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   // 每一幀，遊戲一般每秒50~60幀，所以每秒都調用此函式50次不OK
    {
        transform.Rotate(Vector3.up*Time.deltaTime*speed);  // 對物體的y軸旋轉  /  Time.deltaTime: 一秒調用一次
    }

    public void ChangeSpeed(float NewSpeed)
    {
        this.speed = NewSpeed;
    }
}
