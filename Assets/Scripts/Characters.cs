using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{

    public enum Character
    {
        easy,
        medium,
        hard
    };

    public enum Gender
    {
        male,
        female
    };

    public Character characterObj;
    public Gender genderType;

    public int suspicionMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }

    public void Generate()
    {
        switch(Random.Range(0, 2))
        {
            case 0:
                characterObj = Character.easy;
                suspicionMultiplier = 1;
                break;
            case 1:
                characterObj = Character.medium;
                suspicionMultiplier = 2;
                break;
            case 2:
                characterObj = Character.hard;
                suspicionMultiplier = 3;
                break;
        }

        switch(Random.Range(0, 1))
        {
            case 0:
                genderType = Gender.male;
                break;
            case 1:
                genderType = Gender.female;
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
