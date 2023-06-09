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
        this.areaSpawner = areaSpawner; // AreaSpawner스크립트를 불러온다.
        this.playerTransform = playerTransform;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z - transform.position.z >= destroyDistance) // 어몽어스의 z좌표와 맵의 z좌표의 차이가 destroyDistance값 15보다 작아지면 맵이 생성 및 파괴 
        {
            areaSpawner.SpawnArea(); // 새로운 맵 리스폰

            Destroy(gameObject); //맵 파괴
        }
    }
}
