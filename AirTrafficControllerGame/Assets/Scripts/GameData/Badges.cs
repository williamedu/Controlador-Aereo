using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public  class Badges : MonoBehaviour
{
    
    public  bool Obadge1;
    
    public  bool Obadge2;
   
    public bool Obadge3;
    
    public bool Obadge4;
    
    public bool Obadge5;
    
    public bool Obadge6;
   
    public bool Obadge7;

    public bool Obadge8;
 
    public bool Obadge9;

    public bool Obadge10;
   
    public bool Obadge11;
   
    public bool Obadge12;
   
    public bool Obadge13;
    
    public bool Obadge14;
   
    public bool Obadge15;
    
    public bool Obadge16;
    
    public bool Obadge17;
   
    public bool Obadge18;
   
    public bool Obadge19;
    
    public bool Obadge20;
   
    public bool Obadge21;
    
    public bool Obadge22;
    
    public bool Obadge23;
   
    public bool Obadge24;
 
    public bool Obadge25;
    
    public bool Obadge26;
  
    public bool Obadge27;
    
    public bool Obadge28;
    
    public bool Obadge29;
   
    public bool Obadge30;
    
    public bool Obadge31;
  
    public bool Obadge32;
    
    public bool Obadge33;
   
    public bool Obadge34;
    
    public bool Obadge35;

    

    

   
    public void SaveBadges()
    {
        DataEncriptation.saveBadges(this);
    }

    public void LoadBadges()
    {
        DataToSave data = DataEncriptation.loadBadges();

        Obadge1 = data.badge1;
        Obadge2 = data.badge2;
        Obadge3 = data.badge3;
        Obadge4 = data.badge4;
        Obadge5 = data.badge5;
        Obadge6 = data.badge6;
        Obadge7 = data.badge7;
        Obadge8 = data.badge8;
        Obadge9 = data.badge9;
        Obadge10 = data.badge10;
        Obadge11 = data.badge11;
        Obadge12 = data.badge12;
        Obadge13 = data.badge13;
        Obadge14 = data.badge14;
        Obadge15 = data.badge15;
        Obadge16 = data.badge16;
        Obadge17 = data.badge17;
        Obadge18 = data.badge18;
        Obadge19 = data.badge19;
        Obadge20 = data.badge20;
        Obadge21=  data.badge21;
        Obadge22 = data.badge22;
        Obadge23 = data.badge23;
        Obadge24 = data.badge24;
        Obadge25 = data.badge25;
        Obadge26 = data.badge26;
        Obadge27 = data.badge27;
        Obadge28 = data.badge28;
        Obadge29 = data.badge29;
        Obadge30 = data.badge30;
        Obadge31 = data.badge31;
        Obadge32 = data.badge32;
        Obadge33 = data.badge33;
        Obadge34 = data.badge34;
        Obadge35 = data.badge35;
    }

    public void activateTrofy()
    {
        Obadge1 = true;
    }
}
