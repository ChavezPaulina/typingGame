using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"pizza", "wordly", "strategy", "swamp", "moss", "standby", "vengance",
                                                      "battle", "scars", "soreness", "peace", "grumpiness", "happiness",
                                                      "battlestar", "gattica", "kingkong", "dinosaurs", "spreadsheets", "analytics", "investments",
                                                        "records", "highlighting", "horses", "highlighting", "brother", "mother",
                                                       "father", "sister", "cousin", "grandmother", "grandfather", "colombia", "seattle",
                                                        "waiter", "shooter", "therapy", "designer", "studio", "investigator", "detective"};
  public static string GetRandomWord ()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }
}
