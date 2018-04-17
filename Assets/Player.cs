using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject obstaclePrefab;
    public Transform arena;
    public Text cronometru;
    private bool gameStarted;

    private void Start()
    {
        gameStarted = false;

        for(int i=0; i<10; i++)
        {
            GameObject myObstacle = Instantiate(obstaclePrefab, arena);

            myObstacle.transform.position = new Vector3((i*50), -35 -5);
            myObstacle.transform.localScale = new Vector3(10, 20, 10);

        }

        for (int i = 0; i < 10; i++)
        {
            GameObject myObstacle = Instantiate(obstaclePrefab, arena);

            myObstacle.transform.position = new Vector3(-(i * 50), -35 - 5);
            myObstacle.transform.localScale = new Vector3(10, 20, 10);

        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update () {

        if (gameStarted)
        {
            transform.position += new Vector3(2, 0, 0);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rigidbody myRigidBody = GetComponent<Rigidbody>();
                myRigidBody.velocity = Vector3.zero;
                myRigidBody.AddForce(new Vector3(0, 150, 0));
            }
        }
    }

    IEnumerator StartGame()
    {
        cronometru.text = "Starting";

        yield return new WaitForSeconds(1);

        cronometru.text = "3";

        //asteapta 1 secunda

        yield return new WaitForSeconds(1);

        cronometru.text = "2";

        //asteapta 1 secunda
        yield return new WaitForSeconds(1);

        cronometru.text = "1";

        yield return new WaitForSeconds(1);

        cronometru.text = "";

        gameStarted = true;
    }
}
