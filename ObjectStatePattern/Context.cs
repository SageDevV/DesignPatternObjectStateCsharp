namespace ObjectStatePattern
{
    public class Context
    {
        private State _state = null;
        public Context(State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            Console.WriteLine($"Context: Transita para {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Requisicao1()
        {
            _state.Handle1();
        }

        public void Requisicao2()
        {
            _state.Handle2();
        }
    }
}

