using Unity.VisualScripting;
using UnityEngine;

public class TotemScript : MonoBehaviour
{
    public Raycast raycastScript;
    public TotumPuzzlescore score;
    public string currentTotem;
    public float rightPlace;
    public bool rightPlaced;

    // Start is called before the first frame update
    void Start()
    {
        rightPlaced = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (raycastScript != null)
        {
            currentTotem = raycastScript.currentTotem;
        }
    }

    public void TotemRot()
    {
        if (score != null && score.rigtplace == false)
        {
            if (currentTotem != null)
            {
                GameObject totemObject = GameObject.Find(currentTotem);

                if (totemObject != null)
                {
                    totemObject.transform.Rotate(Vector3.up * 90f);

                    if (Mathf.Approximately(totemObject.transform.eulerAngles.y, rightPlace))
                    {
                        if (score != null && !rightPlaced)
                        {
                            rightPlaced = true;
                            score.scorecount(currentTotem);
                        }
                    }
                    else if (rightPlaced)
                    {
                        rightPlaced = false;
                        score.Descore(currentTotem);
                    }
                }
            }
        }
    }
}


