using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

[TestFixture]
public class ActionMasterTest {

	private ActionMaster.Action endTurn = ActionMaster.Action.EndTurn;
//	private ActionMaster.Action reset = ActionMaster.Action.Reset;

	[Test]
	public void PassingTest ()
	{
		Assert.AreEqual (1, 1);
	}

	[Test]
	public void T01OneStrikeReturnsEndTurn ()
	{
		ActionMaster actionMaster = new ActionMaster ();
		Assert.AreEqual (endTurn, actionMaster.Bowl (10));
	}

//	[Test]
//	public void FirstStrikeReturnReset ()
//	{
//		ActionMaster actionMaster = new ActionMaster ();
//		Assert.AreEqual (reset, actionMaster.Bowl (10));
//	}
}
