using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StandardStarAbility : MonoBehaviour
{
    public TextMeshProUGUI HeaderTMP;
    public Transform StarParent;
    public GameObject StarPrefab;
    public GameObject EmptyStarPrefab;

    public void Initialize(bool currentAbility, int numStars)
    {
        HeaderTMP.text = (currentAbility ? "Current " : "Potential ") + "Ability";
        for (int i = 0; i < 5; i++)
        {
            GameObject star = Instantiate(i < numStars ? StarPrefab : EmptyStarPrefab);
            star.transform.SetParent(StarParent, false);
        }
    }
}
