using UnityEngine;
using System.Collections;

public enum Choice
{
    Play,
    End
}
public class Arrow : MonoBehaviour {

	// Use this for initialization
    Choice choice;

    public GameObject playBtn;
    public GameObject endBtn;

	void Start () {
        choice = Choice.Play;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetAxis("VerticalLeft") < -0.5f)
        {
            choice = Choice.End;
            
        }
        else if (Input.GetAxis("VerticalLeft") > 0.5f)
        {
            choice = Choice.Play;

        }

        if(choice == Choice.Play)
        {
            transform.position = new Vector3(transform.position.x,playBtn.transform.position.y,transform.position.z);
            if(Input.GetKeyDown(KeyCode.Joystick1Button0))
                Application.LoadLevel("Cooking");
        }
        else if(choice == Choice.End)
        {
            transform.position = new Vector3(transform.position.x, endBtn.transform.position.y, transform.position.z);
            Debug.Log("Megumbe");
        }
	
	}
}
