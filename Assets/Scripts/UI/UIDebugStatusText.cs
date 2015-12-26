using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIDebugStatusText : MonoBehaviour {

    public Text statusText;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        statusText.text = Difficulty.difficultyModifier.ToString();
	}
}
