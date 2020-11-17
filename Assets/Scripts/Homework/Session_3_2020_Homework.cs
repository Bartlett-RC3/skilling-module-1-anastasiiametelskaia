using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Session_3_2020_Homework : MonoBehaviour
{

    public GameObject cube;
    public int numberOfCubes = 5;
    public float spacing = 2.0f;
    private List<GameObject> cubeCopies = new List<GameObject>();
    private int frameCount;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            Vector3 cubeCopyPosition = new Vector3(i * spacing, 1, 1);
            Quaternion cubeCopyRotation = Quaternion.identity;
            GameObject cubeCopy =  Instantiate(cube, cubeCopyPosition, cubeCopyRotation);
            Color cubeCopyColor = new Color(Random.Range(0.0f, 1.00f), Random.Range(0.0f, 1.00f), Random.Range(0.0f, 1.00f));
            var mr = cubeCopy.GetComponent<MeshRenderer>(); 
            if (mr != null)
              mr.material.color = cubeCopyColor;
             
            cubeCopies.Add(cubeCopy);
        }
       
 
    }

    // Update is called once per frame
    void Update()
    {
      
        
        for (int i = 0; i < cubeCopies.Count; i++)
        {
            GameObject cubeCopy = cubeCopies[i];
            Color cubeCopyColor = new Color(Random.Range(0.0f, 1.00f), Random.Range(0.0f, 1.00f), Random.Range(0.0f, 1.00f));
            cubeCopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;

        }


        Debug.Log("Frames since game started: " + frameCount);
        frameCount++;

        Debug.Log("Unity counted frames: " + Time.frameCount);

        Debug.Log("Unity draws a frame in : " + Time.deltaTime + "seconds");


        foreach (GameObject cubeCopy in cubeCopies)
        {
            Vector3 moveCopy = new Vector3(0, Random.Range(-1.5f, 1.5f), 0);
            cubeCopy.transform.Translate(moveCopy * Time.deltaTime);

            Vector3 rotateCopy = new Vector3(0, Random.Range(-90.0f, 90.0f), 0);
            cubeCopy.transform.Rotate(rotateCopy);

            float scaleAmount = Random.Range(0.5f, 2.0f);
            Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            cubeCopy.transform.localScale = scaleCopy;
        }


        if (Input.GetKey(KeyCode.W))
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                float scaleAmount =  2.0f;
                Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
                cubeCopy.transform.localScale = scaleCopy;
            }
        }

        if (Input.GetMouseButton(0))
        {
            foreach (GameObject cubeCopy in cubeCopies)
            {
                Color redColor = new Color(1, 0, 0);
                cubeCopy.GetComponent<MeshRenderer>().material.color = redColor;
            }
        }
    }


    }
