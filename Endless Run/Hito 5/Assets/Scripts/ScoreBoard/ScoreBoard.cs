using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;

public class ScoreBoard : MonoBehaviour
{
    private DeadMenu menu;
    private Score1 sc1;
    private Score2 sc2;
    private Score3 sc3;
    private Score4 sc4;
    private Score5 sc5;

    public static ArrayList scores = new ArrayList();
    public static String[] score;
    public static String[] finalScore = {  "0", "0", "0","0","0"};
    public static String[] stringArr= { "0", "0", "0","0","0", "0"};
    public static int[] intArr;
    public static string newScore;

    // Start is called before the first frame update
    void Start()
    {
        newScore = "" + GameHandler.puntuacion;
        finalScore = score = System.IO.File.ReadAllLines(@"E:\Escritorio\uni\core\hackaton_2\Hito-Semana-5\Endless Run\Hito 5\Assets\Scripts\TextOfScore\Scores.txt");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void organize()
    {
        scores.Clear();
        scores.AddRange(score);
        scores.Add(newScore);

        scores.CopyTo(stringArr);

        intArr = Array.ConvertAll(stringArr, delegate (string s) { return int.Parse(s); });
        Array.Sort(intArr);
        Array.Reverse(intArr);
        stringArr = intArr.Select(x => x.ToString()).ToArray();

        scores.Clear();
        scores.AddRange(stringArr);
        scores.RemoveAt(5);
        scores.CopyTo(finalScore);
        System.IO.File.WriteAllLines(@"Assets\Scripts\TextOfScore\Scores.txt", finalScore);
    }
}
