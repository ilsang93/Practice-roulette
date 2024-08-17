using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    [SerializeField] private GameObject roulette;
    [SerializeField] private GameObject needle;
    [SerializeField] private Vector2 targetRotSpeed = new(5f, 5f);
    [SerializeField] private float slowdownSpeed = 1f;
    private float rotSpeed = 0f;
    private bool spinFlg = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            spinFlg = !spinFlg;
            print(spinFlg);

            if (spinFlg)
            {
                rotSpeed = Random.Range(targetRotSpeed.x, targetRotSpeed.y);
            }
        }

        if (!spinFlg)
        {
            // if (rotSpeed >= 0.1) {
            //     rotSpeed -= Time.deltaTime * slowdownSpeed;
            // } else {
            //     rotSpeed = 0;
            // }
            if (rotSpeed >= 0.1f)
            {
                rotSpeed *= 0.992f;
            }
            else
            {
                rotSpeed = 0;
            }
        }

        print(rotSpeed);
        roulette.transform.Rotate(0f, 0f, rotSpeed);
    }
}
