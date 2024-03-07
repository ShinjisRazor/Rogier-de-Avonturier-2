using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotumPuzzlescore : MonoBehaviour
{
    public int score;
    public bool rigtplace;
    public TotumScript totum;
    // Start is called before the first frame update
    void Start()
    {
        rigtplace = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(score);
        if (score == 3)
        {
            rigtplace = true;
        }
    }
    public void scrorecount()
    {
        score += 1;
    }
    public void Descore()
    {
        if (score > 0 && totum.rightplaced == false)
        {
            score -= 1;
        }       
    }
}
