using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public abstract class Command : MonoBehaviour
    {
        public abstract void Execute();
    }
}


