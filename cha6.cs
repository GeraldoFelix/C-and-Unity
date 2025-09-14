using UnityEngine;

public class cha6 : MonoBehaviour
{
    public int num1 = 0;

    public int num2 = 0;

    public int num3 = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void maiorquemil(int x, int y, int z)
    {
        int total = (x + y) * z;
        if (total > 1000)
        {
            Debug.Log("foda");
        }
        else
        {
            Debug.Log("legal");
        }
    }


}
