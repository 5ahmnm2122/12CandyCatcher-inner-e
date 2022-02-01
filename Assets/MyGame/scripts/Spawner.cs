using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{ 
    [SerializeField] GameObject candy;
    [SerializeField] GameObject canvas;


    void Start()
    {
        StartCoroutine(SpawnTarget());
    }

    IEnumerator SpawnTarget()
    {
        int positionX = Random.Range(-960 / 2, 960 / 2);
        int positionY = Random.Range(700 / 2, 600 / 2);
        GameObject targetInstance = Instantiate(candy, canvas.transform);
        targetInstance.GetComponent<RectTransform>().localPosition = new Vector2(positionX, positionY);
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnTarget());
    }
}
