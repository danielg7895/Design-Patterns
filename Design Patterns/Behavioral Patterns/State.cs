using System;

namespace StatePattern
{
    class State
    {
        public void Main()
        {
            Player player = new Player(50);
            player.RecieveDamage(10);
            player.SelfHeal();

            Console.WriteLine("");

            player.RecieveDamage(40);
            player.SelfHeal();
        }
    }

    public class Player
    {
        private int _hp;
        private BaseState _playerState;

        public Player(int hp)
        {
            _hp = hp;

            CheckState();
        }

        public void SelfHeal()
        {
            _playerState.SelfHeal();
        }

        public void RecieveDamage(int damage)
        {
            if (_hp > 0)
            {
                Console.WriteLine($"I recieved {damage} damage!");
                _hp -= damage;
                CheckState();
            }
            else 
                Console.WriteLine("The player is already dead!");
        }

        public void CheckState()
        {
            if (_hp <= 0)
            {
                Console.WriteLine("Player is dead!");
                _hp = 0;
                _playerState = new DeadState(this);
            }
            else
            {
                if (_playerState?.GetType() != typeof(AliveState))
                    _playerState = new AliveState(this);
            }
        }

    }

    // state
    public abstract class BaseState
    {
        Player _player;

        public BaseState(Player player)
        {
            _player = player;
        }

        public abstract void SelfHeal();
    }

    public class DeadState : BaseState
    {
        public DeadState(Player player) : base(player) { }
        public override void SelfHeal()
        {
            Console.WriteLine("I'm dead, i can't use heal!");
        }
    }

    public class AliveState : BaseState
    {
        public AliveState(Player player) : base(player) { }

        public override void SelfHeal()
        {
            Console.WriteLine("I'm healing myself!");
        }
    }
}
