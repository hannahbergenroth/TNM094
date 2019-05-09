using UnityEngine;

public class Shop : MonoBehaviour {

//orange
	public TurretBlueprint woodOrange;
	public TurretBlueprint stoneOrange;

	public void selectWoodOrange(){
		if(playerStats.moneyOrange < woodOrange.cost)
		{
			print("NOT ENOUGH MONEY");
			return;
		}
		playerStats.moneyOrange -= woodOrange.cost;
		GameObject turret = (GameObject) Instantiate(woodOrange.prefab, new Vector3(5f,0.5f,5f), Quaternion.identity);
	}

	public void selectStoneOrange(){
		if(playerStats.moneyOrange < stoneOrange.cost)
		{
			print("NOT ENOUGH MONEY");
			return;
		}
		playerStats.moneyOrange -= stoneOrange.cost;
		GameObject turret = (GameObject) Instantiate(stoneOrange.prefab, new Vector3(5f,0.5f,5f), Quaternion.identity);
	}
}
