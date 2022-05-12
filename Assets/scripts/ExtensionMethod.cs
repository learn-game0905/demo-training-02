using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtensionMethods;

public class ExtensionMethod : MonoBehaviour
{
    public static class IntExtensions
    {
        public static bool IsGreaterThan(int i, int value)
        {
            return i > value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        int i = 10;

        bool result = i.IsGreaterThan(100);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
