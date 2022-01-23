using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToEndPoint : MonoBehaviour
{

    [SerializeField] GameObject endPoint;
    [SerializeField] GameObject platformPrefab;
    [SerializeField] GameObject player;
    [SerializeField] float distLeftTarget = 2.0f;
    [SerializeField] float offset = 2.0f;

    Vector3 endPointXfmPos;

    bool reachedEndPoint;
    // Start is called before the first frame update
    void Start()
    {
        reachedEndPoint = false;
        endPointXfmPos = endPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MakeNewPlatform();
    }

    private void MakeNewPlatform()
    {
        float playerPosX = player.transform.position.x;
        float endPointPosX = endPointXfmPos.x;
        float distLeftToEnd = endPointPosX - playerPosX;
        //print("distLeft: " + distLeftToEnd);
        if (reachedEndPoint || distLeftToEnd < distLeftTarget-0.5f) { return; }
        if(distLeftToEnd < distLeftTarget)
        {
            reachedEndPoint = true;
            print("close to the end, make another platform");
            Vector3 offsetVector = endPointXfmPos + Vector3.right*offset;
            Instantiate(platformPrefab, offsetVector, Quaternion.identity);
        }
    }
}
