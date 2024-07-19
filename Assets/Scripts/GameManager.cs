using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class GameManager : MonoBehaviour
    {

        public static GameManager Instance { get; private set; }
        public int Score { get; set; }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject); // Persist across scenes
                Debug.Log("GameManager initialized.");
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void SaveScoreToFile(string filename)
        {
            string path = Path.Combine(Application.persistentDataPath, filename);
            try
            {
                File.WriteAllText(path, Score.ToString());
                Debug.Log("Score saved to " + path);
            }
            catch (Exception e)
            {
                Debug.LogError("Failed to save score: " + e.Message);
            }
        }

        public void LoadContinue()
        {
            GameState gameState = GameState.Load("SaveGame.json");
            if (gameState != null)
            {
                Score = gameState.Score;
                // Load other game state variables here
                Debug.Log("Game state loaded.");
            }
        }
    }
}