using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
This class represents a battery pick-up in a game. It inherits from the MonoBehaviour class.

The class has the following public fields:

_addBatteriesToInventory: Represents the number of batteries to add to the player's inventory.
_batteryPickUpActivated: Indicates whether the battery pick-up has been activated.
The class has a Start() method that sets the _batteryPickUpActivated flag to false.

The class has a public method PickUpBattery() which is called when the battery pick-up is picked up.
It first checks if the battery pick-up has already been activated, and if so, it returns.
Then it retrieves the player's inventory using the "Player" tag, and adds the specified number of batteries to it.
After that, it destroys the battery pick-up game object and sets the _batteryPickUpActivated flag to true.
*/

public class BatteryPickUp : MonoBehaviour
{
    public int _addBatteriesToInventory = 1;
    public bool _batteryPickUpActivated;

    void start() {
      _batteryPickUpActivated = false;
    }

    public void PickUpBattery() {
        if(_batteryPickUpActivated == true)
        return;

        Inventory temp = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        temp.BatteryToInventory(_addBatteriesToInventory);

        Destroy(gameObject);
        _batteryPickUpActivated = true;
    }
}
