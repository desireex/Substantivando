using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TMP_InputField inputName;
    public UnityEvent <string , int> submitScoreEvent;
    public void SubmitScore(){
        submitScoreEvent.Invoke(inputName.text, PlayerPrefs.GetInt("Score"));
    }
}
