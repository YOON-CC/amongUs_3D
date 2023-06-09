using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //[SerializeField]
    public GameController gameController;

    private void OnTriggerEnter(Collider other) // 테그를 사용하여 충돌을 감지한다.
    {
        if(other.tag.Equals("Obstacle"))
        {
            gameController.GameOver();
        }
        else if (other.tag.Equals("볼트"))
        {
            gameController.IncreaseItemCount();
        }
        else if (other.tag.Equals("out"))
        {
            gameController.GameOver();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
