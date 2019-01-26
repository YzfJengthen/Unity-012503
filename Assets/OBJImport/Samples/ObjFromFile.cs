using Dummiesman;
using System;
using System.IO;
using UnityEngine;

public class ObjFromFile : MonoBehaviour
{
    public String path = @"C:\Users\vive_1\Desktop\zf\mesh100";
    public String[] files;
    public OBJLoader loadedObj = new OBJLoader();
    public int i=0;
    public GameObject temp;
    void Start()
    {
        temp = new GameObject();
        files = Directory.GetFiles(path, "*.obj");
        temp = loadedObj.Load(files[0]);
        Destroy(temp);
        temp = loadedObj.Load(files[90]);
    }

    /***
    void Update()
    {
        
        if (i < files.Length && i > 0)
        {
            Destroy(temp);
            temp = loadedObj.Load(files[i]);
        }
        else if (i == 0)
        {
            temp = loadedObj.Load(files[i]);
        }
        else if (i == files.Length)
        {
            i = 0;
        }
        i++;
    }
    **/

}
