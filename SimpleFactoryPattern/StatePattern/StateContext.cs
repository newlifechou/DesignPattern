using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class StateContext
    {
        private State state;
        public StateContext(State state)
        {
            this.state = state;
        }
        public State CurrentState
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                Console.WriteLine($"CurrentState:{state.GetType().Name}");
            }
        }

        public void RequestState()
        {
            state.Handle();
        }
    }
}
