using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GachaMachine : MonoBehaviour
{

    public GameObject[] characters;
    Vector3 scaleBestias;

    void Start()
    {
        foreach (GameObject character in characters) ;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 mousePosition = Input.mousePosition;
        //    mousePosition.z = Camera.main.transform.position.z;
        //    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //    if (Vector2.Distance(transform.position, worldPosition) < GetComponent<CircleCollider2D>().radius)
        //    {

        //    }
        //}

    }

    GameObject character;
    int[] gachaCounter = new int[5];
    public void ActivateGacha()
    {
        foreach (GameObject obj in characters)
        {
            obj.SetActive(false);
        }

        float maxChance = 1; // Valor máximo del dado
        float randIndex = Random.Range(0, maxChance); // Tira un dado de 0 a maxChance

        // No tocar
        float commonChance = 2.3f; // 43,47
        float uncommonChance = 1.35f; // 74.07
        float rareChance = 1.09f; // 93,74
        // No tocar

        //Común (43,4%)
        if (randIndex <= maxChance / commonChance) // Common
        {
            // Solo tocar los valores de Random.Range (Son las ids de las criaturas)
            character = characters[Random.Range(0, 2)];

            gachaCounter[0]++;
        }

        //Poco común (30,6%)
        else if (randIndex > maxChance / commonChance && randIndex <= maxChance / uncommonChance) // Uncommon - Common
        {
            character = characters[Random.Range(2, 4)];

            gachaCounter[1]++;
        }

        // Raro (17,63%)
        else if (randIndex > maxChance / uncommonChance && randIndex <= maxChance / rareChance) // Rare - Uncommon
        {
            character = characters[Random.Range(4, 6)];

            gachaCounter[2]++;
        }

        // Mítico (8,3%)
        else if (randIndex > maxChance / rareChance) // 100 - Rare
        {
            character = characters[Random.Range(6, 8)];

            gachaCounter[3]++;
        }

        // Las probabilidades anotadas son aproximaciones

        scaleBestias = new Vector3(2.5f, 2.5f, 2.5f);
        gachaCounter[4]++;
        character.SetActive(true);
        character.transform.localScale = character.transform.localScale * 1.5f;
        character.transform.position = transform.position;
        character.transform.DOMoveY(transform.position.y + 2f, 0.5f).SetEase(Ease.OutBack);
        character.transform.DOScale(scaleBestias, 0.5f).SetEase(Ease.OutBack);

        ////Chances Debug

        //print("CommonChance: " + maxChance / commonChance);
        //print("Uncommon Chance: " + (maxChance / uncommonChance - maxChance / commonChance));
        //print("Rare Chance: " + (maxChance / rareChance - maxChance / uncommonChance));
        //print("Mythical Chance: " + maxChance / rareChance);
        //print("Dice Value: " + randIndex);

        //////Samples Debug

        //print("Common Counter: " + gachaCounter[0]);
        //print("Uncommon Counter: " + gachaCounter[1]);
        //print("Rare Counter: " + gachaCounter[2]);
        //print("Mythical Counter: " + gachaCounter[3]);
        //print("Total Counter: " + gachaCounter[4]);
    }
}

