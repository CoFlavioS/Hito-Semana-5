using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ScoreBoard : MonoBehaviour
{
    public static ArrayList scores = new ArrayList();
    public static string[] score;
    static String[] myArr;
    // Start is called before the first frame update
    void Start()
    {

        score = System.IO.File.ReadAllLines(@"E:\Luis\All\Otro\Proyectos\Videojuegos\Hito-Semana-5\Endless Run\Hito 5\Assets\Scripts\TextOfScore\text.txt");
        organize();
        System.IO.File.WriteAllLines(@"E:\Luis\All\Otro\Proyectos\Videojuegos\Hito-Semana-5\Endless Run\Hito 5\Assets\Scripts\TextOfScore\text.txt", myArr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void organize()
    {
        scores.AddRange(score);
        Debug.Log("marmota");
        //scores.Add(GameHandler.puntuacion);
        /*scores.Add(5);
        scores.Add(99);
        scores.Sort();
        scores.Reverse();*/
        myArr = (String[])scores.ToArray(typeof(string));
    }
}
