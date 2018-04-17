using Detalii;
using UnityEngine;

public class test : MonoBehaviour {

    Parent parent = new Parent();
    Child child;


    private void Start()
    {
        parent = new Parent();
        //parent.Show();

        child = new Child();

        child.Index = 5;
        child.ShowChild();
        child.Show();

        var myClass = new Child();
        var anotherParent = new Parent();


        var anotherChild = myClass;
    }

}


public class Parent
{
    public bool isParent;

    public void Show()
    {
        Debug.Log("I am parent");
    }
}

namespace Detalii
{

    public class Child : Parent
    {



        public int Index;

        public void ShowChild()
        {
            Debug.Log("I am child");
        }

        public void Show()
        {
            Debug.Log("test");
        }
    }


    public class SmallerChild : Child
    {

    }
}