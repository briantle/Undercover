using UnityEngine;
using UnityEngine.UI;

public class HudDisplay : MonoBehaviour
{
	public PlayerController player;
	public Image sniperScope;
	public GameObject crosshair;
	public Text ammoText;
	public Text healthText;

	void Update(){
		healthText.text = "Health: " + player.health;
		if (player.currWeapon != null)
			ammoText.text = player.currWeapon.weaponName + ": " + player.currWeapon.ammo.loadedAmmo + "/" + player.currWeapon.ammo.reserveAmmo;
	}
}

