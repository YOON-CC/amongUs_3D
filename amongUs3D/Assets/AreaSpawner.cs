using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] areaBox; //프레임 배열
    [SerializeField]
    private int AreaCount = 3; //처음에 생성이 되는 맵의 개수이다.
    [SerializeField]
    private float zDistance = 20; //맵의 길이
    private int areaIndex = 0;

    [SerializeField]
    private Transform playerTransform;


    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i< AreaCount; ++i)// 구역을 생성한다.
        {
            if(i==0) // 첫번째 구역은 제일 처음 0번 구역으로 설정한다.
            {
                SpawnArea(false);
            }
            else
            {
                SpawnArea(); //0번을 벗어나 생성이 된다.
            }
        }
    }
    //즉, 처음에는 0으로 시작하여 false로 입력이되어 첫번째 구역이 생성이 되며 이후 SpawnArea의 true에 해당하는 조건문에서 랜덤으로 맵이 호출이 된다.
    public void SpawnArea(bool isRandom = true) // 기본값이 true이기 때문에 값이 없다면 true로 설정이 된다.
    {
        GameObject map = null;

        if(isRandom == false)
        {
            map = Instantiate(areaBox[0]); // 제일 처음 구역 생성 => instantiate로 오브젝트를 생성한다.
        }
        else
        {
            int index = Random.Range(0, areaBox.Length);
            map = Instantiate(areaBox[index]);
        }

        //맵이 현재 z축상에서 맵의 index값과 현재 맵의 위치를 곱한 값에 존재
        map.transform.position = new Vector3(0, 0, areaIndex * zDistance);

        //Area스크립트 setup 함수 호출
        map.GetComponent<Area>().Setup(this, playerTransform);

        areaIndex++; // 이후 다음 생성될 구역을 1 떨어져서 생성시킨다. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
