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

        // �}�E�X�̈ړ��ʂ��擾
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        // X�����Ɉ��ʈړ����Ă���Ή���]
        if (Mathf.Abs(mx) > 0.01f)
        {
            //transform.position += transform.forward * mx * 0.01f;


            // ��]���̓��[���h���W��Y��
            transform.RotateAround(player.transform.position, Vector3.up, mx * 1f);

        }

        // Y�����Ɉ��ʈړ����Ă���Ώc��]
        if (Mathf.Abs(my) > 0.001f)
        {
            // ��]���̓J�������g��X��
            transform.RotateAround(player.transform.position, transform.right, my * 0.2f);
        }
    }
}
