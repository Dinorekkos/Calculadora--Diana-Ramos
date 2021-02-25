using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dado : MonoBehaviour
{
   public  int [] myArraynum = new int [6];
   public int result;
   [SerializeField] private Text resultTxt;



public void GenerateRandom()
{
 result = Random.Range(0,myArraynum.Length);
 
 Debug.Log(result);

 SetTextRandom();
}


  public void SetTextRandom()
  {
     resultTxt.text = "" + result;

  }

private void Awake()
{
   resultTxt = GetComponent<Text>();

}

}
