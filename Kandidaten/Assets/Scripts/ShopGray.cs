using UnityEngine;

public class ShopGray: MonoBehaviour {

//orange
	public TurretBlueprint woodGray;
	public TurretBlueprint stoneGray;

	public void selectWoodGray(){
		if(playerStats.moneyGray < woodGray.cost)
		{
			print("NOT ENOUGH MONEY");
			return;
		}
		playerStats.moneyGray -= woodGray.cost;
		GameObject turret = (GameObject) Instantiate(woodGray.prefab, new Vector3(10f,0.5f,10f), Quaternion.identity);
	}

	public void selectStoneGray(){
		if(playerStats.moneyGray < stoneGray.cost)
		{
			print("NOT ENOUGH MONEY");
			return;
		}
		playerStats.moneyGray -= stoneGray.cost;
		GameObject turret = (GameObject) Instantiate(stoneGray.prefab, new Vector3(10f,0.5f,10f), Quaternion.identity);
	}
}
