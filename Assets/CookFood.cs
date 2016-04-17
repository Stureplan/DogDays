using UnityEngine;
using System.Collections;

public class CookFood : MonoBehaviour {

    Material mat;
    Material cop;
    bool shouldCook = false;
    Color col = Color.red;

	// Use this for initialization
	void Start ()
    {
        mat = GetComponent<Renderer>().material;
        cop.CopyPropertiesFromMaterial(mat);
        
        mat = new Material(cop);
    }

    // Update is called once per frame
    void Update ()
    {
	    if (shouldCook)
        {
            if (col.r > 0.05f)
            {
                col = Color.Lerp(Color.red, Color.black, Mathf.PingPong(Time.time, 1.0f));
                mat.SetColor("_Color", col);
            }

        }
	}

    public void SetCookable()
    {
        shouldCook = true;
    }


}
