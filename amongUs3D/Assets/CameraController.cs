using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform target; // ���� 
    private float zDistance;

    // Start is called before the first frame update
    void Start()
    {
        if (target != null)
        {
            zDistance = target.position.z - transform.position.z; // ī�޶� �� ������ �Ÿ�
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null) // ĳ���Ͱ� �������� ����x
        {
            return;
        }

        //ī�޶��� ��ġ������ �����Ѵ�.
        Vector3 p = transform.position;
        p.z = target.position.z - zDistance;
        transform.position = p;
    }
}
