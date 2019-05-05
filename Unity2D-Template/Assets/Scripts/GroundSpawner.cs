using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : Spawn
{
	public float StartingPositionX = -100;
	public float StartingPositionY = -100;

	public Transform BaseA;
	public Transform BaseB;

	public Vector3 BaseAPosition = new Vector3();
	public Vector3 BaseBPosition = new Vector3();

    // Start is called before the first frame update
    void Awake()
    {
		for (int row = 0; row < 30; row++)
		{
			for (int col = 0; col < 200; col++)
			{
				Instantiate(Prefab, new Vector3((StartingPositionX + col) * ObjectDistance, (StartingPositionY + row) * ObjectDistance), Quaternion.identity);
			}
		}

		Instantiate(BaseA, BaseAPosition, Quaternion.identity);
		Instantiate(BaseB, BaseBPosition, Quaternion.identity);
	}
}
