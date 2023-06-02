using UnityEngine;

namespace UI.Dice
{
    public class DiceUIView
    {
        private readonly SpriteRenderer _playerDice, _enemyDice;

        public DiceUIView(SpriteRenderer playerDice, SpriteRenderer enemyDice)
        {
            _playerDice = playerDice;
            _enemyDice = enemyDice;
        }

        public void SetDice(Sprite playerRoll, Sprite enemyRoll)
        {
            _playerDice.sprite = playerRoll;
            _enemyDice.sprite = enemyRoll;
        }
    }
}