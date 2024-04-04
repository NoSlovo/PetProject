using System.Collections.Generic;
using IPAD_simulator.Interfaces;
using UnityEngine;

[CreateAssetMenu(fileName = "ViueAdapter", menuName = "ViueAdapter")]
public  class Adapter : ScriptableObject
{
     private List<IAdeptiveViue> _views = new();

     

     public void ActiveViewIPad()
     {
          foreach (var viue in _views)
          {
               viue.ShowIPADViue();
          }
     }
     
     public void ActiveViewIPhone()
     {
          foreach (var viue in _views)
          {
               viue.ShowIPhoneViue();
          }
     }
}
