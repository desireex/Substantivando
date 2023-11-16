using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Dan.Main;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> names; 
    [SerializeField] private List<TextMeshProUGUI> scores;
    private string publicLeaderboardKey = "46842fa806092d7769764c3dfe38766076be4c3dbd3c718568937fb3c09e6318";

    private void Start(){
        GetLeaderboard();
    }
    public void GetLeaderboard(){
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey,((msg) => {
            int loopLength = (msg.Length < names.Count) ? msg.Length : names.Count;
            for(int i = 0; i < loopLength; ++i){
                names[i].text = msg[i].Username;
                scores[i].text = msg[i].Score.ToString();
            }}));
    }
    public void SetLeaderboardEntry(string username, int score){
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score, ((msg) => {
        GetLeaderboard();}));
    }
}
