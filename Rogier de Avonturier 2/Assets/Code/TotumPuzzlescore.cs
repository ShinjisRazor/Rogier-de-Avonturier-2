using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotumPuzzlescore : MonoBehaviour
{
    public int score;
    public bool rigtplace;
    public bool isTotumPlacedCorrectly1 = false;
    public bool isTotumPlacedCorrectly2 = false;
    public bool isTotumPlacedCorrectly3 = false;
    public GameObject door;
    public AudioClip soundclip;


    // Update is called once per frame
    void Update()
    {
        print(score);
        if (score == 3)
        {
            rigtplace = true;
            print("Done");
            Destroy(door.gameObject);
        }
    }

    public void scorecount(string totemName)
    {
        if (totemName == "totum" && !isTotumPlacedCorrectly1)
        {
            score += 1;
            AudioSource.PlayClipAtPoint(soundclip, transform.position);
            isTotumPlacedCorrectly1 = true;
        }
        else if (totemName == "totum (1)" && !isTotumPlacedCorrectly2)
        {
            score += 1;
            AudioSource.PlayClipAtPoint(soundclip, transform.position);
            isTotumPlacedCorrectly2 = true;
        }
        else if (totemName == "totum (2)" && !isTotumPlacedCorrectly3)
        {
            score += 1;
            AudioSource.PlayClipAtPoint(soundclip, transform.position);
            isTotumPlacedCorrectly3 = true;
        }
    }

    public void Descore(string totemName)
    {
        if (score > 0)
        {
            if (totemName == "totum" && !isTotumPlacedCorrectly1 == false)
            {
                score -= 1;
            }
            else if (totemName == "totum (1)" && !isTotumPlacedCorrectly2 == false)
            {
                score -= 1;
            }
            else if (totemName == "totum (2)" && !isTotumPlacedCorrectly3 == false)
            {
                score -= 1;
            }
        }

        ResetTotumPlacementFlags(totemName);
    }

    private void ResetTotumPlacementFlags(string totemName)
    {
        if (totemName == "totum")
            isTotumPlacedCorrectly1 = false;
        else if (totemName == "totum (1)")
            isTotumPlacedCorrectly2 = false;
        else if (totemName == "totum (2)")
            isTotumPlacedCorrectly3 = false;
    }
}