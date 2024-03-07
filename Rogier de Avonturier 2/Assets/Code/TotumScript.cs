using Unity.VisualScripting;
using UnityEngine;

public class TotumScript : MonoBehaviour
{
    public Raycast raycastscript;
    public TotumPuzzlescore score;
    public string currenttotem;
    public float rightplace;
    public TotumPuzzlescore placed;
    public bool rightplaced;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (raycastscript != null)
        {
            currenttotem = raycastscript.currenttotum;
        }
    }

    public void Totumrot()
    {
        if (placed != null)
            {
            if (placed.rigtplace == false)
            {
                if (currenttotem != null)
                {
                    GameObject totemObject = GameObject.Find(currenttotem);

                    if (totemObject != null)
                    {
                        totemObject.transform.Rotate(Vector3.up * 90f);
                        if (Mathf.Approximately(totemObject.transform.eulerAngles.y, rightplace))
                        {
                            if (score != null)
                            {
                                rightplaced = true;
                                score.scrorecount();
                            }
                        }
                        else
                        {
                            if (rightplaced == false)
                            {
                                score.Descore();
                            }
                        }
                    }

                }
            }
        }      
    }
}

