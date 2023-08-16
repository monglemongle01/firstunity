using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FileStream stream = new FileStream("Assets/Unity Terrain/data.txt", FileMode.Create);

        StreamWriter streamWrite = new StreamWriter(stream);
        streamWrite.WriteLine("unity Engine!");
        streamWrite.Close();

        stream = new FileStream("Assets/Unity Terrain/data.txt", FileMode.Open);

        StreamReader streamReader = new StreamReader(stream);
        Debug.Log(streamReader.ReadLine());
        streamReader.Close();
    }

    // Update is called once per frame
}
