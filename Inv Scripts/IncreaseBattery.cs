using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This class represents a battery boost pick-up in a game. It inherits from the MonoBehaviour class.

The class has the following public fields:

_addBatteryBoostToInventory: Represents the number of battery boosts to add to the player's inventory.
_batteryBoostPickUpActivated: Indicates whether the battery boost pick-up has been activated.
The class has a Start() method that sets the _batteryBoostPickUpActivated flag to false.

The class has a public method PickUpBatteryBoost() which is called when the battery boost pick-up is picked up.
It first checks if the battery boost pick-up has already been activated, and if so, it returns.
Then it retrieves the player's inventory using the "Player" tag, and adds the specified number of battery boosts to it.
After that, it destroys the battery boost pick-up game object and sets the _batteryBoostPickUpActivated flag to true.
*/

public class IncreaseBattery : MonoBehaviour
{

    public int _addBatteryBoostToInventory = 1;
    public bool _batteryBoostPickUpActivated;
    // Start is called before the first frame update
    void Start()
    {
        _batteryBoostPickUpActivated = false;
    }

   public void PickUpBatteryBoost() {
    if(_batteryBoostPickUpActivated == true) 
    return;

    Inventory temp = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    temp.BatteryBoostToInventory(_addBatteryBoostToInventory);

    Destroy(gameObject);
    _batteryBoostPickUpActivated = true;
   }
}
