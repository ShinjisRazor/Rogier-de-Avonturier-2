using UnityEngine;

public class TotumScript : MonoBehaviour
{
    public Raycast raycastscript;
    public string currenttotem;
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
        if (currenttotem != null)
        {
            GameObject totemObject = GameObject.Find(currenttotem);

            if (totemObject != null)
            {
                totemObject.transform.Rotate(Vector3.up * 90f);
            }
        }
    }
}

