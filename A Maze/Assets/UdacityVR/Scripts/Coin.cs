using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    // Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity
    public GameObject coinPoofPrefab;

    public GameObject objectToRotate;

    public float timeScale = 50f;

    public float timeDestroy = 0.5f;

    void Update () {
        // OPTIONAL-CHALLENGE: Animate the coin rotating
        // TIP: You could use a method from the Transform class
        objectToRotate.transform.Rotate(0f, Time.timeScale, 0f);
    }


	public void OnCoinClicked () {
		/// Called when the 'Coin' game object is clicked
		/// - Displays a poof effect (handled by the 'CoinPoof' prefab)
		/// - Plays an audio clip (handled by the 'CoinPoof' prefab)
		/// - Removes the coin from the scene

		// Prints to the console when the method is called
		Debug.Log ("'Coin.OnCoinClicked()' was called");
        Instantiate(coinPoofPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject, timeDestroy);
        // TODO: Display the poof effect and remove the coin from the scene
        // Use Instantiate() to create a clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
        // Use Destroy() to delete the coin after for example 0.5 seconds
    }
}
