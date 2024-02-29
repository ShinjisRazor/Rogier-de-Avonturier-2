using UnityEngine;

public class TotumScript : MonoBehaviour
{
    public GameObject[] totumArray;
    public float rotateamount;
    public int rotateecount;
    public Raycast raycast;
    public string currenttotum;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print(rotateecount);
        currenttotum = raycast.currenttotum;
    }

    public void Totumrot()
    {
        if (totumArray.Length > 0)

        {
            GameObject.Find(currenttotum).transform.Rotate(Vector3.up * rotateamount);

            if (Mathf.Approximately(GameObject.Find(currenttotum).transform.eulerAngles.y, 90f))
            {
                rotateecount += 1;
            }
            else
            {
                if (rotateecount > 0)
                {
                    rotateecount -= 1;
                }
            }
        }
    }
}
