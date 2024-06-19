using System.Collections;
using UnityEngine;

namespace Chapter.Observer
{
    public abstract class Subject : MonoBehaviour
    {
        private readonly ArrayList _observers = new ArrayList();//���������� ����� �迭����Ʈ

        //������ ��ü �߰�
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        //������ ��ü ����
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        //�������鿡�� �˸� �߻�
        public void NotifyObservers()
        {
            foreach(Observer observer in _observers)
            {
                observer.Notify(this);
            }
        }
    }
}
