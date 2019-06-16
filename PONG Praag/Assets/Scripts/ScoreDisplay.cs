using UnityEngine;
using UnityEngine.UI;
namespace Assets.Scripts
{
    [RequireComponent(typeof(Text))]
    class ScoreDisplay : MonoBehaviour
    {
        [SerializeField]
        private ScoreArea _scoreArea;

        private Text _text;

        private void Awake()
        {
            this._text = this.GetComponent<Text>();
        }

        private void Update()
        {
            this._text.text = this._scoreArea.Score.ToString();
        }
    }
}
