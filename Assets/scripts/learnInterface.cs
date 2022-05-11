using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnInterface : MonoBehaviour
{
    interface IFile
    {
        void ReadFile();
        void WriteFile(string text);
    }
    
    interface IBinaryFile
    {
        void OpenBinaryFile();
        void ReadFile();
    }
    
    class FileInfo : IFile, IBinaryFile
    {
        public void ReadFile()
        {
            Debug.Log("Reading File");
        }

        public void WriteFile(string text)
        {
            Debug.Log("Writing to file");
        }
        
        void IFile.ReadFile()
        {
            Debug.Log("Reading File");
        }

        void IFile.WriteFile(string text)
        {
            Debug.Log("Writing to file");
        }
        
        public void Search(string text)
        {
            Debug.Log("Searching in file");
        }
        
        void IBinaryFile.OpenBinaryFile()
        {
            Debug.Log("Opening Binary File");
        }

        void IBinaryFile.ReadFile()
        {
            Debug.Log("Reading Binary File");
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        IFile file1 = new FileInfo();
        IBinaryFile file2 = new FileInfo();
        FileInfo file3 = new FileInfo();
		
        file1.ReadFile(); 
        file1.WriteFile("content"); 

        file2.ReadFile(); 
        file2.OpenBinaryFile();
        file2.ReadFile();
        file3.Search("text to be searched");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
