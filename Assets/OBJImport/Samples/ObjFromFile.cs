using Dummiesman;
using System;
using System.IO;
using UnityEngine;

public class ObjFromFile : MonoBehaviour
{
    public String path = @"C:\Users\vive_1\Desktop\zf\mesh";
    public String[] files;
    public String[] mtls;
    public OBJLoader loadedObj = new OBJLoader();
    public OBJLoader loadedObj1 = new OBJLoader();
    public int i=0;
    public GameObject temp;
    public GameObject temp1;
    void Start()
    {

        temp = new GameObject();
        files = Directory.GetFiles(path, "*.obj");
        mtls = Directory.GetFiles(path, "*.mtl");

    }

   
    void Update()
    {

        if (i < files.Length && i > 0)
        {
            Destroy(temp);
            Destroy(loadedObj.Load(files[i-1], mtls[i-1]));
            temp = loadedObj.Load(files[i], mtls[i]);
            temp.transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);
        }
        else if (i == 0)
        {
            temp = loadedObj.Load(files[i], mtls[i]);
            temp.transform.localScale = new Vector3(-0.1f, 0.1f, 0.1f);
        }
        else if (i == files.Length)
        {
            i = 0;
        }
        i++;
    }


}
