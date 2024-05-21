using Chapter.EventBus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.Command
{
    public class ToggleTurbo : Command
    {
        private BikeController _controller;

        public ToggleTurbo(BikeController controller)
        {
            _controller = controller;
        }

        public override void Execute()
        {
            _controller.ToggleTurbo();
        }
    }
}