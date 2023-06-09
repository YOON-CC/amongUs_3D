using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target; // 어몽어스 
    private float zDistance;

    // Start is called before the first frame update
    void Start()
    {
        if (target != null)
        {
            zDistance = target.position.z - transform.position.z; // 카메라 와 어몽어스의 거리
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) // 캐릭터가 없을때는 실행x
        {
            return;
        }

        //카메라의 위치정보를 갱신한다.
        Vector3 p = transform.position;
        p.z = target.position.z - zDistance;
        transform.position = p;
    }
}
