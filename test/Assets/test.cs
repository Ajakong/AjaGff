using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    GameObject player;
    Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("unitychan");

    }

    // Update is called once per frame
    void Update()
    {
        //playerPos = player.transform.position;
        //transform.position = playerPos;

        // マウスの移動量を取得
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        // X方向に一定量移動していれば横回転
        if (Mathf.Abs(mx) > 0.01f)
        {
            //transform.position += transform.forward * mx * 0.01f;


            // 回転軸はワールド座標のY軸
            transform.RotateAround(player.transform.position, Vector3.up, mx * 1f);

        }

        // Y方向に一定量移動していれば縦回転
        if (Mathf.Abs(my) > 0.001f)
        {
            // 回転軸はカメラ自身のX軸
            transform.RotateAround(player.transform.position, transform.right, my * 0.2f);
        }
    }
}
