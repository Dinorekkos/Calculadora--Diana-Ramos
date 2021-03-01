using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dado : MonoBehaviour
{
   public  int [] myArraynum = new int [6];
   public int result1, result2, result3;
   [SerializeField] private Text resultTxt;



public void GenerateRandom()
{
 result1 = Random.Range(0,myArraynum.Length);
 result2 = Random.Range(0,myArraynum.Length);
 result2 = Random.Range(0,myArraynum.Length);

 
 Debug.Log("Dice1 "+ result1);
 
 Debug.Log("Dice2 "+ result2);
 
 Debug.Log("Dice3 "+ result3);

 SetTextRandom();
}


  public void SetTextRandom()
  {

     if (result1 == result2 && result1 == result3 && result2 == result3)
     resultTxt.text = "Ganaste";

  }

private void Awake()
{
   resultTxt = GetComponent<Text>();
}

}
