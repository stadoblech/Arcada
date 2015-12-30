﻿using UnityEngine;
using System.Collections;

public class PlayerDifficultyHandler : MonoBehaviour {

    PlayerLife life;
    PlayerShooting shooting;
    public bool disabledForTest;

	void Awake () {

        if(disabledForTest)
        {
            return;
        }

        life = GetComponent<PlayerLife>();
        shooting = GetComponent<PlayerShooting>();

	    switch(Difficulty.difficultyModifier)
        {
            case GameDifficulty.Easy:
                {
                    life.maxLives = 5;
                    life.maxShield = 7;
                    life.shieldRegentBySec = 0.5f;
                    shooting.fireRate = 4;
                    break;
                }
            case GameDifficulty.Medium:
                {
                    life.maxLives = 4;
                    life.maxShield = 6;
                    life.shieldRegentBySec = 0.25f;
                    shooting.fireRate = 3;
                    break;
                }
            case GameDifficulty.Hard:
                {
                    life.maxLives = 3;
                    life.maxShield = 5;
                    life.shieldRegentBySec = 0.1f;
                    shooting.fireRate = 2;
                    break;
                }
        }
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
