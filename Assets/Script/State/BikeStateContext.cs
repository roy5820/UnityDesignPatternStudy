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

        //현재 상태 업데이트
        public void Transition()
        {
            CurrentState.Handle(_bikeController);
        }

        //상태 전환
        public void Transition(IBikeState state)
        {
            CurrentState = state;
            CurrentState.Handle(_bikeController);
        }
    }
}
