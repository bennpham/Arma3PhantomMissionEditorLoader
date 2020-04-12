# Additional Script Setup Guide Plus Tips

The purpose of this guide is to help you with any additional setups for additional scripts or description.ext settings you enabled as well as provide a few other helpful editing tips.

## Additional Setup


### Handling extra ACE loadouts

Refer to https://ace3mod.com/wiki/class-names.html for list of ACE classnames.

In **init.sqf**, there should be the following code block:

```
// Adds extra ace equipments to player's uniforms or vests.
//	Example 1: ammobox1 addItemCargoGlobal ["ACE_bloodIV", 2];
//	Example 2: uniformContainer p1 addMagazineCargoGlobal ["ACE_M84", 6];
if (isServer && isClass (configFile >> "CfgMods" >> "ace")) then {
    // TODO
};
```

You'll need to replace `TODO` with something like the following:

```
ammobox addItemCargoGlobal ["ACE_bloodIV", 2];

uniformContainer p1 addMagazineCargoGlobal ["ACE_M84", 6];
vestContainer p1 addMagazineCargoGlobal ["ACE_M84", 6];
unitBackPack p1 addItemCargoGlobal ["ACE_bloodIV", 2];
```

### FHQ Task Tracker Settings

To set a task as success, cancel, or fail:

```
["task1", "succeeded"] call FHQ_fnc_ttSetTaskState;
["task1", "cancelled"] call FHQ_fnc_ttSetTaskState;
["task1", "failed"] call FHQ_fnc_ttSetTaskState;
```

Use for conditions or if statements to check that tasks are successful:

```
["task1", "task2", "task3"] call FHQ_fnc_ttAreTasksSuccessful
["task1"] call FHQ_fnc_ttIsTaskSuccessful
```

Use to check that the task has fail or was cancelled:

```
["task1"] call FHQ_fnc_ttIsTaskCompleted &&
!(["task1"] call FHQ_fnc_ttIsTaskSuccessful)
```


### Delete all units with FHQ_Tag when using FHQ Eden Plugin

This is useful for attempting to scale units back base on player counts if you enabled **Description Params (Player Count Scale)**.

```
{
	if (_x getVariable ["FHQ_TagA", false]) then {
		deleteVehicle _x;
	};
} foreach allUnits;
```


### FHQ Detect

* Create a repeatable trigger with OPFOR present (if enemy forces are OPFOR)
	* use BLUFOR or IND if enemy forces are on that side instead
* Parameter 1: Group of units that'll trigger detection if spotted
* Parameter 2: The trigger you want to check

```
[playableUnits, thisList] call FHQ_fnc_detectedBy

[(if (isMultiplayer) then {playableUnits} else {switchableUnits}), thisList] call FHQ_fnc_detectedBy

[[unit1,unit2,unit3,unit4]], thisList] call FHQ_fnc_detectedBy
```


### FHQ Force Tracker

Adds map markers to track your units on the map. In your `init.sqf` after `call compile preProcessFileLineNumbers "scripts\briefing.sqf";`, add the following lines

```
[grp_alpha, "inf", "Alpha"] call FHQ_fnc_forceTrackAdd;
[grp_bravo, "inf", "Bravo"] call FHQ_fnc_forceTrackAdd;
[grp_eagle, "air", "Eagle"] call FHQ_fnc_forceTrackAdd;

call FHQ_fnc_forceTrackStart;
```

* Parameter 1: Group name
* Parameter 2: Marker type (refer to https://community.bistudio.com/wiki/cfgMarkers minus side prefix <default to `inf`>)
* Parameter 3: Name/Callsign (default to group name)
* Parameter 4: Icon Scale (does nothing)
* Parameter 5: Color (default to side color)

* Call `[grp] call FHQ_fnc_forceTrackRemove;` to remove group from force tracking and delete icon.
* Call `[2] call FHQ_fnc_forceTrackSetDelay;` to delay icon update by 2 seconds if performance is impacted
	* You can use `0.1` for smoothest display if performance isn't a problem
	* Default is `0.3`


### FHQ Marker Patrol

* Create an area marker called `area0` then put the following commands in the group leader's init.
* You might want to make sure that the group leader has a name.

```
[this, "area0"] call FHQ_fnc_markerPatrol;
[this, "area0", 6, false, false, true] call FHQ_fnc_markerPatrol;
```

* Parameter 1: group or leader of group
* Parameter 2: name of the marker (default: name of group leader)
* Parameter 3: number of waypoints for group (default: 6)
* Parameter 4: generate new waypoint at end of patrol (default: false)
* Parameter 5: prefer waypoints near road (default: false)
* Parameter 6: deletes all previous waypoints (default: true)


### FHQ Loadout

Put this in the unit init or spawn script and replace `this` with unit name

```
[this, "scripts\loadout\gun.sqf"] call FHQ_fnc_safeAddLoadout;
```

I recommend that you generate the loadout via [FHQ Debug Console](http://ciahome.net/forum/showthread.php?tid=3723).



## Editing Tips

### Display to all players

This will come in handy for something like cutText and hints where you want all players to see the message on dedicated servers.

```
["Text to display in the hint"] remoteExec ["hint"];
[["Hello World!", "PLAIN DOWN"]] remoteExec ["cutText"];
```

If you don't use `remoteExec`, some players will see the message on dedicated servers while others will not.

### Calling External Scripts

In your triggers `on activation` box, add the following:

```
call compile preprocessFileLineNumbers "scripts\spawn\enemy_spawn.sqf";
```

Make sure if your script should only need to run server side, you wrap your code with a `if (isServer) then {};` block to only run it once, otherwise the script will run multiple times by the number of players on the server for each client.

Example spawn script:

```
if (isServer) then {
	_enemyCar = "CUP_O_LR_MG_TKM" createVehicle [(getMarkerPos "spawn") select 0,(getMarkerPos "spawn") select 1,0];
	_car setDir 180;

	enemyGrp = createCenter east;
	enemyGrp = createGroup east;
	_leader = enemyGrp createUnit ["CUP_O_TK_INS_Soldier", [(getMarkerPos "spawn") select 0,(getMarkerPos "spawn") select 1,0], [], 3, "FORM"];
	_unit1 = enemyGrp createUnit ["CUP_O_TK_INS_Soldier", [(getMarkerPos "spawn") select 0,(getMarkerPos "spawn") select 1,0], [], 3, "FORM"];

	[_leader, "scripts\loadout\rifle_ak47.sqf"] call FHQ_fnc_safeAddLoadout;
	[_unit1, "scripts\loadout\rifle_ak47.sqf"] call FHQ_fnc_safeAddLoadout;

	_leader setskill 0.65;
	_unit1 setskill 0.33;
	_leader = leader enemyGrp;

	_leader moveInDriver _enemyCar;
	_unit1 moveInGunner _enemyCar;

	wp1 = enemyGrp addWaypoint [getMarkerPos "attack_path", 0];
	wp1 setWaypointType "MOVE";
	wp1 setWaypointStatements ["true", ""];

	wp2 = enemyGrp addWaypoint [getMarkerPos "start", 0, 50];
	wp2 setWaypointType "SAD";
	wp2 setWaypointStatements ["true", ""];

	wp3 = enemyGrp addWaypoint [getMarkerPos "start", 0];
	wp3 setWaypointType "CYCLE";
	wp3 setWaypointStatements ["true", ""];
};
```

Example ammobox script:

```
if (isServer) then {

	clearmagazinecargoglobal _this;
	clearweaponcargoglobal _this;
	clearItemCargoglobal _this;
	clearBackpackCargoGlobal _this;

	// Weapons
	_this addWeaponCargoGlobal ["CUP_arifle_AKM", 2];

	// Ammo
	_this addMagazineCargo ["CUP_30Rnd_762x39_AK47_M", 50];

	// Grenades & Satchels
	_this addMagazineCargo ["CUP_PipeBomb_M", 10];
	_this addMagazineCargo ["CUP_MineE_M", 10];

	// Item
	_this addItemCargoGlobal ["FirstAidKit", 10];
	_this addItemCargoGlobal ["MediKit", 5];

	// Backpack
	_this addBackpackCargoGlobal ["CUP_B_RUS_Backpack", 3];
	_this addBackpackCargoGlobal ["CUP_B_RPGPack_Khaki", 2];

	// Add ACE equipments if ACE is loaded
	if (isClass (configFile >> "CfgMods" >> "ace")) then {
		_this addItemCargoGlobal ["ACE_Flashlight_MX991", 5];
		_this addItemCargoGlobal ["ACE_EarPlugs", 5];
		_this addItemCargoGlobal ["ACE_MapTools", 5];
		_this addItemCargoGlobal ["ACE_Clacker", 5];
		_this addItemCargoGlobal ["ACE_RangeCard", 1];
		_this addItemCargoGlobal ["ACE_SpottingScope", 1];
	};
};
```