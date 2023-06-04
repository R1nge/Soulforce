using Units;

namespace Enhances
{
    public abstract class Enhance
    {
        private int _duration;

        protected Enhance(int duration)
        {
            _duration = duration;
        }

        public int GetDuration() => _duration;

        public virtual void Execute(UnitBase target) => _duration--;
    }
}