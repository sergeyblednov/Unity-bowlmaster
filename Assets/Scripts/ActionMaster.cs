﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionMaster {

	public enum Action { Tidy, Reset, EndTurn, EndGame };

	public Action Bowl(int pins) 
	{
		//Other behaviour here 

		if (pins == 10) {
			return Action.EndTurn;
		}

		//Other behaviour here 

		throw new UnityException ("Not sure what action to return!");
	}
}
