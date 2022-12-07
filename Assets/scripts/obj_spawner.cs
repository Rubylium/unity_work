using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_spawner : MonoBehaviour
{
    private int count;
    private int maxObject;

    public void ResetObjSpawner()
    {
        this.count = 0;
        this.maxObject = 3;
    }

    private void CreateNewObject()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.count < this.maxObject)
        {
            this.CreateNewObject();
        }
    }
}
