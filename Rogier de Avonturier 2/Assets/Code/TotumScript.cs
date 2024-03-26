using Unity.VisualScripting;
using UnityEngine;

public class TotumScript : MonoBehaviour
{
    public Raycast raycastscript;
    public TotumPuzzlescore score;
    public string currenttotem;
    public float rightplace;
    public bool rightplaced;

    // Start is called before the first frame update
    void Start()
    {
        
        rightplaced = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (raycastscript != null)
        {
            currenttotem = raycastscript.currenttotum;
        }
        else
        {
            Debug.Log("Raycastscriptnull");
        }
    }

    public void Totumrot()
    {
        if (score.rigtplace == false)
        {
            if (score != null && score.rigtplace == false)
            {
                if (currenttotem != null)
                {
                    GameObject totemObject = GameObject.Find(currenttotem);

                    if (totemObject != null)
                    {
                        totemObject.transform.Rotate(Vector3.up * 90f);

                        if (Mathf.Approximately(totemObject.transform.eulerAngles.y, rightplace))
                        {
                            if (score != null && !rightplaced)
                            {
                                rightplaced = true;
                                score.scrorecount(currenttotem);
                            }
                        }
                        else if (rightplaced)
                        {
                            rightplaced = false;
                            score.Descore(currenttotem);
                        }                      
                    }
                }
            }
        }
    }
}


