using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] float offset = 6.0f;

    private void Update()
    {
        MoveDeathPlane();
    }

    private void MoveDeathPlane()
    {
        transform.Translate(1 * offset, 0, 0);
        //Vector3 deathPlaneVector = transform.position;
        //deathPlaneVector = player.transform.position + Vector3.down*offset;
        //transform.position = deathPlaneVector;
    }

    private void OnTriggerEnter() 
    {
        SceneManager.LoadScene(0);
    }
}
