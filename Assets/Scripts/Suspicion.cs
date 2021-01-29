using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suspicion : MonoBehaviour
{
    public int suspicionLvl = 0;
    public int suspicionMultiplier;

    public int getSuspicion()
    {
        return suspicionLvl;
    }

    public void setSuspicion(int newSuspicion)
    {
        suspicionLvl = newSuspicion;
    }

    public void addSuspicion()
    {
        
    }

    public void removeSuspicion()
    {
        
    }

    public void checkSuspicion()
    {
        getSuspicion();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
