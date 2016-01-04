using UnityEngine;
using System.Collections;

public class PlayerDifficultyHandler : MonoBehaviour {

    public bool enabledDifficulty;
    public GameDifficulty difficultyTest;

    PlayerLife life;
    PlayerShooting shooting;
    

	void Awake () {

        life = GetComponent<PlayerLife>();
        shooting = GetComponent<PlayerShooting>();

        if (!enabledDifficulty)
        {
            return;
        }

        

	    switch(Difficulty.difficultyModifier)
        {
            case GameDifficulty.Easy:
                {
                    life.maxLives = 5;
                    life.maxShield = 7;
                    life.shieldRegentBySec = 0.3f;
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
                    life.shieldRegentBySec = 0.15f;
                    shooting.fireRate = 2;
                    break;
                }
        }

        difficultyTestModifier();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    void difficultyTestModifier()
    {
        switch (difficultyTest)
        {
            case GameDifficulty.Easy:
                {
                    life.maxLives = 5;
                    life.maxShield = 7;
                    life.shieldRegentBySec = 0.5f;
                    shooting.fireRate = 4;
                    return;
                }
            case GameDifficulty.Medium:
                {
                    life.maxLives = 4;
                    life.maxShield = 6;
                    life.shieldRegentBySec = 0.25f;
                    shooting.fireRate = 3;
                    return;
                }
            case GameDifficulty.Hard:
                {
                    life.maxLives = 3;
                    life.maxShield = 5;
                    life.shieldRegentBySec = 0.1f;
                    shooting.fireRate = 2;
                    return;
                }
            case GameDifficulty.Default:
                {
                    break;
                }
        }
    }
}
