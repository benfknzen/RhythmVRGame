using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRenderer : MonoBehaviour
{
    public GameObject ArrowA;
    public GameObject ArrowS;
    public GameObject ArrowD;
    public GameObject ArrowF;
    // Start is called before the first frame update
    void Start()
    {
        RandomizeArrows();

    }
    void RandomizeArrows()
    {
        float Randomize = Random.Range(0.0f, 1.0f);
        if (Randomize > .75)
        {
            ArrowS.SetActive(false);
            ArrowD.SetActive(false);
            ArrowF.SetActive(false);
        }
        else if (Randomize > .5)
        {
            ArrowA.SetActive(false);
            ArrowD.SetActive(false);
            ArrowF.SetActive(false);
        }
        else if (Randomize > .25)
        {
            ArrowA.SetActive(false);
            ArrowD.SetActive(false);
            ArrowF.SetActive(false);
        }
        else
        {
            ArrowA.SetActive(false);
            ArrowD.SetActive(false);
            ArrowS.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
