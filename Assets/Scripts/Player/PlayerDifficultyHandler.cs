using UnityEngine;
using System.Collections;

[System.Serializable]
public class DifficultySettings
{
    public float maxLife;
    public float maxShield;
    public float shieldRegenRate;
    public float fireRate;
}

public class PlayerDifficultyHandler : MonoBehaviour {

    public DifficultySettings easyDifficulty = new DifficultySettings();
    public DifficultySettings mediumDifficulty = new DifficultySettings();
    public DifficultySettings hardDifficulty = new DifficultySettings();

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
                    /*
                    life.maxLives = 5;
                    life.maxShield = 7;
                    life.shieldRegentBySec = 0.3f;
                    shooting.fireRate = 5.5f;
                    */
                    life.maxLives = easyDifficulty.maxLife;
                    life.maxShield = easyDifficulty.maxShield;
                    life.shieldRegentBySec = easyDifficulty.shieldRegenRate;
                    shooting.fireRate = easyDifficulty.fireRate;
                    break;
                }
            case GameDifficulty.Medium:
                {
                    /*
                    life.maxLives = 4;
                    life.maxShield = 6;
                    life.shieldRegentBySec = 0.25f;
                    shooting.fireRate = 4.5f;
                    */
                    life.maxLives = mediumDifficulty.maxLife;
                    life.maxShield = mediumDifficulty.maxShield;
                    life.shieldRegentBySec = mediumDifficulty.shieldRegenRate;
                    shooting.fireRate = mediumDifficulty.fireRate;
                    break;
                }
            case GameDifficulty.Hard:
                {
                    /*
                    life.maxLives = 3;
                    life.maxShield = 5;
                    life.shieldRegentBySec = 0.15f;
                    shooting.fireRate = 3.5f;
                    */
                    life.maxLives = hardDifficulty.maxLife;
                    life.maxShield = hardDifficulty.maxShield;
                    life.shieldRegentBySec = hardDifficulty.shieldRegenRate;
                    shooting.fireRate = hardDifficulty.fireRate;
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
                    /*
                    life.maxLives = 5;
                    life.maxShield = 7;
                    life.shieldRegentBySec = 0.3f;
                    shooting.fireRate = 5.5f;
                    */
                    life.maxLives = easyDifficulty.maxLife;
                    life.maxShield = easyDifficulty.maxShield;
                    life.shieldRegentBySec = easyDifficulty.shieldRegenRate;
                    shooting.fireRate = easyDifficulty.fireRate;
                    break;
                }
            case GameDifficulty.Medium:
                {
                    /*
                    life.maxLives = 4;
                    life.maxShield = 6;
                    life.shieldRegentBySec = 0.25f;
                    shooting.fireRate = 4.5f;
                    */
                    life.maxLives = mediumDifficulty.maxLife;
                    life.maxShield = mediumDifficulty.maxShield;
                    life.shieldRegentBySec = mediumDifficulty.shieldRegenRate;
                    shooting.fireRate = mediumDifficulty.fireRate;
                    break;
                }
            case GameDifficulty.Hard:
                {
                    /*
                    life.maxLives = 3;
                    life.maxShield = 5;
                    life.shieldRegentBySec = 0.15f;
                    shooting.fireRate = 3.5f;
                    */
                    life.maxLives = hardDifficulty.maxLife;
                    life.maxShield = hardDifficulty.maxShield;
                    life.shieldRegentBySec = hardDifficulty.shieldRegenRate;
                    shooting.fireRate = hardDifficulty.fireRate;
                    break;
                }
        }
    }
}
