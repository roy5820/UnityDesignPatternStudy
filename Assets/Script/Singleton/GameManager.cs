using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Chapter.Singleton
{
    public class GameManager : Singleton<GameManager>
    {
        private DateTime _sessionStartTime;
        private DateTime _sessionEndTime;

        private void Start()
        {
            // 게임 시작 시 처리 코드

            _sessionStartTime = DateTime.Now;
            Debug.Log("Game session start @: "+ DateTime.Now);
        }

        private void OnApplicationQuit()
        {
            //게임 종료 시 처리
            _sessionEndTime = DateTime.Now;
            TimeSpan timeDifference = _sessionEndTime.Subtract(_sessionStartTime);

            Debug.Log("Game session ended @: " + DateTime.Now);
            Debug.Log("Game session lasted: " + timeDifference);
        }

        private void OnGUI()
        {
            if(GUILayout.Button("Next Scene")){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}