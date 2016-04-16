using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class GameLoop : MonoBehaviour {

	// Use this for initialization
    float fadeAlpha;

    Choice choice;

    public GameObject playBtn;
    public GameObject endBtn;
    public GameObject arrow;

	void Start () 
    {
        choice = Choice.Play;
	   // gameObject.
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetAxis("HorizontalLeft") < -0.5f)
        {
            choice = Choice.Play;
            Debug.Log("Play");
        }
        else if (Input.GetAxis("HorizontalLeft") > 0.5f)
        {
            

            choice = Choice.End;
            Debug.Log("End");
        }

        if (choice == Choice.Play)
        {
            arrow.transform.position = new Vector3(playBtn.transform.position.x, transform.position.y, transform.position.z);
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
                SceneManager.LoadScene("Cooking");

           
        }
        else if (choice == Choice.End)
        {
            arrow.transform.position = new Vector3(endBtn.transform.position.x, transform.position.y, transform.position.z);
            if (Input.GetKeyDown(KeyCode.Joystick1Button0))
                Application.Quit();
        }
	}
}