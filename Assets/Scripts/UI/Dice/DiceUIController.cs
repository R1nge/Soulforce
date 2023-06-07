using Dice;
using UnityEngine;
using VContainer;

namespace UI.Dice
{
    public class DiceUIController : MonoBehaviour
    {
        [SerializeField] private DiceUIModel diceUIModel;
        [SerializeField] private Sprite[] diceSprites;
        private DiceUIView _diceView;
        private DiceRollController _diceRollController;

        [Inject]
        private void Construct(DiceRollController diceRollController)
        {
            _diceRollController = diceRollController;
        }
        
        private void Awake()
        {
            _diceView = new(diceUIModel.playerDice, diceUIModel.enemyDice);
            _diceRollController.OnDiceRolled += OnDiceRolled;
        }

        private void OnDiceRolled(int playerRoll, int enemyRoll)
        {
            _diceView.SetDice(diceSprites[playerRoll], diceSprites[enemyRoll]);
        }

        private void OnDestroy()
        {
            _diceRollController.OnDiceRolled -= OnDiceRolled;
        }
    }
}