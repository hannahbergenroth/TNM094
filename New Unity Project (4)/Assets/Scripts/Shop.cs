using UnityEngine;

public class Shop : MonoBehaviour {

	public TurretBlueprint standardTurret;
	public TurretBlueprint missileLauncher;



	public void selectStandardTurret(){
		if(playerStats.money < standardTurret.cost)
		{
			print("NOT ENOUGH MONEY");
			return;
		}
		playerStats.money -= standardTurret.cost;
		GameObject turret = (GameObject) Instantiate(standardTurret.prefab, new Vector3(5f,0.5f,5f), Quaternion.identity);
	}

	public void selectMissileTurret(){
		if(playerStats.money < standardTurret.cost)
		{
			print("NOT ENOUGH MONEY");
			return;
		}
		playerStats.money -= missileLauncher.cost;
		GameObject turret = (GameObject) Instantiate(missileLauncher.prefab, new Vector3(5f,0.5f,5f), Quaternion.identity);
	}


}
