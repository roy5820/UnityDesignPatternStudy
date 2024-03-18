namespace Chapter.State
{
    public class BikeStateContext
    {
        public IBikeState CurrentState
        {
            get; set; 
        }

        private readonly BikeController _bikeController;

        
        public BikeStateContext(BikeController bikeController)
        {
            _bikeController = bikeController;
        }

        //���� ���� ������Ʈ
        public void Transition()
        {
            CurrentState.Handle(_bikeController);
        }

        //���� ��ȯ
        public void Transition(IBikeState state)
        {
            CurrentState = state;
            CurrentState.Handle(_bikeController);
        }
    }
}
