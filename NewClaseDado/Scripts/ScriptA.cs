using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour
{
   public string name;

   public void Function1(string name)
   {
     Debug.Log (Function2(name));
   }


public string Function2 (string name)
{
    return name + "Ha llamado a mi Funcion1, yo soy ScriptA" + this.name;
}

}
