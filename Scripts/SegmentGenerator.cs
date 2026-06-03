using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegementGenerator : MonoBehaviour
{
    public GameObject[] segments;
    [SerializeField] int zPos = 50;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;

    void Update()
    {
        if(creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegementGen());
        }
    }

    IEnumerator SegementGen()
    {
        segmentNum = Random.Range(0, 3);
        Instantiate(segments[segmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(3);
        creatingSegment = false;
    }
}