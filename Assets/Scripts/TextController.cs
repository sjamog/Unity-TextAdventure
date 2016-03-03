using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom }

	private States currentState;

	// Use this for initialization
	void Start ()
	{
		currentState = States.cell;

	}
	
	// Update is called once per frame
	void Update()
	{
		switch (currentState)
		{
			case States.cell:
				state_cell();
				break;
			case States.sheets_0:
				state_sheets_0();
				break;
			case States.mirror:
				state_mirror();
				break;
			case States.lock_0:
				state_lock_0();
				break;
			case States.sheets_1:
				state_sheets_1();
				break;
			case States.cell_mirror:
				state_cell_mirror();
				break;
			case States.lock_1:
				state_lock_1();
				break;
			case States.freedom:
				state_freedom();
				break;
			default:
				text.text = "You shouldn't be here";
				break;
		}
	}

	void state_cell()
	{
		text.text =
				"You are in a prison cell and want to escape.  There are some dirty sheets on the bed, a mirror on the wall, and the door is locked from the outside.\n\n" +
				"Press 'S' to view Sheets, 'M' for Mirror, and 'L' for Lock.";
		if (Input.GetKeyDown(KeyCode.S))
		{
			currentState = States.sheets_0;
		}
		else if (Input.GetKeyDown(KeyCode.M))
		{
			currentState = States.mirror;
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			currentState = States.lock_0;
		}
	}

	void state_sheets_0()
	{
		text.text = "These sheets are crusty, smelly, and of no use to you other than at night when you get \"lonely\".\n\n" +
		            "Press 'R' to Return.";
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
	}

	void state_lock_0()
	{
		text.text = "The lock is pretty tough.  Your telekinetic powers are no match for this marvel of engineering.\n\n" +
					"Press 'R' to Return.";
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
	}

	void state_mirror()
	{
		text.text = "You cracked this mirror the first night you were put in this cell.  You realized you had forgotten to DVR \"So You Think You Can Squirt\" before you got arrested." +
			"Some of these cracks look like it would shatter the mirror into extremely thin, keyhole-sized fragments.  Hmmm...\n\n" +
					"Press 'A' to Annihilate the mirror. Press 'R' to Return.";
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			currentState = States.cell_mirror;
		}
	}

	void state_sheets_1()
	{
		text.text = "With your sharp shards of mirror, you could shred your sheets.  Turn them into a tool with which to strangle a passing guard, perhaps?" +
					"OR just stab them with your mirror-daggers.  There are so many. You can afford to lose a few inside the guard's abdomen.\n\n" +
					"Press 'R' to Return.";
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
	}

	void state_cell_mirror()
	{
		text.text = "It's just you, your cell, and the hundreds of shards of mirror on the floor.  You didn't injure yourself annihilating the thing.  You're such a pro.\n\n" +
					"Press 'S' to view Sheets, 'M' for Mirror, and 'L' for Lock.";
		if (Input.GetKeyDown(KeyCode.S))
		{
			currentState = States.cell;
		}
	}

	void state_lock_1()
	{
		text.text = "These sheets are crusty, smelly, and of no use to you other than at night when you get \"lonely\".\n\n" +
					"Press 'R' to Return.";
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
	}

	void state_freedom()
	{
		text.text = "These sheets are crusty, smelly, and of no use to you other than at night when you get \"lonely\".\n\n" +
					"Press 'R' to Return.";
		if (Input.GetKeyDown(KeyCode.R))
		{
			currentState = States.cell;
		}
	}
}
