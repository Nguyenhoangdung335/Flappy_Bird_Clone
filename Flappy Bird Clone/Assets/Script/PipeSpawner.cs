using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float queueTime;
    private float time = 0f;
    public GameObject obstacle;
    private Vector3 originalPos;

    public float height;

    private void Start()
    {
        originalPos[0] = transform.position.x;
        originalPos[1] = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > queueTime)
        {
            Vector3 randomHeight = new Vector3(originalPos[0], Random.Range(originalPos[1] - height, originalPos[1] + height), 0);
            GameObject temp = Instantiate(obstacle, randomHeight, Quaternion.identity);
            time = 0;
            Destroy(temp, 3f);
        }
        time += Time.deltaTime;
    }
}
