using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
	private System.Random random;

	public GameObject[] Units;
	public Vector3 SpawnPosition;
	public Team Team;

    // Start is called before the first frame update
    void Start()
    {
		random = new System.Random();
    }

	private void OnMouseEnter()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Instantiate(Units[random.Next(0, Units.Length-1)], SpawnPosition, Quaternion.identity);
		}
	}
}

public enum Team
{
	TeamA,
	TeamB
}