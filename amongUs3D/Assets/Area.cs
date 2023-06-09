using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area : MonoBehaviour
{
    [SerializeField]
    private float destroyDistance = 15; 
    private AreaSpawner areaSpawner;
    private Transform playerTransform;

    public void Setup(AreaSpawner areaSpawner, Transform playerTransform)
    {
        this.areaSpawner = areaSpawner; // AreaSpawner��ũ��Ʈ�� �ҷ��´�.
        this.playerTransform = playerTransform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z - transform.position.z >= destroyDistance) // ������ z��ǥ�� ���� z��ǥ�� ���̰� destroyDistance�� 15���� �۾����� ���� ���� �� �ı� 
        {
            areaSpawner.SpawnArea(); // ���ο� �� ������

            Destroy(gameObject); //�� �ı�
        }
    }
}
