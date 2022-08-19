using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{
    public int length_xz = 10;
    public int layer = 1;
    
     

    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("StageCube");

        int length_y = layer;
        int length_x = length_xz;
        int length_z = length_xz;
        
        for (int i = 0; i < length_y; i++)
        {
            for (int j = 0; j < length_z; j++)
            {
                for (int k = 0; k < length_x; k++)
                {
                    Instantiate(obj, new Vector3(k, i, j), Quaternion.identity);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
