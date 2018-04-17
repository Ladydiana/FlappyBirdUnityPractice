using UnityEngine;
using UnityEngine.UI;

public class ActiveCube : MonoBehaviour {

    // un mod de referentiere a unui alt GameObject din scena
    // public GameObject userObject;

    public Text myText;

    public int score = 0;

    // un alt mod de referentiere a unui alt GameObject din scena direct prin intermediul unei componente
    public Rigidbody userObject;

    // Use this for initialization
    void Start()
    {
        //Debug.Log("Hello Unity");


        userObject.AddForce(new Vector3(100, 0, 200), ForceMode.Force);

        myText.text = "Score: 0";

    }

}
