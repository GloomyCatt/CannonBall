using Domain.Target;
using UnityEngine;
using UnityEngine.UI;


namespace Domain.UI
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;
        [SerializeField] private AbstractTarget _target;
        [SerializeField] private int _scorePerHit;

        private int _score;


        private void OnEnable()
        {
            _target.hit.AddListener(UpdateUI);
        }
        private void UpdateUI()
        {
            _score = _score + _scorePerHit;
            _scoreText.text = _score.ToString();
        }
    }
        

    
}
